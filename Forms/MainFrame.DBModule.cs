using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OPD_Section
{
    public partial class MainFrame : Form
    {

        /*******************************************************************************************************************************************************************/

        // DataGridView Load Events

        private void LoadDefaultTblVillage()
        {

            TblVillage.Rows.Clear();

            using (var context = new sampledbEntities())
            {
                foreach (VILLAGE v in context.VILLAGES)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(TblVillage);
                    row.Cells[0].Value = v.VILLAGE_ID;
                    row.Cells[1].Value = v.VILLAGE_NAME;
                    row.Cells[2].Value = v.VILLAGE_CODE;
                    row.Cells[3].Value = v.NO_OF_HOUSES;
                    TblVillage.Rows.Add(row);
                }
            }

        }

        private void LoadDefaultTblHouse()
        {

            TblHouse.Rows.Clear();

            using (var context = new sampledbEntities())
            {
                foreach (House h in context.HOUSES)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(TblHouse);
                    row.Cells[0].Value = h.HOUSE_ID;
                    /*row.Cells[1].Value = h.VILLAGE_ID;*/

                    foreach (VILLAGE v in context.VILLAGES)
                    {
                        if (v.VILLAGE_ID == h.VILLAGE_ID)
                        {
                            row.Cells[1].Value = v.VILLAGE_NAME;
                            break;
                        }
                    }

                    row.Cells[2].Value = h.NO_OF_PEOPLE;
                    TblHouse.Rows.Add(row);
                }
            }
        }

        private void LoadDefaultTblPerson()
        {

            TblPerson.Rows.Clear();

            using (var context = new sampledbEntities())
            {
                foreach (PERSON p in context.PERSONS)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(TblPerson);

                    int vid = context.HOUSES.Find(p.HOUSE_ID).VILLAGE_ID;
                    string vname = context.VILLAGES.Find(vid).VILLAGE_NAME;

                    row.Cells[0].Value = p.PERSON_ID;
                    row.Cells[1].Value = p.HOUSE_ID;
                    row.Cells[2].Value = vname;
                    row.Cells[3].Value = p.NAME;
                    row.Cells[4].Value = p.AGE;
                    row.Cells[5].Value = p.GENDER;
                    row.Cells[6].Value = p.PHONE_NO;
                    TblPerson.Rows.Add(row);
                }
            }
        }

        private void LoadDefaultTblVillageLogs()
        {

            TblVillageLogs.Rows.Clear();

            using (var context = new sampledbEntities())
            {
                foreach (LOGS_VILLAGES v in context.LOGS_VILLAGES)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(TblVillageLogs);
                    row.Cells[0].Value = v.LOG_ID;
                    row.Cells[1].Value = v.OP_TYPE;
                    row.Cells[2].Value = v.VILLAGE_ID;
                    row.Cells[3].Value = v.VILLAGE_NAME;
                    row.Cells[4].Value = v.VILLAGE_CODE;
                    row.Cells[5].Value = v.NO_OF_HOUSES;
                    TblVillageLogs.Rows.Add(row);
                }
            }

        }
        private void LoadDefaultTblHouseLogs()
        {

            TblHouseLogs.Rows.Clear();

            using (var context = new sampledbEntities())
            {
                foreach (LOGS_HOUSES h in context.LOGS_HOUSES)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(TblHouseLogs);
                    row.Cells[0].Value = h.LOG_ID;
                    row.Cells[1].Value = h.OP_TYPE;
                    row.Cells[2].Value = h.HOUSE_ID;

                    foreach (LOGS_VILLAGES v in context.LOGS_VILLAGES)
                    {
                        if (v.VILLAGE_ID == h.VILLAGE_ID)
                        {
                            row.Cells[3].Value = v.VILLAGE_NAME;
                        }
                    }

                    row.Cells[4].Value = h.NO_OF_PEOPLE;
                    TblHouseLogs.Rows.Add(row);
                }
            }
        }
        private void LoadDefaultTblPersonLogs()
        {

            TblPersonLogs.Rows.Clear();

            using (var context = new sampledbEntities())
            {
                foreach (LOGS_PERSONS p in context.LOGS_PERSONS)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(TblPersonLogs);

                    int vid = -1;

                    foreach (var h in context.LOGS_HOUSES)
                    {
                        if (h.HOUSE_ID == p.HOUSE_ID)
                        {
                            vid = h.VILLAGE_ID;
                            break;
                        }
                    }

                    string vname = "";

                    foreach (var v in context.LOGS_VILLAGES)
                    {
                        if (v.VILLAGE_ID == vid)
                        {
                            vname = v.VILLAGE_NAME;
                            break;
                        }
                    }

                    row.Cells[0].Value = p.LOG_ID;
                    row.Cells[1].Value = p.OP_TYPE;
                    row.Cells[2].Value = p.PERSON_ID;
                    row.Cells[3].Value = p.HOUSE_ID;
                    row.Cells[4].Value = vname;
                    row.Cells[5].Value = p.NAME;
                    row.Cells[6].Value = p.AGE;
                    row.Cells[7].Value = p.GENDER;
                    row.Cells[8].Value = p.PHONE_NO;
                    TblPersonLogs.Rows.Add(row);
                }
            }
        }

        /**********************************************************************************************************/

        // Combobox Load Events

        private void LoadTxtHouseVillageName()
        {
            TxtHouseVillageName.DataSource = null;
            TxtHouseVillageName.Items.Clear();

            List<string> comboSource = new List<string>();

            using (var context = new sampledbEntities())
            {
                foreach (VILLAGE v in context.VILLAGES)
                {
                    comboSource.Add(v.VILLAGE_NAME);
                }
            }

            TxtHouseVillageName.DataSource = new BindingSource(comboSource, null);
        }

        private void LoadTxtPersonVillageName()
        {
            TxtPersonVillageName.Items.Clear();

            List<string> comboSource = new List<string>();

            using (var context = new sampledbEntities())
            {
                foreach (VILLAGE v in context.VILLAGES)
                {
                    comboSource.Add(v.VILLAGE_NAME);
                }
            }

            TxtPersonVillageName.DataSource = new BindingSource(comboSource, null);
        }

        /**********************************************************************************************************/

        // Tab Reset Events
        private void TabVillage_Reset()
        {
            TxtVillageId.Text = "";
            TxtVillageName.Text = "";
            TxtVillageCode.Text = "";
            TxtVillageNoOfHouses.Text = "";

            LoadDefaultTblVillage();
        }
        private void TabHouse_Reset()
        {

            LoadTxtHouseVillageName();

            TxtHouseId.Text = "";
            TxtHouseVillageName.SelectedIndex = -1;
            TxtHouseNoOfPeople.Text = "";

            LoadDefaultTblHouse();
        }
        private void TabPerson_Reset()
        {
            TxtPersonId.Text = "";
            TxtPersonVillageName.SelectedIndex = -1;
            TxtPersonHouseId.SelectedIndex = -1;
            TxtPersonName.Text = "";
            TxtPersonAge.Value = 0;
            TxtPersonGender.SelectedIndex = -1;
            TxtPersonPhoneNo.Text = "";

            LoadDefaultTblPerson();
        }
        private void TabVillageLogs_Reset()
        {
            TxtVillageLogsVillageId.Text = "";
            TxtVillageLogsVillageName.Text = "";
            TxtVillageLogsVillageCode.Text = "";
            TxtVillageLogsNoOfHouses.Text = "";

            LoadDefaultTblVillageLogs();
        }
        private void TabHouseLogs_Reset()
        {
            TxtHouseLogsHouseId.Text = "";
            TxtHouseLogsVillageName.Text = "";
            TxtHouseLogsNoOfPeople.Text = "";

            LoadDefaultTblHouseLogs();
        }
        private void TabPersonLogs_Reset()
        {
            TxtPersonLogsPersonId.Text = "";
            TxtPersonLogsVillageName.Text = "";
            TxtPersonLogsHouseId.Text = "";
            TxtPersonLogsName.Text = "";
            TxtPersonLogsAge.Text = "";
            TxtPersonLogsGender.Text = "";
            TxtPersonLogsPhoneNo.Text = "";

            LoadDefaultTblPersonLogs();
        }

        /**********************************************************************************************************/

        // Village Tab button Events
        private async void BtnVillageInsert_Click(object sender, EventArgs e)
        {

            MessageBox.Show(" Values for Village Id and No. of Houses is Ignored !!\n" +
                            "   They will be automatically Generated by Database   \n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var vname = TxtVillageName.Text.ToUpper().Trim();
            var vcode = TxtVillageCode.Text.ToUpper().Trim();

            DialogResult result = MessageBox.Show("Confirm the Following Details !!\n" +
                                                  "\n      Village Name = " + vname +
                                                  "\n      Village Code = " + vcode,
                                                  "",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (vname.All(Char.IsLetter) && vcode.All(Char.IsLetter))
                {
                    using (var context = new sampledbEntities())
                    {

                        var villageObj = new VILLAGE()
                        {
                            VILLAGE_NAME = vname,
                            VILLAGE_CODE = vcode

                        };

                        context.VILLAGES.Add(villageObj);
                        var res = await context.SaveChangesAsync();

                        if (res == 1)
                        {
                            MessageBox.Show("!! New Village Added Successfully !!\n" +
                                        "     Village Id = " + villageObj.VILLAGE_ID + "\n" +
                                        "     Village Name = " + villageObj.VILLAGE_NAME + "\n" +
                                        "     Village Code = " + villageObj.VILLAGE_CODE + "\n" +
                                        "     No. of House = " + villageObj.NO_OF_HOUSES + "\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (res == 0)
                        {
                            MessageBox.Show("\t!! Database Error !!\n" +
                                            "\t!! Village Insert Operation Failed !!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("        !! Please Input Valid Details !!\n" +
                                    "\n1. Village Name Must only contain Letters\n" +
                                    "\n2. Village Code Must only contain Letters", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                LoadDefaultTblVillage();
            }

        }
        private async void BtnVillageUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Value for Village Name will be updated for Selected Village Id in the Table !!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int row = TblVillage.SelectedRows[0].Index;

            int vid = Convert.ToInt32(TblVillage[0, row].Value);
            int noofhouses = Convert.ToInt32(TblVillage[3, row].Value);

            string vname = TxtVillageName.Text;
            string vcode = TxtVillageCode.Text;


            DialogResult result = MessageBox.Show("\t!! Confirm the Following Details !!\n" +
                                                  "\n\t     Village Id    = " + vid +
                                                  "\n\t     Village Name  = " + vname +
                                                  "\n\t     Village Code  = " + vcode +
                                                  "\n\t     No. of Houses = " + noofhouses,
                                                  "Confirmation Box",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (vname.All(Char.IsLetter) && vcode.All(Char.IsLetter))
                {
                    using (var context = new sampledbEntities())
                    {

                        VILLAGE v = context.VILLAGES.Find(vid);

                        v.VILLAGE_NAME = vname;
                        v.VILLAGE_CODE = vcode;

                        var res = await context.SaveChangesAsync();

                        if (res == 1)
                        {
                            MessageBox.Show("\t!! Village Record Updated Successfully !!\n\n" +
                                        "\t      Village Id = " + v.VILLAGE_ID + "\n" +
                                        "\t      Village Name = " + v.VILLAGE_NAME + "\n" +
                                        "\t      Village Code = " + v.VILLAGE_CODE + "\n" +
                                        "\t      No. of House = " + v.NO_OF_HOUSES + "\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("\t\t!! Database Error !!\n" +
                                            "\t!! Village Update Operation Failed !!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Console.WriteLine("res = " + res);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("\t\t!! Please Input Valid Details !!\n" +
                                    "\t1. Village Name Must only contain Letters\n" +
                                    "\t2. Village Code Must only contain Letters", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadDefaultTblVillage();
            }

        }
        private async void BtnVillageDelete_Click(object sender, EventArgs e)
        {
            int row = TblVillage.SelectedRows[0].Index;

            int vid = Convert.ToInt32(TblVillage[0, row].Value);
            string vname = Convert.ToString(TblVillage[1, row].Value);
            string vcode = Convert.ToString(TblVillage[2, row].Value);
            int noofhouses = Convert.ToInt32(TblVillage[3, row].Value);

            DialogResult result = MessageBox.Show("!! Do You want to Delete the Following Record !!\n" +
                                                  "\n\tVillage Id    = " + vid +
                                                  "\n\tVillage Name  = " + vname +
                                                  "\n\tVillage Code  = " + vcode +
                                                  "\n\tNo. of Houses = " + noofhouses
                                                  , "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                if (noofhouses != 0)
                {
                    MessageBox.Show("\t\t!!Cannot Delete this Village !!" +
                                    "\nThere are " + noofhouses + " Houses in This Village !!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (var context = new sampledbEntities())
                    {
                        VILLAGE v = context.VILLAGES.Find(vid);

                        context.VILLAGES.Remove(v);
                        var res = await context.SaveChangesAsync();

                        MessageBox.Show("Village Record Deleted Successfully !!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDefaultTblVillage();
                    }
                }
            }
        }
        private void BtnVillageSearch_Click(object sender, EventArgs e)
        {

            TblVillage.Rows.Clear();

            string vid = TxtVillageId.Text.Trim().ToUpper();
            string vname = TxtVillageName.Text.Trim().ToUpper();
            string vcode = TxtVillageCode.Text.Trim().ToUpper();

            string sql = "SELECT * FROM VILLAGES WHERE VILLAGE_ID LIKE '%" + vid + "%' AND VILLAGE_NAME LIKE '%" + vname + "%' AND VILLAGE_CODE LIKE '%" + vcode + "%'";

            string connstring = "data source=.;initial catalog=sampledb; integrated security=True; MultipleActiveResultSets=True;";

            using (var Conn = new SqlConnection(connstring))
            {
                Conn.Open();

                SqlCommand cmd = new SqlCommand(sql, Conn);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(TblVillage);
                            row.Cells[0].Value = dr["VILLAGE_ID"];
                            row.Cells[1].Value = dr["VILLAGE_NAME"];
                            row.Cells[2].Value = dr["VILLAGE_CODE"];
                            row.Cells[3].Value = dr["NO_OF_HOUSES"];
                            TblVillage.Rows.Add(row);

                        }

                    }
                    else
                    {
                        MessageBox.Show("No Record To Display!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TabVillage_Reset();
                    }
                }
            }

        }
        private void BtnVillageReset_Click(object sender, EventArgs e)
        {
            TabVillage_Reset();
        }

        /**********************************************************************************************************/

        // Village Logs Tab button Events
        private void BtnVillageLogsSearch_Click(object sender, EventArgs e)
        {

            TblVillageLogs.Rows.Clear();

            string vid = TxtVillageLogsVillageId.Text.Trim().ToUpper();
            string vname = TxtVillageLogsVillageName.Text.Trim().ToUpper();
            string vcode = TxtVillageLogsVillageCode.Text.Trim().ToUpper();

            string sql = "SELECT * FROM LOGS_VILLAGES WHERE VILLAGE_ID LIKE '%" + vid + "%' AND VILLAGE_NAME LIKE '%" + vname + "%' AND VILLAGE_CODE LIKE '%" + vcode + "%'";

            string connstring = "data source=.;initial catalog=sampledb; integrated security=True; MultipleActiveResultSets=True;";

            using (var Conn = new SqlConnection(connstring))
            {
                Conn.Open();

                SqlCommand cmd = new SqlCommand(sql, Conn);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(TblVillageLogs);
                            row.Cells[0].Value = dr["LOG_ID"];
                            row.Cells[1].Value = dr["OP_TYPE"];
                            row.Cells[2].Value = dr["VILLAGE_ID"];
                            row.Cells[3].Value = dr["VILLAGE_NAME"];
                            row.Cells[4].Value = dr["VILLAGE_CODE"];
                            row.Cells[5].Value = dr["NO_OF_HOUSES"];
                            TblVillageLogs.Rows.Add(row);

                        }

                    }
                    else
                    {
                        MessageBox.Show("No Record To Display!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TabVillageLogs_Reset();
                    }
                }
            }

        }
        private void BtnVillageLogsReset_Click(object sender, EventArgs e)
        {
            TabVillageLogs_Reset();
        }

        /**********************************************************************************************************/

        // House Tab button Events
        private async void BtnHouseInsert_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Values for House Id and No. of People is Ignored !!" +
                            "  They will be automatically Generated by Database  ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var vname = TxtHouseVillageName.SelectedItem.ToString().ToUpper().Trim();

            DialogResult result = MessageBox.Show("Confirm the Following Details !!\n" +
                                                  "      Village Name = " + vname,
                                                  "",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (var context = new sampledbEntities())
                {
                    int vid = -1;

                    foreach (VILLAGE v in context.VILLAGES)
                    {
                        if (v.VILLAGE_NAME == vname)
                        {
                            vid = v.VILLAGE_ID;
                        }
                    }

                    var houseObj = new House()
                    {
                        VILLAGE_ID = vid
                    };

                    context.HOUSES.Add(houseObj);
                    var res = await context.SaveChangesAsync();

                    MessageBox.Show("!! New House Added Successfully !!\n" +
                                    "   House Id = " + houseObj.HOUSE_ID + "\n" +
                                    "   Village Name = " + vname + "\n" +
                                    "   No. of People = " + houseObj.NO_OF_PEOPLE + "\n");
                }

                LoadDefaultTblHouse();
            }
        }
        private async void BtnHouseUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Value for Village Name will be updated for Selected House Id in the Table !!");

            int row = TblHouse.SelectedRows[0].Index;

            int hid = Convert.ToInt32(TblHouse[0, row].Value);
            int noofpeople = Convert.ToInt32(TblHouse[2, row].Value);

            string vname = TxtHouseVillageName.SelectedItem.ToString();

            DialogResult result = MessageBox.Show("\t!! Confirm the Following Details !!\n" +
                                                  "\n\t     House Id    = " + hid +
                                                  "\n\t     Village Name  = " + vname +
                                                  "\n\t     No. of People = " + noofpeople,
                                                  "Confirmation Box",
                                                  MessageBoxButtons.YesNo);

            int vid = -1;

            using (var context = new sampledbEntities())
            {
                foreach (var v in context.VILLAGES)
                {
                    if (vname == v.VILLAGE_NAME)
                    {
                        vid = v.VILLAGE_ID;
                        break;
                    }
                }
            }

            if (result == DialogResult.Yes)
            {
                using (var context = new sampledbEntities())
                {
                    House h = context.HOUSES.Find(hid);

                    h.VILLAGE_ID = vid;

                    var res = await context.SaveChangesAsync();

                    if (res == 1)
                    {
                        MessageBox.Show("\t!! House Record Updated Successfully !!\n\n" +
                                    "\t      House Id = " + h.HOUSE_ID + "\n" +
                                    "\t      Village Name = " + vname + "\n" +
                                    "\t      No. of People = " + h.NO_OF_PEOPLE + "\n");
                    }
                    else
                    {
                        MessageBox.Show("\t\t!! Database Error !!\n" +
                                        "\t!! House Update Operation Failed !!");
                        Console.WriteLine("res = " + res);
                    }

                }
                LoadDefaultTblHouse();
            }
        }
        private async void BtnHouseDelete_Click(object sender, EventArgs e)
        {
            int row = TblHouse.SelectedRows[0].Index;

            int hid = Convert.ToInt32(TblHouse[0, row].Value);
            int vid = -1;

            using (var context = new sampledbEntities())
            {
                foreach (var v in context.VILLAGES)
                {
                    if (v.VILLAGE_NAME == Convert.ToString(TblHouse[1, row].Value))
                    {
                        vid = v.VILLAGE_ID;
                        break;
                    }
                }
            }

            int noofpeople = Convert.ToInt32(TblHouse[2, row].Value);

            DialogResult result = MessageBox.Show("!! Do You want to Delete the Following Record !!\n" +
                                                  "\n\tHouse Id    = " + hid +
                                                  "\n\tVillage Id    = " + vid +
                                                  "\n\tNo. of People = " + noofpeople
                                                  , "Confirmation Box", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (noofpeople != 0)
                {
                    MessageBox.Show("\t\t!!Cannot Delete this House !!" +
                                    "\nThere are " + noofpeople + " People in This House !!");
                }
                else
                {
                    using (var context = new sampledbEntities())
                    {
                        House h = context.HOUSES.Find(hid);

                        context.HOUSES.Remove(h);
                        var res = await context.SaveChangesAsync();

                        MessageBox.Show("House Record Deleted Successfully !!");

                        LoadDefaultTblHouse();
                    }
                }
            }
        }
        private void BtnHouseSearch_Click(object sender, EventArgs e)
        {
            TblHouse.Rows.Clear();

            string hid = TxtHouseId.Text.Trim().ToUpper();
            string vname = "";
            string vid = "";
            if (TxtHouseVillageName.SelectedItem != null)
            {
                vname = TxtHouseVillageName.SelectedItem.ToString().Trim().ToUpper();

                using (var context = new sampledbEntities())
                {
                    foreach (var v in context.VILLAGES)
                    {
                        if (v.VILLAGE_NAME == vname)
                        {
                            vid = v.VILLAGE_ID.ToString();
                            break;
                        }
                    }
                }
            }

            string sql = "SELECT * FROM HOUSES WHERE HOUSE_ID LIKE '%" + hid + "%' AND VILLAGE_ID LIKE '%" + vid + "%'";

            string connstring = "data source=.;initial catalog=sampledb; integrated security=True; MultipleActiveResultSets=True;";

            using (var Conn = new SqlConnection(connstring))
            {
                Conn.Open();

                SqlCommand cmd = new SqlCommand(sql, Conn);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(TblHouse);
                            row.Cells[0].Value = dr["HOUSE_ID"];

                            string vname1 = "";

                            using (var context = new sampledbEntities())
                            {
                                foreach (var v in context.VILLAGES)
                                {
                                    if (v.VILLAGE_ID == Convert.ToInt32(dr["VILLAGE_ID"]))
                                    {
                                        vname1 = v.VILLAGE_NAME;
                                        break;
                                    }
                                }
                            }

                            row.Cells[1].Value = vname1;
                            row.Cells[2].Value = dr["NO_OF_PEOPLE"];
                            TblHouse.Rows.Add(row);

                        }

                    }
                    else
                    {
                        MessageBox.Show("No Record To Display!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TabHouse_Reset();
                    }
                }
            }
        }
        private void BtnHouseReset_Click(object sender, EventArgs e)
        {
            TabHouse_Reset();
        }

        /**********************************************************************************************************/

        // House Logs Tab button Events
        private void BtnHouseLogsSearch_Click(object sender, EventArgs e)
        {
            TblHouseLogs.Rows.Clear();

            string hid = TxtHouseLogsHouseId.Text.Trim().ToUpper();
            string vname = TxtHouseLogsVillageName.Text.Trim().ToUpper();
            string vid = "";

            using (var context = new sampledbEntities())
            {
                foreach (var v in context.LOGS_VILLAGES)
                {
                    if (v.VILLAGE_NAME == vname)
                    {
                        vid = v.VILLAGE_ID.ToString();
                        break;
                    }
                }
            }

            string sql = "SELECT * FROM LOGS_HOUSES WHERE HOUSE_ID LIKE '%" + hid + "%' AND VILLAGE_ID LIKE '%" + vid + "%'";

            string connstring = "data source=.;initial catalog=sampledb; integrated security=True; MultipleActiveResultSets=True;";

            using (var Conn = new SqlConnection(connstring))
            {
                Conn.Open();

                SqlCommand cmd = new SqlCommand(sql, Conn);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(TblHouseLogs);

                            row.Cells[0].Value = dr["LOG_ID"];
                            row.Cells[1].Value = dr["OP_TYPE"];
                            row.Cells[2].Value = dr["HOUSE_ID"];

                            string vname1 = "";

                            using (var context = new sampledbEntities())
                            {
                                foreach (var v in context.LOGS_VILLAGES)
                                {
                                    if (v.VILLAGE_ID == Convert.ToInt32(dr["VILLAGE_ID"]))
                                    {
                                        vname1 = v.VILLAGE_NAME;
                                        break;
                                    }
                                }
                            }

                            row.Cells[3].Value = vname1;
                            row.Cells[4].Value = dr["NO_OF_PEOPLE"];
                            TblHouseLogs.Rows.Add(row);

                        }

                    }
                    else
                    {
                        MessageBox.Show("No Record To Display!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TabHouseLogs_Reset();
                    }
                }
            }
        }
        private void BtnHouseLogsReset_Click(object sender, EventArgs e)
        {
            TabHouseLogs_Reset();
        }

        /**********************************************************************************************************/

        // Person Tab button Events
        private async void BtnPersonInsert_Click(object sender, EventArgs e)
        {

            MessageBox.Show("     Values for Person Id is Ignored !!       \n" +
                            "It will be automatically Generated by Database");

            string vname = (string)TxtPersonVillageName.SelectedItem.ToString().ToUpper().Trim();
            int houseid = (int)TxtPersonHouseId.SelectedItem;
            string name = TxtPersonName.Text.Trim().ToUpper();
            int age = (int)TxtPersonAge.Value;
            string gender = (string)TxtPersonGender.SelectedItem;
            string phoneno = (string)TxtPersonPhoneNo.Text.Trim();
            gender = gender.Trim().ToUpper();

            DialogResult result = MessageBox.Show("Confirm the Following Details !!\n" +
                                                  "Village        = " + vname + "\n" +
                                                  "House Id       = " + houseid + "\n" +
                                                  "Name           = " + name + "\n" +
                                                  "Age            = " + age + "\n" +
                                                  "Gender         = " + gender + "\n" +
                                                  "Phone Number   = " + phoneno + "\n",
                                                  "Confirmation Box",
                                                  MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string name_cpy = "" + name;

                StringBuilder str = new StringBuilder(name);

                str.Replace(" ", "");

                name_cpy = str.ToString();

                bool b1 = phoneno.Length >= 10;
                bool b2 = phoneno.All(char.IsDigit);
                bool b3 = name_cpy.All(char.IsLetter);
                bool b4 = age > 0;


                if (b1 && b2 && b3 && b4)
                {
                    using (var context = new sampledbEntities())
                    {

                        var personObj = new PERSON()
                        {
                            HOUSE_ID = houseid,
                            NAME = name,
                            AGE = age,
                            GENDER = gender,
                            PHONE_NO = phoneno
                        };

                        context.PERSONS.Add(personObj);
                        var res = await context.SaveChangesAsync();

                        MessageBox.Show("!! New Person Added Successfully !!\n" +
                                        "     Person Id    = " + personObj.PERSON_ID + "\n" +
                                        "     Village      = " + vname +
                                        "     House Id     = " + personObj.HOUSE_ID + "\n" +
                                        "     Name         = " + personObj.NAME + "\n" +
                                        "     Age          = " + personObj.AGE + "\n" +
                                        "     Gender       = " + personObj.GENDER + "\n" +
                                        "     Phone Number = " + personObj.PHONE_NO + "\n");

                    }
                }
                else
                {
                    MessageBox.Show("                !! Please Input Valid Details !!\n" +
                                    "\n1. Name Must only contain Letters\n" +
                                    "\n2. Phone Number must be 10 digits long and contain only numbers\n" +
                                    "\n3. Age Must be Greater than 0\n",
                                    "Form Error");
                    LoadDefaultTblPerson();
                }

                LoadDefaultTblPerson();
            }

        }
        private async void BtnPersonUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name, Age, Gender and Phone No. will be updated for Selected Person Id, House Id and Village Name in the Table !!");

            int row = TblPerson.SelectedRows[0].Index;

            int pid = Convert.ToInt32(TblPerson[0, row].Value);
            int hid = Convert.ToInt32(TblPerson[1, row].Value);
            string vname = (string)TblPerson[2, row].Value;
            string name = TxtPersonName.Text;
            int age = Convert.ToInt32(TxtPersonAge.Value);
            string gender = (string)TxtPersonGender.SelectedItem;
            string phoneno = TxtPersonPhoneNo.Text;


            DialogResult result = MessageBox.Show("\t!! Confirm the Following Details !!\n" +
                                                  "\n\t     Person Id    = " + pid +
                                                  "\n\t     House Id  = " + hid +
                                                  "\n\t     Village Name  = " + vname +
                                                  "\n\t     Name = " + name +
                                                  "\n\t     Age    = " + age +
                                                  "\n\t     Gender  = " + gender +
                                                  "\n\t     Phone Number = " + phoneno,
                                                  "Confirmation Box",
                                                  MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                using (var context = new sampledbEntities())
                {
                    PERSON p = context.PERSONS.Find(pid);

                    p.NAME = name;
                    p.AGE = age;
                    p.GENDER = gender;
                    p.PHONE_NO = phoneno;

                    var res = await context.SaveChangesAsync();

                    if (res == 1)
                    {
                        MessageBox.Show("\t!! Person Record Updated Successfully !!\n\n" +
                                        "\n\t     Person Id    = " + p.PERSON_ID +
                                        "\n\t     House Id  = " + p.HOUSE_ID +
                                        "\n\t     Village Name  = " + vname +
                                        "\n\t     Name = " + p.NAME +
                                        "\n\t     Age    = " + p.AGE +
                                        "\n\t     Gender  = " + p.GENDER +
                                        "\n\t     Phone Number = " + p.PHONE_NO);
                    }
                    else
                    {
                        MessageBox.Show("\t\t!! Database Error !!\n" +
                                        "\t!! Person Update Operation Failed !!");
                    }

                }
                LoadDefaultTblVillage();
            }
        }
        private async void BtnPersonDelete_Click(object sender, EventArgs e)
        {

            int row = TblPerson.SelectedRows[0].Index;

            int pid = Convert.ToInt32(TblPerson[0, row].Value);
            int hid = Convert.ToInt32(TblPerson[1, row].Value);
            string village = Convert.ToString(TblPerson[2, row].Value);
            string name = Convert.ToString(TblPerson[3, row].Value);
            int age = Convert.ToInt32(TblPerson[4, row].Value);
            string gender = Convert.ToString(TblPerson[5, row].Value);
            string phoneno = Convert.ToString(TblPerson[6, row].Value);

            DialogResult result = MessageBox.Show("!! Do You want to Delete the Following Record !!\n" +
                                                  "\n\tVillage Id    = " + pid +
                                                  "\n\tHouse Id      = " + hid +
                                                  "\n\tVillage Name  = " + village +
                                                  "\n\tName          = " + name +
                                                  "\n\tAge           = " + age +
                                                  "\n\tGender        = " + gender +
                                                  "\n\tPhone Number  = " + phoneno
                                                  , "Confirmation Box", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                using (var context = new sampledbEntities())
                {
                    PERSON p = context.PERSONS.Find(pid);

                    context.PERSONS.Remove(p);
                    var res = await context.SaveChangesAsync();

                    if (res == 1)
                    {
                        MessageBox.Show("Person Record Deleted Successfully !!");
                    }
                    else
                    {
                        MessageBox.Show("\t\t!! Database Error !!\n" +
                                        "\t!! House Update Operation Failed !!");
                        Console.WriteLine("res = " + res);
                    }

                    LoadDefaultTblPerson();
                }
            }

        }
        private void BtnPersonSearch_Click(object sender, EventArgs e)
        {
            TblPerson.Rows.Clear();

            string pid = TxtPersonId.Text.Trim().ToUpper();

            string vname = "";
            string vid = "";
            if (TxtPersonVillageName.SelectedItem != null)
            {
                vname = TxtPersonVillageName.SelectedItem.ToString().Trim().ToUpper();

                using (var context = new sampledbEntities())
                {
                    foreach (var v in context.VILLAGES)
                    {
                        if (v.VILLAGE_NAME == vname)
                        {
                            vid = v.VILLAGE_ID.ToString();
                            break;
                        }
                    }
                }
            }

            string hid = "";
            if (TxtPersonHouseId.SelectedItem != null)
            {
                hid = TxtPersonHouseId.SelectedItem.ToString().Trim().ToUpper();
            }

            string name = TxtPersonName.Text.Trim().ToUpper();
            string age = TxtPersonAge.Value.ToString();
            if (age == "0")
            {
                age = "";
            }
            string gender = "";
            if (TxtPersonGender.SelectedItem != null)
            {
                gender = TxtPersonGender.SelectedItem.ToString().Trim().ToUpper();
            }

            string phoneno = TxtPersonPhoneNo.Text.ToString().Trim().ToUpper();

            Console.WriteLine("pid = " + pid + "\n" +
                              "vid = " + vid + "\n" +
                              "hid = " + hid + "\n" +
                              "name = " + name + "\n" +
                              "age = " + age + "\n" +
                              "gender = " + gender + "\n" +
                              "phoneno = " + phoneno + "\n");

            string sql = "SELECT * FROM PERSONS WHERE PERSON_ID LIKE '%" + pid + "%' AND HOUSE_ID IN (select HOUSE_ID from HOUSES where VILLAGE_ID LIKE '%" + vid + "%') AND HOUSE_ID LIKE '%" + hid + "%'" +
                         "AND NAME LIKE '%" + name + "%' AND AGE LIKE '%" + age + "%' AND GENDER LIKE '%" + gender + "%' AND PHONE_NO LIKE '%" + phoneno + "%'";

            string connstring = "data source=.;initial catalog=sampledb; integrated security=True; MultipleActiveResultSets=True;";

            using (var Conn = new SqlConnection(connstring))
            {
                Conn.Open();

                SqlCommand cmd = new SqlCommand(sql, Conn);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(TblPerson);

                            using (var context = new sampledbEntities())
                            {
                                int vid1 = context.HOUSES.Find(dr["HOUSE_ID"]).VILLAGE_ID;
                                string vname1 = context.VILLAGES.Find(vid1).VILLAGE_NAME;

                                row.Cells[0].Value = dr["PERSON_ID"];
                                row.Cells[1].Value = dr["HOUSE_ID"];
                                row.Cells[2].Value = vname1;
                                row.Cells[3].Value = dr["NAME"];
                                row.Cells[4].Value = dr["AGE"];
                                row.Cells[5].Value = dr["GENDER"];
                                row.Cells[6].Value = dr["PHONE_NO"];
                                TblPerson.Rows.Add(row);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("No Record To Display!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TabPerson_Reset();
                    }
                }
            }
        }
        private void BtnPersonReset_Click(object sender, EventArgs e)
        {
            TabPerson_Reset();
        }

        /**********************************************************************************************************/

        // House Logs Tab button Events
        private void BtnPersonLogsSearch_Click(object sender, EventArgs e)
        {
            TblPersonLogs.Rows.Clear();

            string pid = TxtPersonLogsPersonId.Text.Trim().ToUpper();

            string vname = TxtPersonLogsVillageName.Text.Trim().ToUpper();
            string vid = "";
            if (TxtPersonLogsVillageName.Text != "")
            {
                using (var context = new sampledbEntities())
                {
                    foreach (var v in context.LOGS_VILLAGES)
                    {
                        if (v.VILLAGE_NAME == vname)
                        {
                            vid = v.VILLAGE_ID.ToString();
                            break;
                        }
                    }
                }
            }

            string hid = TxtPersonLogsHouseId.Text.Trim().ToUpper();
            string name = TxtPersonLogsName.Text.Trim().ToUpper();
            string age = TxtPersonLogsAge.Text;
            string gender = TxtPersonLogsGender.Text.Trim().ToUpper();
            string phoneno = TxtPersonLogsPhoneNo.Text.Trim().ToUpper();

            string sql = "SELECT * FROM LOGS_PERSONS WHERE PERSON_ID LIKE '%" + pid + "%' AND HOUSE_ID IN (select TOP 1 HOUSE_ID from LOGS_HOUSES where VILLAGE_ID LIKE '%" + vid + "%') AND HOUSE_ID LIKE '%" + hid + "%'" +
                         "AND NAME LIKE '%" + name + "%' AND AGE LIKE '%" + age + "%' AND GENDER LIKE '%" + gender + "%' AND PHONE_NO LIKE '%" + phoneno + "%'";

            string connstring = "data source=.;initial catalog=sampledb; integrated security=True; MultipleActiveResultSets=True;";

            using (var Conn = new SqlConnection(connstring))
            {
                Conn.Open();

                SqlCommand cmd = new SqlCommand(sql, Conn);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(TblPersonLogs);

                            using (var context = new sampledbEntities())
                            {
                                int hid1 = Convert.ToInt32(dr["HOUSE_ID"]);
                                int vid1 = -1;

                                foreach (var h in context.LOGS_HOUSES)
                                {
                                    if (hid1 == h.HOUSE_ID)
                                    {
                                        vid1 = h.HOUSE_ID;
                                        break;
                                    }
                                }

                                string vname1 = "";

                                foreach (var v in context.LOGS_VILLAGES)
                                {
                                    if (vid1 == v.VILLAGE_ID)
                                    {
                                        vname = v.VILLAGE_NAME;
                                        break;
                                    }
                                }

                                row.Cells[0].Value = dr["LOG_ID"];
                                row.Cells[1].Value = dr["OP_TYPE"];
                                row.Cells[2].Value = dr["PERSON_ID"];
                                row.Cells[3].Value = dr["HOUSE_ID"];
                                row.Cells[4].Value = vname1;
                                row.Cells[5].Value = dr["NAME"];
                                row.Cells[6].Value = dr["AGE"];
                                row.Cells[7].Value = dr["GENDER"];
                                row.Cells[8].Value = dr["PHONE_NO"];
                                TblPersonLogs.Rows.Add(row);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("No Record To Display!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TabPersonLogs_Reset();
                    }
                }
            }
        }
        private void BtnPersonLogsReset_Click(object sender, EventArgs e)
        {
            TabPersonLogs_Reset();
        }

        /**********************************************************************************************************/

        // DataGridView Cell Mouse Double Click Events
        private void TblVillage_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;

            if (row >= 0)
            {
                TxtVillageId.Text = Convert.ToString(TblVillage[0, row].Value);
                TxtVillageName.Text = Convert.ToString(TblVillage[1, row].Value);
                TxtVillageCode.Text = Convert.ToString(TblVillage[2, row].Value);
                TxtVillageNoOfHouses.Text = Convert.ToString(TblVillage[3, row].Value);
            }
        }
        private void TblHouse_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;

            if (row >= 0)
            {
                TxtHouseId.Text = Convert.ToString(TblHouse[0, row].Value);
                TxtHouseVillageName.Text = Convert.ToString(TblHouse[1, row].Value);
                TxtHouseNoOfPeople.Text = Convert.ToString(TblHouse[2, row].Value);
            }
        }
        private void TblPerson_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;

            if (row >= 0)
            {
                TxtPersonId.Text = Convert.ToString(TblPerson[0, row].Value);
                TxtPersonHouseId.Text = Convert.ToString(TblPerson[1, row].Value);
                TxtPersonVillageName.SelectedIndex = TxtPersonVillageName.FindStringExact(Convert.ToString(TblPerson[2, row].Value));
                TxtPersonName.Text = Convert.ToString(TblPerson[3, row].Value);
                TxtPersonAge.Value = Convert.ToInt32(TblPerson[4, row].Value);
                TxtPersonGender.SelectedIndex = TxtPersonGender.FindStringExact(Convert.ToString(TblPerson[5, row].Value));
                TxtPersonPhoneNo.Text = Convert.ToString(TblPerson[6, row].Value);
            }
        }

        /**********************************************************************************************************/

        // Person Tab Village ComboBox Selected Item Change Event to fill House Id Combobox
        private void TxtPersonVillageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TxtPersonVillageName.SelectedItem != null)
            {
                string vname = TxtPersonVillageName.SelectedItem.ToString();
                int vid = -1;

                using (var context = new sampledbEntities())
                {
                    foreach (VILLAGE v in context.VILLAGES)
                    {
                        if (vname == v.VILLAGE_NAME)
                        {
                            vid = v.VILLAGE_ID;
                        }
                    }

                    TxtPersonHouseId.DataSource = null;
                    TxtPersonHouseId.Items.Clear();

                    List<int> comboSource = new List<int>();

                    foreach (House h in context.HOUSES)
                    {
                        if (h.VILLAGE_ID == vid)
                        {
                            comboSource.Add(h.HOUSE_ID);
                        }
                    }

                    TxtPersonHouseId.DataSource = new BindingSource(comboSource, null);
                }
            }
        }

        /**********************************************************************************************************/

        // Person Tab Text Change Events using RegEx
        private void TxtPersonId_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TxtPersonId.Text, "[^0-9]") && TxtPersonId.Text != "")
            {
                MessageBox.Show("Enter only Numbers !!");
                TxtPersonId.Text = TxtPersonId.Text.Remove(TxtPersonId.Text.Length - 1);
            }
        }
        private void TxtPersonPhoneNo_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TxtPersonPhoneNo.Text, "[^0-9]") && TxtPersonPhoneNo.Text != "")
            {
                MessageBox.Show("Enter only Numbers !!");
                TxtPersonPhoneNo.Text = TxtPersonPhoneNo.Text.Remove(TxtPersonPhoneNo.Text.Length - 1);
            }
        }
        private void TxtPersonName_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TxtPersonName.Text, @"[\p{L} ]+$") && TxtPersonName.Text != "")
            {
                MessageBox.Show("Enter only Alphabet and Spaces!!");
                TxtPersonName.Text = TxtPersonName.Text.Remove(TxtPersonName.Text.Length - 1);

            }
        }

        // House Tab Text Change Events using RegEx
        private void TxtHouseId_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TxtHouseId.Text, "[^0-9]") && TxtHouseId.Text != "")
            {
                MessageBox.Show("Enter only Numbers !!");
                TxtHouseId.Text = TxtHouseId.Text.Remove(TxtHouseId.Text.Length - 1);
            }
        }

        // Village Tab Text Change Events using RegEx
        private void TxtVillageId_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TxtVillageId.Text, "[^0-9]") && TxtVillageId.Text != "")
            {
                MessageBox.Show("Enter only Numbers !!");
                TxtVillageId.Text = TxtVillageId.Text.Remove(TxtVillageId.Text.Length - 1);
            }
        }
        private void TxtVillageName_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TxtVillageName.Text, @"[\p{L} ]+$") && TxtVillageName.Text != "")
            {
                MessageBox.Show("Enter only Alphabet and Spaces!!");
                TxtVillageName.Text = TxtVillageName.Text.Remove(TxtVillageName.Text.Length - 1);

            }
        }
        private void TxtVillageCode_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TxtVillageCode.Text, @"[\p{L}]+$") && TxtVillageCode.Text != "")
            {
                MessageBox.Show("Enter only Alphabet!!");
                TxtVillageCode.Text = TxtVillageCode.Text.Remove(TxtVillageCode.Text.Length - 1);

            }
        }

        /**********************************************************************************************************/

        // TblPerson ContextMenu Events
        private void TblPersonPrintAsPDF_Click(object sender, EventArgs e)
        {
            PrintToPDF(TblPerson);
        }
        private void TblPersonPrintAsExcel_Click(object sender, EventArgs e)
        {
            PrintToExcel(TblPerson);
        }

        // TblHouse ContextMenu Events
        private void TblHousePrintAsPDF_Click(object sender, EventArgs e)
        {
            PrintToPDF(TblHouse);
        }
        private void TblHousePrintAsExcel_Click(object sender, EventArgs e)
        {
            PrintToExcel(TblHouse);
        }

        // TblVillage ContextMenu Events
        private void TblVillagePrintAsPDF_Click(object sender, EventArgs e)
        {
            PrintToPDF(TblVillage);
        }
        private void TblVillagePrintAsExcel_Click(object sender, EventArgs e)
        {
            PrintToExcel(TblVillage);
        }

        // TblVillageLogs ContextMenu Event
        private void TblVillageLogsPrintAsPDF_Click(object sender, EventArgs e)
        {
            PrintToPDF(TblVillageLogs);
        }
        private void TblVillageLogsPrintAsExcel_Click(object sender, EventArgs e)
        {
            PrintToExcel(TblVillageLogs);
        }

        // TblPersonLogs ContextMenu Event
        private void TblHouseLogsPrintAsPDF_Click(object sender, EventArgs e)
        {
            PrintToPDF(TblHouseLogs);
        }
        private void TblHouseLogsPrintAsExcel_Click(object sender, EventArgs e)
        {
            PrintToExcel(TblHouseLogs);
        }

        // TblPersonLogs ContextMenu Event
        private void TblPersonLogsPrintAsPDF_Click(object sender, EventArgs e)
        {
            PrintToPDF(TblPersonLogs);
        }
        private void TblPersonLogsPrintAsExcel_Click(object sender, EventArgs e)
        {
            PrintToExcel(TblPersonLogs);
        }



        private void PrintToExcel(DataGridView Tbl)
        {
            SaveFileDialog FileDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx|Excel 2007 (*.xls)|*.xls",
                FilterIndex = 1
            };

            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                string ExcelFilePath = FileDialog.FileName;

                if (File.Exists(ExcelFilePath))
                {
                    File.Delete(ExcelFilePath);
                }

                if (TblVillage.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                    XcelApp.Application.Workbooks.Add();
                    Microsoft.Office.Interop.Excel._Worksheet Worksheet = (Microsoft.Office.Interop.Excel._Worksheet)XcelApp.ActiveSheet;
                    for (int i = 1; i < Tbl.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = Tbl.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < Tbl.Rows.Count; i++)
                    {
                        for (int j = 0; j < Tbl.Columns.Count; j++)
                        {

                            Console.WriteLine("i = " + i + " j = " + j);

                            XcelApp.Cells[i + 2, j + 1] = Tbl.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    XcelApp.Columns.AutoFit();

                    Worksheet.SaveAs(ExcelFilePath);
                    XcelApp.Quit();
                    MessageBox.Show("Excel file saved!");
                }
            }
        }

        private void PrintToPDF(DataGridView Tbl)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {

                            ErrorMessage = true;
                            MessageBox.Show("Unable to Write Data on Disk!" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(Tbl.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in Tbl.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in Tbl.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 12f, 20f, 20f, 12f);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Operation Successfully Performed", "Information");

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("An Error Occurred While Exporting Data!" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Information");

            }
        }

        /**********************************************************************************************************/

    }
}
