using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Cell = iText.Layout.Element.Cell;
using Table = iText.Layout.Element.Table;

namespace OPD_Section.Forms
{
    public partial class ViewDetails : Form
    {



        public void errmsgbox(string message, string title)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
        }

        // Data Members
        public DBClasses db = new DBClasses();
        public SqlDataReader res;
        /*public string visit_id;*/
        public string LoadData = "";
        public string villagename = "";
        public string villageid = "";
        public string visitid = "";
        public string personid = "";
        public string personname = "";
        public string houseid = "";
        public string age = "";
        public string contact = "";
        public string gender = "";
        public string visittime = "";
        public string visitdate = "";

        List<string> symptom_name = new List<string>();
        List<string> symptom_description = new List<string>();
        List<string> medicine_id = new List<string>();
        List<string> medicine_name = new List<string>();
        List<string> medicine_quantity = new List<string>();
        List<string> notes = new List<string>();

        public ViewDetails(string vid, string data)
        {
            InitializeComponent();
            visitid = vid;
            LoadData = data;
        }



        public void LoadVisitDetails()
        {

            db.CreateConnection();

            // Loading Data From Visits Table
            string sql = "Select * from Visits Where VISIT_ID = '" + visitid + "';";
            res = db.getData(sql);
            if (res.HasRows)
            {
                while (res.Read())
                {
                    personid = res["PERSON_ID"].ToString();
                    personname = res["PERSON_NAME"].ToString();

                    string datetime = res["DATE"].ToString();
                    DateTime dt = DateTime.Parse(datetime);

                    //visitdate = res["DATE"].ToString();
                    //visittime = res["TIME"].ToString(); 
                    visitdate = dt.Date.ToString("dd/MM/yyyy");
                    visittime = dt.ToString("hh:mm:ss tt");
                }
            }
            else
            {
                errmsgbox("Visit Details Not Found!", "ERROR");
            }


            // Loading Data From Persons Table
            sql = "Select * from PERSONS where PERSON_ID = '" + personid + "';";
            res = db.getData(sql);
            if (res.HasRows)
            {
                while (res.Read())
                {
                    houseid = res["HOUSE_ID"].ToString();
                    personname = res["NAME"].ToString();
                    age = res["AGE"].ToString();
                    gender = res["GENDER"].ToString();
                    contact = res["PHONE_NO"].ToString();
                }
            }
            else
            {
                errmsgbox("Person Details Not Found!", "ERROR");
            }





            // getting village id
            sql = "Select * from HOUSES where HOUSE_ID = '" + houseid + "';";
            res = db.getData(sql);
            if (res.HasRows)
            {
                while (res.Read())
                {
                    villageid = res["VILLAGE_ID"].ToString();
                }
            }
            else
            {
                errmsgbox("House Details Not Found!", "ERROR");
            }



            // Getting village name
            sql = "Select * from Villages where VILLAGE_ID = '" + villageid + "';";
            res = db.getData(sql);
            if (res.HasRows)
            {
                while (res.Read())
                {
                    villagename = res["VILLAGE_NAME"].ToString();
                }
            }
            else
            {
                errmsgbox("Village Details Not Found!", "ERROR");
            }


            // Loading data from symptoms Table!

            sql = "Select * from Symptoms where VISIT_ID = '" + visitid + "';";
            res = db.getData(sql);
            if (res.HasRows)
            {
                while (res.Read())
                {
                    symptom_name.Add(res["SYMPTOM_NAME"].ToString());
                    symptom_description.Add(res["DESCRIPTION"].ToString());
                }
            }
            else
            {
                errmsgbox("Symptom Details Not Found!", "ERROR");
            }

            // Loading Data from Prescription Table!

            sql = "Select * from PRESCRIPTIONS where VISIT_ID = '" + visitid + "';";
            res = db.getData(sql);
            if (res.HasRows)
            {
                while (res.Read())
                {
                    medicine_id.Add(res["MEDICINE_ID"].ToString());
                    medicine_name.Add(res["MEDICINE_NAME"].ToString());
                    medicine_quantity.Add(res["QUANTITY"].ToString());
                }
            }
            else
            {
                errmsgbox("Prescription Details Not Found!", "ERROR");
            }


            // Loading Notes Data!
            sql = "Select * from NOTES where VISIT_ID = '" + visitid + "';";
            res = db.getData(sql);
            if (res.HasRows)
            {
                while (res.Read())
                {
                    notes.Add(res["DESCRIPTION"].ToString());
                }
            }
            else
            {
                errmsgbox("Notes Details Not Found!", "ERROR");
            }

            db.CloseConnection();

        }



