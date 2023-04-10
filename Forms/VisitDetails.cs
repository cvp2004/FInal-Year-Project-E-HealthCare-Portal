using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using OPD_Section.Forms;
using System.Data.Entity;
using System.Data.SqlClient;
namespace OPD_Section
{



    // CONSTRUCTOR!
    public partial class VisitDetails : Form
    {

        // DATA MEMBERS!
        public Data data = new Data();
        public Thread th;







        // CONSTRUCTOR!
        public VisitDetails(Data d)
        {
            data = d;
            InitializeComponent();
            if (data.village_name != "")
            {
                V_combo.Text = data.village_name;
                HNO_combo.Text = data.house_no;
                PID_combo.Text = data.person_id;
            }
            
        }




        // OPEN MAIN FRAME!
        public void OpenMainFrame()
        {
            Application.Run(new MainFrame());
        }



        // OPEN SYMPTOMS!
        public void OpenSymptoms()
        {
            Symptoms s = new Symptoms(data);
            Application.Run(s);

        }





        // LOADING FORM
        private void VisitDetails_Load(object sender, EventArgs e)
        {

            if (data.symptom_name.Count != 0)
            {
                MessageBox.Show(data.symptom_name[0]);
            }


            if (PID_combo.Text != "") 
            {
                try
                {
                    string hid = HNO_combo.Text;
                    if (hid == "Select Village First!")
                    {
                        MessageBox.Show(hid);
                        return;
                    }
                    PID_combo.Items.Clear();
                    DBClasses db = new DBClasses();
                    db.CreateConnection();
                    SqlDataReader res = db.getData("Select * from Persons Where House_ID = " + hid + ";");
                    while (res.Read())
                    {
                        int id = Convert.ToInt32(res["Person_ID"]);
                        PID_combo.Items.Add(id);
                    }
                    db.CloseConnection();

                }
                catch (Exception E)
                {
                    MessageBox.Show("PID ERROR");
                }
            }

            if (V_combo.Text != "")
            {
                try
                {
                    HNO_combo.Items.Clear();
                    string vname = V_combo.Text;
                    DBClasses db = new DBClasses();
                    db.CreateConnection();
                    SqlDataReader res = db.getData("Select * from VILLAGES WHERE VILLAGE_NAME = '" + vname + "';");
                    res.Read();
                    int vid = Convert.ToInt32(res["VILLAGE_ID"]);
                    SqlDataReader res1 = db.getData("Select * from Houses WHERE Village_ID = " + vid + ";");
                    while (res1.Read())
                    {
                        int id = Convert.ToInt32(res1["House_ID"]);
                        HNO_combo.Items.Add(id);
                    }
                    db.CloseConnection();
                }
                catch(Exception E)
                {
                    E.ToString();
                    MessageBox.Show("Some Unknown Error Occured!");
                }
            }


            using (var data = new sampledbEntities())
            {
                foreach (VILLAGE row in data.VILLAGES)
                {
                    V_combo.Items.Add(row.VILLAGE_NAME);
                }
            }

        }


             




        // HOUSE NO COMBO BOX
        private void HNO_combo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {

                string hid = HNO_combo.Text;
                HNO_combo.Text = "";
                if (hid == "Select Village First!")
                {
                    MessageBox.Show(hid);
                    return;
                }
                PID_combo.Items.Clear();
                DBClasses db = new DBClasses();
                db.CreateConnection();
                SqlDataReader res = db.getData("Select * from Persons Where House_ID = " + hid + ";");
                if(res.HasRows)
                {
                    while (res.Read())
                    {
                        /* int id = Convert.ToInt32(res["Person_ID"]);
                         PID_combo.Items.Add(id);*/

                        string id = res["PERSON_ID"].ToString();
                        PID_combo.Items.Add(id);

                    }
                    db.CloseConnection();
                }
                else
                {
                    string message = "Person Data not Found For this House!";
                    string title = "Not Found!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    if(result == DialogResult.OK)
                    {
                        V_combo.Text = "";
                        HNO_combo.Text = "";
                        PID_combo.Text = "";
                    }
                }
                

            }
            catch (Exception E)
            {
                MessageBox.Show("Some Unknown Error Occured!");
            }

        }





        // PERSON ID COMBO BOX
        private void PID_combo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                string pid = PID_combo.Text;
                if(pid == "Select House No. First")
                {
                    MessageBox.Show(pid);
                    return;
                }
                DBClasses db = new DBClasses();
                db.CreateConnection();
                SqlDataReader res = db.getData("select * from PERSONS Where PERSON_ID = " + pid + ";");
                res.Read();


                data.village_name = V_combo.Text;
                data.house_no = HNO_combo.Text;
                data.person_id = PID_combo.Text;
                data.name = Convert.ToString(res["Name"]);
                data.age = Convert.ToString(res["Age"]);
                data.gender = Convert.ToString(res["gender"]);
                data.contact = Convert.ToString(res["PHONE_NO"]);
                //data.contact = Convert.ToString(res["PHONE_NO"]);

                string message = "\t   Person Details\t\n\n" +
                    "\tName = "+data.name+"\n" +
                    "\tAge = "+data.age+"\n" +
                    "\tGender = "+data.gender+"\n"+
                    "\tContact = "+data.contact+"";
                                        
                string title = "Do You Want To Continue?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    th = new Thread(OpenSymptoms);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    V_combo.Text = "";
                    HNO_combo.Text = "";
                    HNO_combo.Items.Clear();
                    PID_combo.Text = "";
                    PID_combo.Items.Clear();
                }
                db.CloseConnection();
            }
            catch(Exception E)
            {
                E.ToString();
                MessageBox.Show("Some Unknown Error Occured!");   
            }
        }




        // VILLAGE COMBO BOX
        private void V_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                HNO_combo.Items.Clear();
                HNO_combo.Text = "";
                string vname = V_combo.Text;
                DBClasses db = new DBClasses();
                db.CreateConnection();
                SqlDataReader res = db.getData("Select * from VILLAGES WHERE VILLAGE_NAME = '" + vname + "';");
                res.Read();
                int vid = Convert.ToInt32(res["VILLAGE_ID"]);
                //res.Close();
                SqlDataReader res1 = db.getData("Select * from Houses WHERE Village_ID = " + vid + ";");
                if(res1.HasRows)
                {
                    while (res1.Read())
                    {
                        int id = Convert.ToInt32(res1["House_ID"]);
                        HNO_combo.Items.Add(id);
                    }
                }
                else
                {
                    MessageBox.Show("No Data Found For Houses!");
                }
               
                db.CloseConnection();
            }
            catch(Exception E)
            {
                MessageBox.Show("Some Unknown Error Occured!");
            }
           
        }
       



        private void label2_Click(object sender, EventArgs e)
        {

        }





        //BACK BUTTON!
        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Do You Want To Go Back?\n\n" +
                "All of Your data Will be lost after Performing this Operation!";
            string title = "Are You Sure?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (result == DialogResult.Yes)
            {
                this.Close();
                th = new Thread(OpenMainFrame);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                data.Destroy();
            }



        }



        // CANCLE BUTTON!
        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Do You Want To Close This Application?\n\n" +
                "All of Your data Will be lost after closing the Application!";
            string title = "Are You Sure?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (result == DialogResult.Yes)
            {
                this.Close();
                th = new Thread(OpenMainFrame);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                data.Destroy();
            }

        }
    }
}
