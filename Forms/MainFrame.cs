using OPD_Section.Forms;
using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;


namespace OPD_Section
{
    public partial class MainFrame : Form
    {
        public Data data = new Data();
        public Thread Th;
        public DBClasses db = new DBClasses();
        public string VISITID = "";


        // CONSTRUCTOR!
        public MainFrame()
        {
            InitializeComponent();

            DateTimeTimer.Start();

            LoadDefaultTblVillage();
            LoadDefaultTblHouse();
            LoadDefaultTblPerson();

            LoadDefaultTblVillageLogs();
            LoadDefaultTblHouseLogs();
            LoadDefaultTblPersonLogs();

            LoadTxtHouseVillageName();
            LoadTxtPersonVillageName();
        }

        // LOADING DATA
        public void LoadData()
        {
            txt_personid.Text = "";
            txt_visitid.Text = "";
            txt_personname.Text = "";

            dataGridView1.Rows.Clear();

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

        // LOCADING MAIN FRAME!
        private void MainFrame_Load(object sender, EventArgs e)
        {

            LoadData();

        }

        // OPEN VISIT DETAILS
        public void OpenVisistDetails()
        {
            Application.Run(new VisitDetails(data));
        }

        // BUTTON  VISIT DETAILS!
        private void btn_newrecord_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Th = new Thread(OpenVisistDetails);
            Th.SetApartmentState(ApartmentState.STA);
            Th.Start();
        }

        // BUTTON SEARCH!
        private void btn_search_Click(object sender, EventArgs e)
        {
            /* string vid = txt_visitid.Text;
             string pid = txt_personid.Text;
             string pname = txt_personname.Text;
             string sql = "";

             dataGridView1.Rows.Clear();
             db.CreateConnection();

             if (txt_visitid.Text != "")
             {
                 sql = "Select * from Visits where VISIT_ID = '" + vid + "';";
             }

             if (txt_personid.Text != "")
             {
                 sql = "Select * from Visits where PERSON_ID = '" + pid + "';";
             }


             if (txt_personname.Text != "")
             {
                 sql = "Select * from Visits where PERSON_NAME Like '%" + pname + "%';";
             }




             SqlDataReader res = db.getData(sql);
             if (res.HasRows)
             {
                 while (res.Read())
                 {
                     var index = dataGridView1.Rows.Add();
                     dataGridView1.Rows[index].Cells["VISIT_ID"].Value = res["VISIT_ID"];
                     dataGridView1.Rows[index].Cells["PERSON_ID"].Value = res["PERSON_ID"];
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
 */

        }

        private void btn_archieve_Click(object sender, EventArgs e)
        {
            Th = new Thread(OpenArchieve);
            Th.SetApartmentState(ApartmentState.STA);
            Th.Start();
        }