        public void LoadArchieveDetails()
        {
            db.CreateConnection();

            // Loading Data From Visits Table
            string sql = "Select * from Visits_ARCHIVE Where VISIT_ID = '" + visitid + "';";
            res = db.getData(sql);
            if (res.HasRows)
            {
                while (res.Read())
                {
                    personid = res["PERSON_ID"].ToString();
                    personname = res["PERSON_NAME"].ToString();
                    string datetime = res["DATE"].ToString();
                    DateTime dt = DateTime.Parse(datetime);

                    //visitdate = res["DATE"].ToString();
                    //visittime = res["TIME"].ToString(); 
                    visitdate = dt.Date.ToString("dd/MM/yyyy");
                    visittime = dt.ToString("hh:mm:ss tt");
                }
            }
            else
            {
                errmsgbox("Visit Details Not Found!", "ERROR");
            }


            // Loading Data From Persons Table
            sql = "Select * from PERSONS where PERSON_ID = '" + personid + "';";
            res = db.getData(sql);
            if (res.HasRows)
            {
                while (res.Read())
                {
                    houseid = res["HOUSE_ID"].ToString();
                    personname = res["NAME"].ToString();
                    age = res["AGE"].ToString();
                    gender = res["GENDER"].ToString();
                    contact = res["PHONE_NO"].ToString();
                }
            }
            else
            {
                errmsgbox("Person Details Not Found!", "ERROR");
            }





            // getting village id
            sql = "Select * from HOUSES where HOUSE_ID = '" + houseid + "';";
            res = db.getData(sql);
            if (res.HasRows)
            {
                while (res.Read())
                {
                    villageid = res["VILLAGE_ID"].ToString();
                }
            }
            else
            {
                errmsgbox("Village Details Not Found!", "ERROR");
            }



            // Getting village name
            sql = "Select * from Villages where VILLAGE_ID = '" + villageid + "';";
            res = db.getData(sql);
            if (res.HasRows)
            {
                while (res.Read())
                {
                    villagename = res["VILLAGE_NAME"].ToString();
                }
            }
            else
            {
                MessageBox.Show("No Details Found!");
            }


            // Loading data from symptoms Table!

            sql = "Select * from Symptoms_ARCHIVE where VISIT_ID = '" + visitid + "';";
            res = db.getData(sql);
            if (res.HasRows)
            {
                while (res.Read())
                {
                    symptom_name.Add(res["SYMPTOM_NAME"].ToString());
                    symptom_description.Add(res["DESCRIPTION"].ToString());
                }
            }
            else
            {
                errmsgbox("Symptom Details Not Found!", "ERROR");
            }

            // Loading Data from Prescription Table!

            sql = "Select * from PRESCRIPTIONS_ARCHIVE where VISIT_ID = '" + visitid + "';";
            res = db.getData(sql);
            if (res.HasRows)
            {
                while (res.Read())
                {
                    medicine_id.Add(res["MEDICINE_ID"].ToString());
                    medicine_name.Add(res["MEDICINE_NAME"].ToString());
                    medicine_quantity.Add(res["QUANTITY"].ToString());
                }
            }
            else
            {
                errmsgbox("Prescription Details Not Found!", "ERROR");
            }


            // Loading Notes Data!
            sql = "Select * from NOTES where VISIT_ID = '" + visitid + "';";
            res = db.getData(sql);
            if (res.HasRows)
            {
                while (res.Read())
                {
                    notes.Add(res["DESCRIPTION"].ToString());
                }
            }
            else
            {
                errmsgbox("Notes Details Not Found!", "ERROR");
            }

            db.CloseConnection();

        }





