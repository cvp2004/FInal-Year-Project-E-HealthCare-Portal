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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OPD_Section.Forms;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace OPD_Section
{
    public partial class Symptoms : Form
    {

        //MessageBox.Show(dataGridView1.RowCount.ToString());




        // DATA MEMBERS
        public Data data = new Data();
        public Thread th;



        // CONSTRUCTOR
        public Symptoms(Data d)
        {
            data = d;
            InitializeComponent();
        }

  



        // LOADING SYMPTOM FORM
        private void Symptoms_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(data.name);
            // dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 16, FontStyle.Bold);
            // dataGridView1.RowsDefaultCellStyle.Font = new Font("Times New Roman",16,FontStyle.Bold);

            if (data.symptom_description.Count != 0)
            {
                try
                {
                    for (int i = 0; i < data.symptom_description.Count; i++)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = data.symptom_name[i];
                        dataGridView1.Rows[n].Cells[1].Value = data.symptom_description[i];
                    }
                    data.symptom_description.Clear();
                    data.symptom_name.Clear();
                }
                catch(Exception E)
                {
                    E.ToString();
                    MessageBox.Show("Some Unknown Error Occured!");
                }
            }


            
        }

     

   

        // ADD BUTTON!
        private void BtnSymptomAdd_Click_2(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label4.Hide();
            }
            if (richTextBox1.Text != "")
            {
                label5.Hide();
            }

            if (textBox1.Text == "")
            {
                label4.Show();
            }
            else if (richTextBox1.Text == "")
            {
                label5.Show();
            }
            else
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[n].Cells[1].Value = richTextBox1.Text;
                textBox1.Text = "";
                richTextBox1.Text = "";
            }
        }





        // REMOVE BUTTON!
        private void BtnSymptomRemove_Click_1(object sender, EventArgs e)
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




        // NEXT BUTTON!
        private void BtnSymptomNext_Click(object sender, EventArgs e)
        {

            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {

                for (int col = 0; col < dataGridView1.Rows[rows].Cells.Count; col++)
                {
                    if (col == 0)
                    {
                        //sname[rows] = dataGridView1.Rows[rows].Cells[col].Value.ToString().ToUpper();
                        data.symptom_name.Add(dataGridView1.Rows[rows].Cells[col].Value.ToString().ToUpper());
                    }
                    else
                    {
                        //sdesc[rows] = dataGridView1.Rows[rows].Cells[col].Value.ToString().ToUpper();
                        data.symptom_description.Add(dataGridView1.Rows[rows].Cells[col].Value.ToString().ToUpper());
                        
                    }
                    
                }
            }

                /*data.symptom_name= sname;
                data.symptom_description = sdesc;*/
                
                this.Close();
                th = new Thread(OpenPrescription);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();


        }
        


        // OPEN PRESCRIPTION
        public void OpenPrescription()
        {
            Application.Run(new PrescriptionForm(data));
        }




        // OPEN VISIT DETAILS
        public void OpenVisitDetails()
        {
            Application.Run(new VisitDetails(data));
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
                        //sname[rows] = dataGridView1.Rows[rows].Cells[col].Value.ToString().ToUpper();
                        data.symptom_name.Add(dataGridView1.Rows[rows].Cells[col].Value.ToString().ToUpper());
                    }
                    else
                    {
                        //sdesc[rows] = dataGridView1.Rows[rows].Cells[col].Value.ToString().ToUpper();
                        data.symptom_description.Add(dataGridView1.Rows[rows].Cells[col].Value.ToString().ToUpper());

                    }

                }
            }


            this.Close();
            th = new Thread(OpenVisitDetails);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }




        // Open Main Frame
        public void OpenMainFrame()
        {
            Application.Run(new MainFrame());
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

      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
