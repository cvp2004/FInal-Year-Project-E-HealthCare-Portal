using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

/*

string sql = "select count(UserID) from user_login where UserID=@UserID and pwd=@pwd";
SqlCommand cmd = new SqlCommand(sql, con);
SqlParameter[] param = new SqlParameter[2];
param[0] = new SqlParameter("@UserID", txtUSerID.Text);
param[1] = new SqlParameter("@pwd", txtPwd.Text);
cmd.Parameters.Add(param[0]);
cmd.Parameters.Add(param[1]);
*/


namespace OPD_Section.Forms
{
    public partial class Report : Form
    {

        // Data MEMBER!
        public Data data = new Data();
        public Thread th;
        public DBClasses db = new DBClasses();
        public string VISITID = "";



        // DUMMY DATA!
        public void DummyData()
        {
            data.village_name = "REVSA";
            data.house_no = "3";
            data.person_id = "14";
            data.name = "Jack";
            data.age = "5";
            data.gender = "Male";
            data.contact = "83465838364";
            data.symptom_name.Add("Symptom 1");
            data.symptom_name.Add("Symptom 2");
            data.symptom_description.Add("Symptom Description 1");
            data.symptom_description.Add("Symptom Description 2");
            data.medicine_id.Add("4");
            data.medicine_id.Add("5");
            data.medicine_name.Add("Medicine 1");
            data.medicine_name.Add("Medicine 2");
            data.medicine_quantity.Add("Medicine Quantity 1");
            data.medicine_quantity.Add("Medicine Quantity 2");
            data.notes.Add("THis is First");
            data.notes.Add("This is Second");
            /*
                        data.symptom_name = sname;
                        data.symptom_description = sdesc;
                        data.medicine_name = mname;
                        data.medicine_quantity = mquant;
            */
        }


        public void saveDatabase()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Sampledb;Integrated Security=True;MultipleActiveResultSets=true"))
            {

                DateTime d = DateTime.Now;
                var t = DateTime.Now.TimeOfDay;
                connection.Open();
                string sql = "insert into VISITS(PERSON_ID,PERSON_NAME,DATE,TIME) values(@pid,@pname,@date,@time);";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlParameter[] param = new SqlParameter[4];

                param[0] = new SqlParameter("@pid", data.person_id);
                param[1] = new SqlParameter("@pname", data.name);
                param[2] = new SqlParameter("@date", d);
                param[3] = new SqlParameter("@time", t);

                cmd.Parameters.Add(param[0]);
                cmd.Parameters.Add(param[1]);
                cmd.Parameters.Add(param[2]);
                cmd.Parameters.Add(param[3]);

                int res = cmd.ExecuteNonQuery();
                connection.Close();
            }




            using (sampledbEntities edb = new sampledbEntities())
            {
                foreach (VISIT v in edb.VISITS)
                {
                    VISITID = v.VISIT_ID.ToString();
                }
            }


            using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Sampledb;Integrated Security=True;MultipleActiveResultSets=true"))
            {
                for (int i = 0; i < data.symptom_description.Count; i++)
                {
                    //db.setData("insert into symptoms(VISIT_ID,DESCRIPTION,SYMPTOM_NAME) values(" + VISITID + ",'" + data.symptom_description[i] + "','" + data.symptom_name[i] + "');");
                    string sql = "insert into symptoms(VISIT_ID,DESCRIPTION,SYMPTOM_NAME) values(@vid,@desc,@sname);";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlParameter[] param = new SqlParameter[3];

                    param[0] = new SqlParameter("@vid", VISITID);
                    param[1] = new SqlParameter("@desc", data.symptom_description[i]);
                    param[2] = new SqlParameter("@sname", data.symptom_name[i]);

                    cmd.Parameters.Add(param[0]);
                    cmd.Parameters.Add(param[1]);
                    cmd.Parameters.Add(param[2]);

                    int res = cmd.ExecuteNonQuery();
                    connection.Close();

                }
            }