        public void setDetails()
        {
            lbl_vid.Text = visitid;
            lbl_name.Text = personname;
            lbl_pid.Text = personid;
            lbl_village.Text = villagename;
            lbl_age.Text = age;
            lbl_hno.Text = houseid;
            lbl_contact.Text = contact;
            lbl_gender.Text = gender;
            lbl_vdate.Text = visitdate;
            lbl_vtime.Text = visittime;



            for (int i = 0; i < symptom_description.Count; i++)
            {
                int n = dataGridView_sym.Rows.Add();
                dataGridView_sym.Rows[n].Cells["sname"].Value = symptom_name[i];
                dataGridView_sym.Rows[n].Cells["sdesc"].Value = symptom_description[i];
            }

            for (int i = 0; i < medicine_name.Count; i++)
            {
                int n = dataGridView_pre.Rows.Add();
                dataGridView_pre.Rows[n].Cells["med_id"].Value = medicine_id[i];
                dataGridView_pre.Rows[n].Cells["med_name"].Value = medicine_name[i];
                dataGridView_pre.Rows[n].Cells["med_quant"].Value = medicine_quantity[i];
            }

            for (int i = 0; i < notes.Count; i++)
            {
                int n = dataGridView_note.Rows.Add();
                dataGridView_note.Rows[n].Cells[0].Value = n + 1;
                dataGridView_note.Rows[n].Cells[1].Value = notes[i];
            }


        }







        private void ViewDetails_Load(object sender, EventArgs e)
        {

            if (LoadData == "ARCHIVE")
            {
                LoadArchieveDetails();
            }
            else
            {
                LoadVisitDetails();
            }


            setDetails();
        }





