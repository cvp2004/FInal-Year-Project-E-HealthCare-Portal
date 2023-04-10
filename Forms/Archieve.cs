using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace OPD_Section.Forms
{
    public partial class Archieve : Form
    {

        // DATA MEMBERS:-
        public string VISITID = "";
        public Thread Th;
        public DBClasses db = new DBClasses();


        public Archieve()
        {
            InitializeComponent();


            db.CreateConnection();
            SqlDataReader res = db.getData("Select * from VISITS;");
            if (res.HasRows)
            {
                while (res.Read())
                {
                    var index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells["VISIT_ID"].Value = res["VISIT_ID"];
                    dataGridView1.Rows[index].Cells["PERSON_ID"].Value = res["PERSON_ID"];
                    //dataGridView1.Rows[index].Cells["PERSON_NAME"].Value = res["PERSON_NAME"];
                    dataGridView1.Rows[index].Cells["PERSON_NAME"].Value = res["PERsON_NAME"];
                    string datetime = res["DATE"].ToString();
                    DateTime dt = DateTime.Parse(datetime);
                    string Date = dt.Date.ToString("dd/MM/yyyy");
                    string Time = dt.ToString("hh:mm:ss tt");


                    dataGridView1.Rows[index].Cells["DATE"].Value = Date;
                    dataGridView1.Rows[index].Cells["TIME"].Value = res["TIME"];

                }

            }
            else
            {
                MessageBox.Show("No Record To Display!");
            }

            db.CloseConnection();


        }

        private void Archieve_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                VISITID = row.Cells["VISIT_ID"].Value.ToString();
            }

            Th = new Thread(OpenViewDetails);
            Th.SetApartmentState(ApartmentState.STA);
            Th.Start();

        }

        public void OpenViewDetails()
        {
            Application.Run(new ViewDetails(VISITID, "ARCHIVE"));
        }

    }
}
