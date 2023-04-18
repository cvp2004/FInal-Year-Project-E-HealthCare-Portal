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
using System.Reflection.Emit;

namespace OPD_Section
{
    public partial class PrescriptionForm : Form
    {


        // DATA MEMBERS!
        public Data data = new Data();
        public Thread th;




        // CONSTRUCTOR!
        public PrescriptionForm(Data d)
        {
            InitializeComponent();
            data = d;
        }




        // LOADING PRESCRIPTION FORM
        private void PrescriptionForm_Load(object sender, EventArgs e)
        {

            using (var presc = new sampledbEntities())
            {
                foreach(var med in presc.MEDICINES)
                {
                    textBox1.Items.Add(med.MEDICINE_NAME);
                }
            }

                if (data.medicine_name.Count != 0)
                {
                    try
                    {
                        for (int i = 0; i < data.medicine_name.Count; i++)
                        {
                            int n = dataGridView1.Rows.Add();
                            dataGridView1.Rows[n].Cells["med_id"].Value = data.medicine_id[i];
                            dataGridView1.Rows[n].Cells["med_name"].Value = data.medicine_name[i];
                            dataGridView1.Rows[n].Cells["med_quant"].Value = data.medicine_quantity[i];
                        }

                        data.medicine_name.Clear();
                        data.medicine_quantity.Clear();
                    }
                    catch (Exception E)
                    {
                        E.ToString();
                        MessageBox.Show("Some Unknown Error Occured!");
                    }
                }


            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 16, FontStyle.Bold);
        }


/*
        private void BtnSymptomNext_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNew);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }*/

      /*  public void OpenNew()
        {
            Application.Run(new Notes(data));
        }*/



        // ADD BUTTON!
        private void BtnSymptomAdd_Click(object sender, EventArgs e)
        {
            string med_id = "";

            if (textBox1.Text != "")
            {
                label4.Hide();
            }
            if (numericUpDown1.Text != "")
            {
                label5.Hide();
            }

            if (textBox1.Text == "")
            {
                label4.Show();
            }
            else if (numericUpDown1.Text == "")
            {
                label5.Show();
            }
            else
            {
                
                using (var presc = new sampledbEntities())
                {
                    foreach (var med in presc.MEDICINES)
                    {
                        if (textBox1.Text == med.MEDICINE_NAME)
                        {
                            med_id = med.MEDICINE_ID.ToString();
                        }
                    }
                }
                if(med_id != "")
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells["med_id"].Value = med_id;
                    dataGridView1.Rows[n].Cells["med_name"].Value = textBox1.Text;
                    dataGridView1.Rows[n].Cells["med_quant"].Value = numericUpDown1.Text;
                }
                else
                {
                    string message = "Medicine Not Found!";
                        string title = "Data Not Found!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                }

                textBox1.Text = "";
                numericUpDown1.Text = "";
            }
        }



        //REMOVE BUTTON!
        private void BtnSymptomRemove_Click(object sender, EventArgs e)
        {

            if (dataGridView1.RowCount > 0)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("No Data is Present!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        public void OpenNotes()
        {
            Application.Run(new Notes(data));
        }




        // NEXT BUTTON
        private void BtnSymptomNext_Click_1(object sender, EventArgs e)
        {


            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {

                for (int col = 0; col < dataGridView1.Rows[rows].Cells.Count; col++)
                {
                    if (col == 0)
                    {   
                        data.medicine_id.Add(dataGridView1.Rows[rows].Cells[col].Value.ToString());
                    }
                    else if(col == 1)
                    {
                        data.medicine_name.Add(dataGridView1.Rows[rows].Cells[col].Value.ToString().ToUpper());
                    }
                    else
                    {
                        data.medicine_quantity.Add(dataGridView1.Rows[rows].Cells[col].Value.ToString().ToUpper());
                    }

                }
            }

           /* data.medicine_name = mname;
            data.medicine_quantity = mquant;
*/

                this.Close();
                th = new Thread(OpenNotes);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
           
           
        }





        // BACK BUTTON!
        private void BtnSymptomBack_Click(object sender, EventArgs e)
        {


            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {

                for (int col = 0; col < dataGridView1.Rows[rows].Cells.Count; col++)
                {
                    if (col == 0)
                    {
                        data.medicine_name.Add(dataGridView1.Rows[rows].Cells[col].Value.ToString().ToUpper());
                    }
                    else
                    {
                        data.medicine_quantity.Add(dataGridView1.Rows[rows].Cells[col].Value.ToString().ToUpper());
                    }

                }
            }

            this.Close();
            th = new Thread(OpenSymptoms);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }


        // OPEN SYMPTOMS!
        public void OpenSymptoms()
        {
            Application.Run(new Symptoms(data));
        }



        // CANCLE BUTTON!
        private void BtnSymptomCancle_Click(object sender, EventArgs e)
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
    }
}