        public void OpenArchieve()
        {
            Application.Run(new Archieve());
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txt_visitid_TextChanged(object sender, EventArgs e)
        {
            if (txt_visitid.Text != "")
            {
                txt_visitid.Enabled = true;
                txt_personid.Enabled = false;
                txt_personname.Enabled = false;
                string vid = txt_visitid.Text;
                string pid = txt_personid.Text;
                string pname = txt_personname.Text;
                string sql = "";

                dataGridView1.Rows.Clear();
                db.CreateConnection();

                if (txt_visitid.Text != "")
                {
                    sql = "Select * from Visits where VISIT_ID Like '%" + vid + "%';";
                }

                if (txt_personid.Text != "")
                {
                    sql = "Select * from Visits where PERSON_ID Like '%" + pid + "%';";
                }


                if (txt_personname.Text != "")
                {
                    sql = "Select * from Visits where PERSON_NAME Like '%" + pname + "%';";
                }




                SqlDataReader res = db.getData(sql);
                if (res.HasRows)
                {
                    while (res.Read())
                    {
                        var index = dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells["VISIT_ID"].Value = res["VISIT_ID"];
                        dataGridView1.Rows[index].Cells["PERSON_ID"].Value = res["PERSON_ID"];
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
                    txt_visitid.Text = "";
                    txt_personid.Text = "";
                    txt_personname.Text = "";
                }

                db.CloseConnection();

            }
            else
            {
                txt_visitid.Enabled = true;
                txt_personid.Enabled = true;
                txt_personname.Enabled = true;
                LoadData();
            }

















        }

        private void txt_personid_TextChanged(object sender, EventArgs e)
        {
            /*  if (txt_personid.Text != "")
              {
                  txt_visitid.Enabled = false;
                  txt_personid.Enabled = true;
                  txt_personname.Enabled = false;
              }
              else
              {
                  txt_visitid.Enabled = true;
                  txt_personid.Enabled = true;
                  txt_personname.Enabled = true;
              }*/

            if (txt_personid.Text != "")
            {

                txt_visitid.Enabled = false;
                txt_personid.Enabled = true;
                txt_personname.Enabled = false;

                string vid = txt_visitid.Text;
                string pid = txt_personid.Text;
                string pname = txt_personname.Text;
                string sql = "";

                dataGridView1.Rows.Clear();
                db.CreateConnection();

                if (txt_visitid.Text != "")
                {
                    sql = "Select * from Visits where VISIT_ID Like '%" + vid + "%';";
                }

                if (txt_personid.Text != "")
                {
                    sql = "Select * from Visits where PERSON_ID Like '%" + pid + "%';";
                }


                if (txt_personname.Text != "")
                {
                    sql = "Select * from Visits where PERSON_NAME Like '%" + pname + "%';";
                }




                SqlDataReader res = db.getData(sql);
                if (res.HasRows)
                {
                    while (res.Read())
                    {
                        var index = dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells["VISIT_ID"].Value = res["VISIT_ID"];
                        dataGridView1.Rows[index].Cells["PERSON_ID"].Value = res["PERSON_ID"];
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
                    txt_visitid.Text = "";
                    txt_personid.Text = "";
                    txt_personname.Text = "";

                }

                db.CloseConnection();

            }
            else
            {

                txt_visitid.Enabled = true;
                txt_personid.Enabled = true;
                txt_personname.Enabled = true;
                LoadData();
            }





        }

        private void txt_personname_TextChanged(object sender, EventArgs e)
        {
            if (txt_personname.Text != "")
            {

                txt_visitid.Enabled = false;
                txt_personid.Enabled = false;
                txt_personname.Enabled = true;

                string vid = txt_visitid.Text;
                string pid = txt_personid.Text;
                string pname = txt_personname.Text;
                string sql = "";

                dataGridView1.Rows.Clear();
                db.CreateConnection();

                if (txt_visitid.Text != "")
                {
                    sql = "Select * from Visits where VISIT_ID = '" + vid + "';";
                }

                if (txt_personid.Text != "")
                {
                    sql = "Select * from Visits where PERSON_ID = '" + pid + "';";
                }


                if (txt_personname.Text != "")
                {
                    sql = "Select * from Visits where PERSON_NAME Like '%" + pname + "%';";
                }




                SqlDataReader res = db.getData(sql);
                if (res.HasRows)
                {
                    while (res.Read())
                    {
                        var index = dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells["VISIT_ID"].Value = res["VISIT_ID"];
                        dataGridView1.Rows[index].Cells["PERSON_ID"].Value = res["PERSON_ID"];
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
                    txt_visitid.Text = "";
                    txt_personid.Text = "";
                    txt_personname.Text = "";

                }

                db.CloseConnection();

            }
            else
            {

                txt_visitid.Enabled = true;
                txt_personid.Enabled = true;
                txt_personname.Enabled = true;
                LoadData();
            }


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
            Application.Run(new ViewDetails(VISITID, ""));
        }

        /*******************************************************************************************************************************************************************/

        private void DateTimeTImer_Tick(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now;

            string Date = t.Date.ToString("dd/MM/yyyy");
            string Time = t.ToString("hh:mm:ss tt");

            LblDate.Text = "Date :- " + Date;
            LblTime.Text = "Time :- " + Time;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}