            using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Sampledb;Integrated Security=True;MultipleActiveResultSets=true"))
            {

                for (int i = 0; i < data.medicine_name.Count; i++)
                {
                    //db.setData("insert into PRESCRIPTIONS(VISIT_ID,MEDICINE_ID,QUANTITY,MEDICINE_NAME) values(" + VISITID + "," + data.medicine_id[i] + "," + data.medicine_quantity[i] + ",'" + data.medicine_name[i] + "');");
                    string sql = "insert into PRESCRIPTIONS(VISIT_ID,MEDICINE_ID,QUANTITY,MEDICINE_NAME) values(@vid,@id,@quantity,@name);";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlParameter[] param = new SqlParameter[4];

                    param[0] = new SqlParameter("@vid", VISITID);
                    param[1] = new SqlParameter("@id", data.medicine_id[i]);
                    param[2] = new SqlParameter("@quantity", data.medicine_quantity[i]);
                    param[3] = new SqlParameter("@name", data.medicine_name[i]);

                    cmd.Parameters.Add(param[0]);
                    cmd.Parameters.Add(param[1]);
                    cmd.Parameters.Add(param[2]);
                    cmd.Parameters.Add(param[3]);

                    int res = cmd.ExecuteNonQuery();
                    connection.Close();
                }

            }

            using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Sampledb;Integrated Security=True;MultipleActiveResultSets=true"))
            {

                for (int i = 0; i < data.notes.Count; i++)
                {
                    // db.setData("insert into NOTES(VISIT_ID,DESCRIPTION) values(" + VISITID + ",'" + data.notes[i] + "');");
                    string sql = "insert into NOTES(VISIT_ID,DESCRIPTION) values(@vid,@desc);";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlParameter[] param = new SqlParameter[4];

                    param[0] = new SqlParameter("@vid", VISITID);
                    param[1] = new SqlParameter("@desc", data.notes[i]);
                    cmd.Parameters.Add(param[0]);
                    cmd.Parameters.Add(param[1]);

                    int res = cmd.ExecuteNonQuery();
                    connection.Close();
                }
                //db.setData("insert into PRESCRIPTIONS(VISIT_ID,MEDICINE_ID,QUANTITY,MEDICINE_NAME) values(" + VISITID + "," + data.medicine_id[i] + "," + data.medicine_quantity[i] + ",'" + data.medicine_name[i] + "');");

            }






            /*
            DateTime d = DateTime.Now;
            var t = DateTime.Now.TimeOfDay;
            MessageBox.Show(d.ToString());
            MessageBox.Show(t.ToString());
            db.setData("insert into VISITS(PERSON_ID,PERSON_NAME,DATE,TIME) values("+data.person_id+",'"+data.name+"','"+d+"','"+t+"');");
            using (sampledbEntities edb = new sampledbEntities())
            {
                foreach (VISIT v in edb.VISITS)
                {
                    VISITID = v.VISIT_ID.ToString();
                }
            }

            for (int i = 0; i < data.symptom_description.Count; i++)
            {
                db.setData("insert into symptoms(VISIT_ID,DESCRIPTION,SYMPTOM_NAME) values(" + VISITID + ",'" + data.symptom_description[i] + "','" + data.symptom_name[i] +"');");
            }

            for (int i = 0; i < data.medicine_name.Count; i++)
            {
                db.setData("insert into PRESCRIPTIONS(VISIT_ID,MEDICINE_ID,QUANTITY,MEDICINE_NAME) values(" + VISITID + "," + data.medicine_id[i] + "," + data.medicine_quantity[i] + ",'" + data.medicine_name[i] +"');");
            }

            for (int i = 0; i < data.notes.Count; i++)
            {
                db.setData("insert into NOTES(VISIT_ID,DESCRIPTION) values(" + VISITID + ",'" + data.notes[i] +"');");
            }
            */

            /*          
                        string sql = "select count(UserID) from user_login where UserID=@UserID and pwd=@pwd";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        SqlParameter[] param = new SqlParameter[2];
                        param[0] = new SqlParameter("@UserID", txtUSerID.Text);
                        param[1] = new SqlParameter("@pwd", txtPwd.Text);
                        cmd.Parameters.Add(param[0]);
                        cmd.Parameters.Add(param[1]);
            */

