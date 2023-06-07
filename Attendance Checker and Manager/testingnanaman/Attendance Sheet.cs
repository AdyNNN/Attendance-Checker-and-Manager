using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace testingnanaman
{
    public partial class TeacherPortal : MetroFramework.Forms.MetroForm
    {
        private DataTable attendance = new DataTable();
        private LiteDatabase db;
        bool editing = false;
        public TeacherPortal()
        {
            InitializeComponent();
        }

        private void TeacherPortal_Load(object sender, EventArgs e)
        {
            attendance.Columns.Add("StudentID");
            attendance.Columns.Add("FirstName");
            attendance.Columns.Add("MiddleName");
            attendance.Columns.Add("LastName");
            attendance.Columns.Add("Section");
            attendance.Columns.Add("Status");
            dataGridView1.DataSource = attendance;

            db = new LiteDatabase(DBConnection.databaseConnection_attendance);
            var attendanceDataCollection = db.GetCollection<AttendanceData>("attendanceData");
            var attendanceData = attendanceDataCollection.FindAll().ToList();

            foreach (var data in attendanceData)
            {
                attendance.Rows.Add(data.StudentID, data.FirstName, data.MiddleName, data.LastName, data.Status, data.Section);
            }
        }
        public class AttendanceData
        {
            public int StudentID { get; set; }
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public string Section { get; set; }
            public string Status { get; set; }

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //add
        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                if (rowIndex >= 0 && rowIndex < attendance.Rows.Count)
                {
                    metroTextBoxStudentID.Text = attendance.Rows[rowIndex].Field<int>("StudentID").ToString();
                    metroTextBoxFirstName.Text = attendance.Rows[rowIndex].Field<string>("FirstName");
                    metroTextBoxMiddleName.Text = attendance.Rows[rowIndex].Field<string>("MiddleName");
                    metroTextBoxLastName.Text = attendance.Rows[rowIndex].Field<string>("LastName");
                    metroTextBoxStatus.Text = attendance.Rows[rowIndex].Field<string>("Status");
                    metroTextBoxSection.Text = attendance.Rows[rowIndex].Field<string>("Section");

                    editing = true;
                }
            }
        }

        //load
        private void metroButton3_Click(object sender, EventArgs e)
        {
            int StudentID = Convert.ToInt32(metroTextBoxStudentID.Text);
            string FirstName = metroTextBoxFirstName.Text;
            string MiddleName = metroTextBoxMiddleName.Text;
            string LastName = metroTextBoxLastName.Text;
            string Status = metroTextBoxStatus.Text;
            string Section = metroTextBoxSection.Text;

            if (metroTextBoxStudentID.Text == "" || metroTextBoxFirstName.Text == "" || metroTextBoxMiddleName.Text == "" || metroTextBoxLastName.Text == "" || metroTextBoxStatus.Text == "" || metroTextBoxSection.Text == "")
            {
                MessageBox.Show("Field cannot be empty.");
                return;
            }

            if (editing)
            {
                attendance.Rows[dataGridView1.CurrentCell.RowIndex]["StudentID"] = StudentID;
                attendance.Rows[dataGridView1.CurrentCell.RowIndex]["FirstName"] = FirstName;
                attendance.Rows[dataGridView1.CurrentCell.RowIndex]["MiddleName"] = MiddleName;
                attendance.Rows[dataGridView1.CurrentCell.RowIndex]["LastName"] = LastName;
                attendance.Rows[dataGridView1.CurrentCell.RowIndex]["Status"] = Status;
                attendance.Rows[dataGridView1.CurrentCell.RowIndex]["Section"] = Section;

                var attendanceDataCollection = db.GetCollection<AttendanceData>("attendanceData");
                var data = attendanceDataCollection.FindById(dataGridView1.CurrentCell.RowIndex + 1);
                if (data != null)
                {
                    data.StudentID = StudentID;
                    data.FirstName = FirstName;
                    data.MiddleName = MiddleName;
                    data.LastName = LastName;
                    data.Status = Status;
                    data.Section = Section;
                    attendanceDataCollection.Update(data);
                }
            }
            else
            {
                attendance.Rows.Add(StudentID, FirstName, MiddleName, LastName, Status, Section);

                var columnDataCollection = db.GetCollection<AttendanceData>("attendanceData");
                var data = new AttendanceData
                {
                    StudentID = StudentID,
                    FirstName = FirstName,
                    MiddleName = MiddleName,
                    LastName = LastName,
                    Status = Status,
                    Section = Section
                };
                columnDataCollection.Insert(data);
            }

            metroTextBoxStudentID.Text = null;
            metroTextBoxFirstName.Text = null;
            metroTextBoxMiddleName.Text = null;
            metroTextBoxLastName.Text = null;
            metroTextBoxStatus.Text = null;
            metroTextBoxSection.Text = null;
            editing = false;
        }

        //save
        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroTextBoxStudentID.Text = null;
            metroTextBoxFirstName.Text = null;
            metroTextBoxMiddleName.Text = null;
            metroTextBoxLastName.Text = null;
            metroTextBoxStatus.Text = null;
            metroTextBoxSection.Text = null;
        }

        //delete
        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var attendanceDataCollection = db.GetCollection<AttendanceData>("attendanceData");

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int rowIndex = row.Index;

                    if (rowIndex >= 0 && rowIndex < attendance.Rows.Count)
                    {
                        int studentID = Convert.ToInt32(attendance.Rows[rowIndex]["StudentID"]);

                        // Delete from the DataTable
                        attendance.Rows.RemoveAt(rowIndex);

                        // Delete from the LiteDB database
                        var data = attendanceDataCollection.FindOne(Query.EQ("StudentID", studentID));

                        if (data != null)
                        {
                            attendanceDataCollection.Delete(data.StudentID);
                        }
                    }
                }

                // Update the LiteDB database
                attendanceDataCollection.DeleteAll();
                foreach (DataRow dataRow in attendance.Rows)
                {
                    var attendanceData = new AttendanceData
                    {
                        StudentID = Convert.ToInt32(dataRow["StudentID"]),
                        FirstName = dataRow["FirstName"].ToString(),
                        MiddleName = dataRow["MiddleName"].ToString(),
                        LastName = dataRow["LastName"].ToString(),
                        Status = dataRow["Status"].ToString(),
                        Section = dataRow["Section"].ToString()
                    };

                    attendanceDataCollection.Insert(attendanceData);
                }

                // Refresh the DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = attendance;
            }
        }

        //edits the table directly
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                    if (rowIndex >= 0 && rowIndex < attendance.Rows.Count)
                    {
                        metroTextBoxStudentID.Text = attendance.Rows[rowIndex].Field<int>("StudentID").ToString();
                        metroTextBoxFirstName.Text = attendance.Rows[rowIndex].Field<string>("FirstName");
                        metroTextBoxMiddleName.Text = attendance.Rows[rowIndex].Field<string>("MiddleName");
                        metroTextBoxLastName.Text = attendance.Rows[rowIndex].Field<string>("LastName");
                        metroTextBoxStatus.Text = attendance.Rows[rowIndex].Field<string>("Status");
                        metroTextBoxSection.Text = attendance.Rows[rowIndex].Field<string>("Section");

                        editing = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You can't open a blank file.");
            }
        }
    }
}
