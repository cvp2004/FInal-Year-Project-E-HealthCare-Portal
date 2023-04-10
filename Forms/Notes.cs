using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPD_Section.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace OPD_Section
{
    public partial class Notes : Form
    {
        // DATA MEMBERS!
        public Data data = new Data();
        public Thread th;





        // CONSTRUCTOR
        public Notes(Data d)
        {
            InitializeComponent();
            data = d;
        }

        


        // LOADING NOTES FORM
        private void Notes_Load(object sender, EventArgs e)
        {
            if(data.notes.Count != 0)
            {
                try
                {
                    for (int i = 0; i < data.notes.Count; i++)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = n + 1;
                        dataGridView1.Rows[n].Cells[1].Value = data.notes[i];
                    }
                    data.notes.Clear();
                }
                catch(Exception E)
                {
                    E.ToString();
                    MessageBox.Show("Some Unknown Error Occured!");
                }
            }
            //MessageBox.Show(data.medicine_name[0]);
        }




        // Open Report Form
        public void OpenReport()
        {
            Application.Run(new Report(data));
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


       

        private void BtnSymptomNext_Click(object sender, EventArgs e)
        {

        }

        private void BtnSymptomBack_Click(object sender, EventArgs e)
        {

        }

        private void BtnSymptomCancle_Click(object sender, EventArgs e)
        {
        }





        // ADD BUTTON!
        private void BtnSymptomAdd_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text != "")
            {
                label4.Hide();
            }
   

            if (richTextBox1.Text == "")
            {
                label4.Show();
            }
            else
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = n + 1;
                dataGridView1.Rows[n].Cells[1].Value = richTextBox1.Text;
                richTextBox1.Text = "";
            }

            
        }



        // REMOVE BUTTON!
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




        // NEXT BUTTON!
        private void BtnSymptomNext_Click_1(object sender, EventArgs e)
        {

            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {    
                data.notes.Add(dataGridView1.Rows[rows].Cells[1].Value.ToString().ToUpper());
            }

           // data.notes = notes;

            
                this.Close();
                th = new Thread(OpenReport);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            

        }


        
        // CANCLE BUTTON!
        private void BtnSymptomCancle_Click_1(object sender, EventArgs e)
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





        // BACK BUTTON!
        private void BtnSymptomBack_Click_1(object sender, EventArgs e)
        {
            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {
                data.notes.Add(dataGridView1.Rows[rows].Cells[1].Value.ToString().ToUpper());
            }

            this.Close();
            th = new Thread(OpenPrescription);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }


        // OPEN SYMPTOMS!
        public void OpenPrescription()
        {
            Application.Run(new PrescriptionForm(data));
        }
    }
}