            string message = "Your Data is Saved Succesfully!";
            string title = "SUCCESS!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);

            message = data.name + "'s Visit ID is : " + VISITID;
            title = "SUCCESS!";
            buttons = MessageBoxButtons.OK;
            result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);

            data.Destroy();
            this.Close();
            th = new Thread(OpenMainFrame);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();


        }





        // SHOW LABELS
        public void show()
        {
            lbl_village.Show();
            lbl_hno.Show();
            lbl_name.Show();
            lbl_age.Show();
            lbl_gender.Show();
            lbl_contact.Show();
            lbl_pid.Show();
        }


        // CONSTRUCTOR
        public Report(Data d)
        {
            data = d;
            InitializeComponent();
        }





        // LOADING REPORT FORM
        private void Report_Load(object sender, EventArgs e)
        {

            lbl_village.Text = data.village_name;
            lbl_hno.Text = data.house_no;
            lbl_name.Text = data.name;
            lbl_age.Text = data.age;
            lbl_gender.Text = data.gender;
            lbl_contact.Text = data.contact;
            lbl_pid.Text = data.person_id;
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();


            for (int i = 0; i < data.symptom_description.Count; i++)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = data.symptom_name[i];
                dataGridView1.Rows[n].Cells[1].Value = data.symptom_description[i];
            }

            for (int i = 0; i < data.medicine_name.Count; i++)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells["med_id"].Value = data.medicine_id[i];
                dataGridView2.Rows[n].Cells["med_name"].Value = data.medicine_name[i];
                dataGridView2.Rows[n].Cells["med_quant"].Value = data.medicine_quantity[i];
            }

            for (int i = 0; i < data.notes.Count; i++)
            {
                int n = dataGridView3.Rows.Add();
                dataGridView3.Rows[n].Cells[0].Value = n + 1;
                dataGridView3.Rows[n].Cells[1].Value = data.notes[i];
            }

            show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }




        // BUTTON SAVE DATA!
        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Are You Sure Want to Save Data?";
            string title = "Are You Sure?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            if (result == DialogResult.Yes)
            {
                saveDatabase();
            }


        }




        // BUTTON BACK!
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNotes);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }


        // OPEN SYMPTOMS!
        public void OpenNotes()
        {
            Application.Run(new Notes(data));
        }




        // BUTTON CANCLE!
        private void button3_Click(object sender, EventArgs e)
        {
            string message = "Do You Want To Close This Application?\n" +
                             "your all data will be lose after you close the Application!";
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


        // OPEN MAIN FRAME!
        public void OpenMainFrame()
        {
            Application.Run(new MainFrame());
        }





        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["sname"].Value);
                string cellValue1 = Convert.ToString(selectedRow.Cells["sdesc"].Value);
                MessageBox.Show("Symptom Name = " + cellValue +
                                "\n\nSymptom Description :- \n" + cellValue1);
            }
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                string cellval3 = Convert.ToString(selectedRow.Cells["med_id"].Value);
                string cellValue = Convert.ToString(selectedRow.Cells["med_name"].Value);
                string cellValue1 = Convert.ToString(selectedRow.Cells["med_quant"].Value);
                MessageBox.Show("Medicine ID = " + cellval3 +
                                "\n\nMedicine Name = " + cellValue +
                                "\n\nMedicine Quantity = " + cellValue1);
            }
        }

        private void dataGridView3_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView3.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView3.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView3.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["srno"].Value);
                string cellValue1 = Convert.ToString(selectedRow.Cells["note"].Value);
                MessageBox.Show("Sr. No. = " + cellValue +
                                "\n\nNote = " + cellValue1);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        /*  private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
          {
              int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
              DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
              string cellValue = Convert.ToString(selectedRow.Cells["Symptom Name"].Value);
              string cellValue1 = Convert.ToString(selectedRow.Cells["Symptom Description"].Value);
              MessageBox.Show("Symptom Name = " + cellValue +
                              "\n\nSymptom Description :- \n" + cellValue1);
          }*/

    }
}