        private void dataGridView_pre_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView_pre.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_pre.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_pre.Rows[selectedrowindex];
                string cellval3 = Convert.ToString(selectedRow.Cells["med_id"].Value);
                string cellValue = Convert.ToString(selectedRow.Cells["med_name"].Value);
                string cellValue1 = Convert.ToString(selectedRow.Cells["med_quant"].Value);
                MessageBox.Show("Medicine ID = " + cellval3 +
                                "\n\nMedicine Name = " + cellValue +
                                "\n\nMedicine Quantity = " + cellValue1);
            }
        }

        private void dataGridView_sym_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView_sym.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_sym.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_sym.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["sname"].Value);
                string cellValue1 = Convert.ToString(selectedRow.Cells["sdesc"].Value);
                MessageBox.Show("Symptom Name = " + cellValue +
                                "\n\nSymptom Description = " + cellValue1);
            }
        }

        private void dataGridView_note_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView_note.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_note.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_note.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["srno"].Value);
                string cellValue1 = Convert.ToString(selectedRow.Cells["note"].Value);
                MessageBox.Show("Sr. No. = " + cellValue +
                                "\n\nNote = " + cellValue1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Print
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Data Files (*.pdf)|*.pdf";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                PdfWriter writer = new PdfWriter(sfd.FileName);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                //PdfFont TimesnewRoman = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);
                /*Paragraph header = new Paragraph("VISIT REPORT")
                   .SetTextAlignment(TextAlignment.CENTER)
                   .SetFontSize(30)
                   .SetBold()
                   .SetFontColor(ColorConstants.BLACK);
                //.SetFont(TimesnewRoman);

                Paragraph subheader = new Paragraph("E-HealthCare Portal")
                   .SetTextAlignment(TextAlignment.CENTER)
                   .SetFontSize(10)
                   .SetFontColor(ColorConstants.BLACK);
                //.SetFont(TimesnewRoman);*/

                LineSeparator ls = new LineSeparator(new SolidLine());
                /*
                                string line1 = "Patient Name\t : " + "\t" + personname;
                                string line2 = "Petient ID\t\t  : " + "\t" + personid;
                                string line3 = "Village\t\t\t  : " + "\t" + villagename;
                                string line4 = "House No.\t\t : " + "\t" + houseid;
                                string line5 = "Age\t\t\t\t   : " + "\t" + age;
                                string line6 = "Gender\t\t\t  : " + "\t" + gender;
                                string line7 = "Phone No.\t\t : " + "\t" + contact;
                                string line8 = "Visit Time\t\t : " + "\t" + visittime;
                                string line9 = "Visit Date\t\t  : " + "\t" + visitdate;

                */

                string line1 = "Patient Name\t : " + "\t" + personname;
                string line2 = "Petient ID\t\t  : " + "\t" + personid + "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t  Village\t\t\t  : " + "\t" + villagename;
                string line3 = "House No.\t\t : " + "\t" + houseid + "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t  Age\t\t\t\t   : " + "\t" + age;
                string line4 = "Gender\t\t\t  : " + "\t" + gender + "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t Phone No.\t\t : " + "\t" + contact;
                string line5 = "Visit Time\t\t : " + "\t" + visittime + "\t\t\t\t\t\t\t\t\t\t\t\t\t\tVisit Date\t\t  : " + "\t" + visitdate;

                int TextSize = 10;
                int lm = 50;
                int tm = 10;
                var align = TextAlignment.JUSTIFIED;

                Paragraph l1 = new Paragraph(line1)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(TextSize)
                            .SetFontColor(ColorConstants.BLACK)
                            //.SetFont(TimesnewRoman)
                            .SetMarginTop(tm);
                Paragraph l2 = new Paragraph(line2)
                            .SetTextAlignment(align)
                            .SetFontSize(TextSize)
                            .SetFontColor(ColorConstants.BLACK)
                            //.SetFont(TimesnewRoman)
                            .SetMarginLeft(lm)
                            .SetMarginTop(tm);
                Paragraph l3 = new Paragraph(line3)
                            .SetTextAlignment(align)
                            .SetFontSize(TextSize)
                            .SetFontColor(ColorConstants.BLACK)
                            //.SetFont(TimesnewRoman)
                            .SetMarginLeft(lm)
                            .SetMarginTop(tm);
                Paragraph l4 = new Paragraph(line4)
                            .SetTextAlignment(align)
                            .SetFontSize(TextSize)
                            .SetFontColor(ColorConstants.BLACK)
                            //.SetFont(TimesnewRoman)
                            .SetMarginLeft(lm)
                            .SetMarginTop(tm);
                Paragraph l5 = new Paragraph(line5)
                            .SetTextAlignment(align)
                            .SetFontSize(TextSize)
                            .SetFontColor(ColorConstants.BLACK)
                            //.SetFont(TimesnewRoman)
                            .SetMarginLeft(lm)
                            .SetMarginTop(tm);
                /*   Paragraph l6 = new Paragraph(line6)
                               .SetTextAlignment(align)
                               .SetFontSize(TextSize)
                               .SetFontColor(ColorConstants.BLACK)
                               .SetFont(TimesnewRoman)
                               .SetMarginLeft(lm)
                               .SetMarginTop(tm);
                   Paragraph l7 = new Paragraph(line7)
                               .SetTextAlignment(align)
                               .SetFontSize(TextSize)
                               .SetFontColor(ColorConstants.BLACK)
                               .SetFont(TimesnewRoman)
                               .SetMarginLeft(lm)
                               .SetMarginTop(tm);
                   Paragraph l8 = new Paragraph(line8)
                               .SetTextAlignment(align)
                               .SetFontSize(TextSize)
                               .SetFontColor(ColorConstants.BLACK)
                               .SetFont(TimesnewRoman)
                               .SetMarginLeft(lm)
                               .SetMarginTop(tm);
                   Paragraph l9 = new Paragraph(line9)
                               .SetTextAlignment(align)
                               .SetFontSize(TextSize)
                               .SetFontColor(ColorConstants.BLACK)
                               .SetFont(TimesnewRoman)
                               .SetMarginLeft(lm)
                               .SetMarginTop(tm);
   */


                Paragraph symhead = new Paragraph("Symptoms")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(15)
                            .SetFontColor(ColorConstants.BLACK)
                            //.SetFont(TimesnewRoman)
                            .SetMargin(10);


                // Symptoms TABLE:-
                Table Symptom_table = new Table(2, false);
                Symptom_table.SetWidth(525);

                Cell symcell1 = new Cell(1, 1)
                   .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph("Symptom Name"))
                   .SetWidth(100)
                   //.SetFont(TimesnewRoman)
                   .SetFontSize(10);
                Cell symcell2 = new Cell(1, 1)
                   .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph("Symptom Description"))
                   //.SetFont(TimesnewRoman)
                   .SetFontSize(10);

                Symptom_table.AddCell(symcell1);
                Symptom_table.AddCell(symcell2);

                for (int i = 0; i < symptom_description.Count; i++)
                {
                    Cell cell1 = new Cell(1, 1)
                       .SetTextAlignment(TextAlignment.CENTER)
                       .Add(new Paragraph(symptom_name[i]))
                       //.SetFont(TimesnewRoman)
                       .SetFontSize(10);
                    Cell cell2 = new Cell(1, 1)
                       .SetTextAlignment(TextAlignment.CENTER)
                       .Add(new Paragraph(symptom_description[i]))
                       //.SetFont(TimesnewRoman)
                       .SetFontSize(10);
                    Symptom_table.AddCell(cell1);
                    Symptom_table.AddCell(cell2);

                }






                Paragraph prehead = new Paragraph("Prescription")
                             .SetTextAlignment(TextAlignment.CENTER)
                             .SetFontSize(15)
                             .SetFontColor(ColorConstants.BLACK)
                             //.SetFont(TimesnewRoman)
                             .SetMargin(10);


                // Prescription TABLE:-
                Table Prescription_table = new Table(2, false);
                Prescription_table.SetWidth(525);

                Cell precell1 = new Cell(1, 1)
                   .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph("Medicine Name"))
                   .SetWidth(100)
                   //.SetFont(TimesnewRoman)
                   .SetFontSize(10);
                Cell precell2 = new Cell(1, 1)
                   .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph("Medicine Quantity"))
                   //.SetFont(TimesnewRoman)
                   .SetFontSize(10);

                Prescription_table.AddCell(precell1);
                Prescription_table.AddCell(precell2);

                for (int i = 0; i < medicine_name.Count; i++)
                {
                    Cell cell1 = new Cell(1, 1)
                       .SetTextAlignment(TextAlignment.CENTER)
                       .Add(new Paragraph(medicine_name[i]))
                       ///  .SetFont(TimesnewRoman)
                       .SetFontSize(10);
                    Cell cell2 = new Cell(1, 1)
                       .SetTextAlignment(TextAlignment.CENTER)
                       .Add(new Paragraph(medicine_quantity[i]))
                       // .SetFont(TimesnewRoman)
                       .SetFontSize(10);
                    Prescription_table.AddCell(cell1);
                    Prescription_table.AddCell(cell2);

                }




                Paragraph notehead = new Paragraph("Notes")
                             .SetTextAlignment(TextAlignment.CENTER)
                             .SetFontSize(15)
                             .SetFontColor(ColorConstants.BLACK)
                             //     .SetFont(TimesnewRoman)
                             .SetMargin(10);


                // Notes TABLE:-
                Table Note_table = new Table(2, false);
                Note_table.SetWidth(525);

                Cell notecell1 = new Cell(1, 1)
                   .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph("Sr.No."))
                   .SetWidth(100)
                   //.SetFont(TimesnewRoman)
                   .SetFontSize(10);
                Cell notecell2 = new Cell(1, 1)
                   .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph("Note Description"))
                   //.SetFont(TimesnewRoman)
                   .SetFontSize(10);

                Note_table.AddCell(notecell1);
                Note_table.AddCell(notecell2);

                for (int i = 0; i < notes.Count; i++)
                {
                    Cell cell1 = new Cell(1, 1)
                       .SetTextAlignment(TextAlignment.CENTER)
                       .Add(new Paragraph((i + 1).ToString()))
                    //   .SetFont(TimesnewRoman)
                       .SetFontSize(10);
                    //  .SetFont(TimesnewRoman);
                    Cell cell2 = new Cell(1, 1)
                       .SetTextAlignment(TextAlignment.CENTER)
                       .Add(new Paragraph(notes[i]))
                       //  .SetFont(TimesnewRoman)
                       .SetFontSize(10);
                    Note_table.AddCell(cell1);
                    Note_table.AddCell(cell2);

                }


                document.Add(ls);
                document.Add(l1);
                document.Add(l2);
                document.Add(l3);
                document.Add(l4);
                document.Add(l5);
                /* document.Add(l6);
                 document.Add(l7);
                 document.Add(l8);
                 document.Add(l9);*/
                document.Add(symhead);
                document.Add(Symptom_table);
                document.Add(prehead);
                document.Add(Prescription_table);
                document.Add(notehead);
                document.Add(Note_table);
                document.Close();

                string message = "Your PDF is Saved Succesfully!";
                string title = "SUCCESS!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);



            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

    }
}

