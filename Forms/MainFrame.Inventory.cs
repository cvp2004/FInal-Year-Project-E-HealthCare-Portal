using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OPD_Section
{
    public partial class MainFrame
    {
        public void InitInventory()
        {
            LoadDefaultTblMedicines();
            LoadDefaultTblDisposables();
            LoadDefaultTblStationary();
            LoadDefaultTblMiscellaneous();
            LoadDefaultTblInventoryLogs();
        }

        /**********************************************************************************************************/
        /*****************************************INVENTORY-MODULE*************************************************/
        /**********************************************************************************************************/
        private void LoadDefaultTblMedicines()
        {
            TblMedicines.Rows.Clear();

            using (var context = new sampledbEntities())
            {
                foreach (MEDICINE m in context.MEDICINES)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(TblMedicines);
                    row.Cells[0].Value = m.MEDICINE_ID;
                    row.Cells[1].Value = m.MEDICINE_NAME;
                    row.Cells[2].Value = m.QUANTITY;
                    TblMedicines.Rows.Add(row);
                }
            }
        }
        private void LoadDefaultTblDisposables()
        {
            TblDisposables.Rows.Clear();

            using (var context = new sampledbEntities())
            {
                foreach (DISPOSABLE d in context.DISPOSABLES)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(TblDisposables);
                    row.Cells[0].Value = d.DISPOSABLE_ID;
                    row.Cells[1].Value = d.DISPOSABLE_NAME;
                    row.Cells[2].Value = d.QUANTITY;
                    TblDisposables.Rows.Add(row);
                }
            }
        }
        private void LoadDefaultTblStationary()
        {
            TblStationary.Rows.Clear();

            using (var context = new sampledbEntities())
            {
                foreach (STATIONARY m in context.STATIONARies)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(TblStationary);
                    row.Cells[0].Value = m.STATIONARY_ID;
                    row.Cells[1].Value = m.STATIONARY_NAME;
                    row.Cells[2].Value = m.QUANTITY;
                    TblStationary.Rows.Add(row);
                }
            }
        }
        private void LoadDefaultTblMiscellaneous()
        {
            TblMiscellaneous.Rows.Clear();

            using (var context = new sampledbEntities())
            {
                foreach (MISCELLANEOU m in context.MISCELLANEOUS)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(TblMiscellaneous);
                    row.Cells[0].Value = m.MISCELLANEOUS_ID;
                    row.Cells[1].Value = m.MISCELLANEOUS_NAME;
                    row.Cells[2].Value = m.QUANTITY;
                    TblMiscellaneous.Rows.Add(row);
                }
            }
        }
        private void LoadDefaultTblInventoryLogs()
        {
            TblInventoryLogs.Rows.Clear();

            using (var context = new sampledbEntities())
            {
                foreach (LOGS_INVENTORY l in context.LOGS_INVENTORY)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(TblInventoryLogs);
                    row.Cells[0].Value = l.LOG_ID;
                    row.Cells[1].Value = l.TABLE_TYPE;
                    row.Cells[2].Value = l.OP_TYPE;
                    row.Cells[3].Value = l.QUANTITY_CHANGE;
                    row.Cells[4].Value = l.ITEM_ID;
                    row.Cells[5].Value = l.ITEM_NAME;
                    row.Cells[6].Value = l.QUANTITY;
                    TblInventoryLogs.Rows.Add(row);
                }
            }
        }

        /**********************************************************************************************************/

        private void TabMedicines_Reset()
        {
            TxtMedicineId.Text = "";
            TxtMedicineName.Text = "";
            TxtMedicineQuantity.Text = "";

            LoadDefaultTblMedicines();
        }
        private void TabDisposables_Reset()
        {
            TxtDisposableId.Text = "";
            TxtDisposableName.Text = "";
            TxtDisposableQuantity.Text = "";

            LoadDefaultTblDisposables();
        }
        private void TabStationary_Reset()
        {
            TxtStationaryId.Text = "";
            TxtStationaryName.Text = "";
            TxtStationaryQuantity.Text = "";

            LoadDefaultTblStationary();
        }
        private void TabMiscellaneous_Reset()
        {
            TxtMiscellaneousId.Text = "";
            TxtMiscellaneousName.Text = "";
            TxtMiscellaneousQuantity.Text = "";

            LoadDefaultTblMiscellaneous();
        }

        /**********************************************************************************************************/

        // Medicines Tab button Events

        private async void BtnMedicineInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtMedicineName.Text.Trim().ToUpper() != "")
                {
                    MessageBox.Show(
                        " Values for Medicine Id is Ignored !!"
                            + "  It will be automatically Generated by Database  ",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    var mname = (string)TxtMedicineName.Text.Trim().ToUpper();
                    int qty = (int)TxtMedicineQuantity.Value;

                    DialogResult result = MessageBox.Show(
                        "Confirm the Following Details !!\n" +
                        "      Medicine Name = " + mname +
                        "      Quantity = " + qty,
                        "",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        using (var context = new sampledbEntities())
                        {
                            var medObj = new MEDICINE()
                            {
                                MEDICINE_NAME = mname,
                                QUANTITY = qty
                            };

                            context.MEDICINES.Add(medObj);
                            var res = await context.SaveChangesAsync();

                            MessageBox.Show(
                                "!! New Medicine Added Successfully !!\n"
                                    + "   Medicine Id = "
                                    + medObj.MEDICINE_ID
                                    + "\n"
                                    + "   Medicine Name = "
                                    + medObj.MEDICINE_NAME
                                    + "\n"
                                    + "   Quantity = "
                                    + medObj.QUANTITY
                                    + "\n"
                            );
                        }

                        LoadDefaultTblMedicines();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "                !! Please Input Valid Details !!\n"
                            + "\n1. Medicine Name must not be empty\n",
                        "Form Error"
                    );
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private async void BtnMedicineUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtMedicineName.Text.Trim().ToUpper() != "" && TxtMedicineQuantity.Value >= 0)
                {
                    MessageBox.Show(
                        "Value for Medicine Name and Quantity will be updated for Selected Item Id in the Table !!"
                    );

                    int row = TblMedicines.SelectedRows[0].Index;

                    int mid = Convert.ToInt32(TblMedicines[0, row].Value);
                    int qty = (int)TxtMedicineQuantity.Value;

                    string mname = TxtMedicineName.Text.Trim().ToUpper();

                    DialogResult result = MessageBox.Show(
                        "\t!! Confirm the Following Details !!\n"
                            + "\n\t     Medicine Id    = "
                            + mid
                            + "\n\t     Medicine Name  = "
                            + mname
                            + "\n\t     Quantity = "
                            + qty,
                        "Confirmation Box",
                        MessageBoxButtons.YesNo
                    );

                    if (result == DialogResult.Yes)
                    {
                        using (var context = new sampledbEntities())
                        {
                            MEDICINE m = context.MEDICINES.Find(mid);

                            m.MEDICINE_NAME = mname;
                            m.QUANTITY = qty;

                            var res = await context.SaveChangesAsync();

                            if (res == 1)
                            {
                                MessageBox.Show(
                                    "\t!! Medicine Record Updated Successfully !!\n\n"
                                        + "\t      Medicine Id = "
                                        + m.MEDICINE_ID
                                        + "\n"
                                        + "\t      Medicine Name = "
                                        + m.MEDICINE_NAME
                                        + "\n"
                                        + "\t      Quantity = "
                                        + m.QUANTITY
                                        + "\n"
                                );
                            }
                            else
                            {
                                MessageBox.Show(
                                    "\t\t!! Database Error !!\n"
                                        + "\t!! Medicine Update Operation Failed !!"
                                );
                                Console.WriteLine("res = " + res);
                            }
                        }
                        LoadDefaultTblMedicines();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "                !! Please Input Valid Details !!\n"
                            + "\n1. Item Name must not be Empty\n"
                            + "\n2. Quantity cannot be less than 0\n",
                        "Form Error"
                    );
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private async void BtnMedicineDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int row = TblMedicines.SelectedRows[0].Index;

                Console.WriteLine("row = " + row);

                int mid = Convert.ToInt32(TblMedicines[0, row].Value);

                Console.WriteLine("mid = " + mid);

                string mname = (string)TblMedicines[1, row].Value;

                Console.WriteLine("mname = " + mname);

                int qty = Convert.ToInt32(TblMedicines[2, row].Value);

                Console.WriteLine("qty = " + qty);

                DialogResult result = MessageBox.Show(
                    "!! Do You want to Delete the Following Record !!\n"
                        + "\n\tMedicine Id    = "
                        + mid
                        + "\n\tMedicine Name    = "
                        + mname
                        + "\n\tQuantity = "
                        + qty,
                    "Confirmation Box",
                    MessageBoxButtons.YesNo
                );

                if (result == DialogResult.Yes)
                {
                    using (var context = new sampledbEntities())
                    {
                        MEDICINE m = context.MEDICINES.Find(mid);

                        context.MEDICINES.Remove(m);
                        var res = await context.SaveChangesAsync();

                        if (res == 1)
                        {
                            MessageBox.Show("Medicine Record Deleted Successfully !!");

                            LoadDefaultTblMedicines();
                        }
                        else
                        {
                            MessageBox.Show(
                                    "\t\t!! Database Error !!\n"
                                        + "\t!! Medicine Delete Operation Failed !!"
                                );
                            Console.WriteLine("res = " + res);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private void BtnMedicineSearcch_Click(object sender, EventArgs e)
        {
            TblMedicines.Rows.Clear();

            string mid = TxtMedicineId.Text.Trim().ToUpper();
            string mname = TxtMedicineName.Text.Trim().ToUpper();

            string sql = "SELECT * FROM MEDICINES WHERE MEDICINE_ID LIKE '%" + mid + "%' AND MEDICINE_NAME LIKE '%" + mname + "%'";

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
                            row.CreateCells(TblMedicines);
                            row.Cells[0].Value = dr["MEDICINE_ID"];
                            row.Cells[1].Value = dr["MEDICINE_NAME"];
                            row.Cells[2].Value = dr["QUANTITY"];
                            TblMedicines.Rows.Add(row);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "No Record To Display!",
                            "",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        TabVillage_Reset();
                    }
                }
            }
        }
        private void BtnMedicineReset_Click(object sender, EventArgs e)
        {
            TabMedicines_Reset();
        }

        /**********************************************************************************************************/

        // Disposable Tab button Events

        private async void BtnDisposableInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtDisposableName.Text.Trim().ToUpper() != "")
                {
                    MessageBox.Show(
                        " Values for Disposable Id is Ignored !!"
                            + "  It will be automatically Generated by Database  ",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    var dname = (string)TxtDisposableName.Text.Trim().ToUpper();
                    int qty = (int)TxtDisposableQuantity.Value;

                    DialogResult result = MessageBox.Show(
                        "Confirm the Following Details !!\n" +
                        "      Disposable Name = " + dname +
                        "      Quantity = " + qty,
                        "",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        using (var context = new sampledbEntities())
                        {
                            var dispObj = new DISPOSABLE()
                            {
                                DISPOSABLE_NAME = dname,
                                QUANTITY = qty
                            };

                            context.DISPOSABLES.Add(dispObj);
                            var res = await context.SaveChangesAsync();

                            MessageBox.Show(
                                "!! New Disposable Added Successfully !!\n"
                                    + "   Disposable Id = "
                                    + dispObj.DISPOSABLE_ID
                                    + "\n"
                                    + "   Disposable Name = "
                                    + dispObj.DISPOSABLE_NAME
                                    + "\n"
                                    + "   Quantity = "
                                    + dispObj.QUANTITY
                                    + "\n"
                            );
                        }

                        LoadDefaultTblDisposables();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "                !! Please Input Valid Details !!\n"
                            + "\n1. Disposable Name must not be empty\n",
                        "Form Error"
                    );
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private async void BtnDisposableUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtDisposableName.Text.Trim().ToUpper() != "" && TxtDisposableQuantity.Value >= 0)
                {
                    MessageBox.Show(
                        "Value for Disposable Name and Quantity will be updated for Selected Item Id in the Table !!"
                    );

                    int row = TblDisposables.SelectedRows[0].Index;

                    int did = Convert.ToInt32(TblDisposables[0, row].Value);
                    int qty = (int)TxtDisposableQuantity.Value;

                    string dname = TxtDisposableName.Text.Trim().ToUpper();

                    DialogResult result = MessageBox.Show(
                        "\t!! Confirm the Following Details !!\n"
                            + "\n\t     Disposable Id    = "
                            + did
                            + "\n\t     Disposable Name  = "
                            + dname
                            + "\n\t     Quantity = "
                            + qty,
                        "Confirmation Box",
                        MessageBoxButtons.YesNo
                    );

                    if (result == DialogResult.Yes)
                    {
                        using (var context = new sampledbEntities())
                        {
                            DISPOSABLE d = context.DISPOSABLES.Find(did);

                            d.DISPOSABLE_NAME = dname;
                            d.QUANTITY = qty;

                            var res = await context.SaveChangesAsync();

                            if (res == 1)
                            {
                                MessageBox.Show(
                                    "\t!! Disposable Record Updated Successfully !!\n\n"
                                        + "\t      Disposable Id = "
                                        + d.DISPOSABLE_ID
                                        + "\n"
                                        + "\t      Disposable Name = "
                                        + d.DISPOSABLE_NAME
                                        + "\n"
                                        + "\t      Quantity = "
                                        + d.QUANTITY
                                        + "\n"
                                );
                            }
                            else
                            {
                                MessageBox.Show(
                                    "\t\t!! Database Error !!\n"
                                        + "\t!! Disposable Update Operation Failed !!"
                                );
                                Console.WriteLine("res = " + res);
                            }
                        }
                        LoadDefaultTblDisposables();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "                !! Please Input Valid Details !!\n"
                            + "\n1. Item Name must not be Empty\n"
                            + "\n2. Quantity cannot be less than 0\n",
                        "Form Error"
                    );
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private async void BtnDisposableDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int row = TblDisposables.SelectedRows[0].Index;

                int did = Convert.ToInt32(TblDisposables[0, row].Value);
                string dname = (string)TblDisposables[1, row].Value;

                int qty = Convert.ToInt32(TblDisposables[2, row].Value);

                DialogResult result = MessageBox.Show(
                    "!! Do You want to Delete the Following Record !!\n"
                        + "\n\tDisposable Id    = "
                        + did
                        + "\n\tDisposable Name    = "
                        + dname
                        + "\n\tQuantity = "
                        + qty,
                    "Confirmation Box",
                    MessageBoxButtons.YesNo
                );

                if (result == DialogResult.Yes)
                {
                    using (var context = new sampledbEntities())
                    {
                        DISPOSABLE d = context.DISPOSABLES.Find(did);

                        context.DISPOSABLES.Remove(d);
                        var res = await context.SaveChangesAsync();

                        if (res == 1)
                        {
                            MessageBox.Show("Disposable Record Deleted Successfully !!");

                            LoadDefaultTblDisposables();
                        }
                        else
                        {
                            MessageBox.Show(
                                    "\t\t!! Database Error !!\n"
                                        + "\t!! Disposable Delete Operation Failed !!"
                                );
                            Console.WriteLine("res = " + res);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private void BtnDisposableSearch_Click(object sender, EventArgs e)
        {
            try
            {
                TblDisposables.Rows.Clear();

                string did = TxtDisposableId.Text.Trim().ToUpper();
                string dname = TxtDisposableName.Text.Trim().ToUpper();

                string sql =
                    "SELECT * FROM DISPOSABLES WHERE DISPOSABLE_ID LIKE '%"
                    + did
                    + "%' AND DIPOSABLE_NAME LIKE '%"
                    + dname
                    + "%'";

                string connstring =
                    "data source=.;initial catalog=sampledb; integrated security=True; MultipleActiveResultSets=True;";

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
                                row.CreateCells(TblDisposables);
                                row.Cells[0].Value = dr["DISPOSABLE_ID"];
                                row.Cells[1].Value = dr["DISPOSABLE_NAME"];
                                row.Cells[2].Value = dr["QUANTITY"];
                                TblDisposables.Rows.Add(row);
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                                "No Record To Display!",
                                "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                            TabDisposables_Reset();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private void BtnDisposableReset_Click(object sender, EventArgs e)
        {
            TabDisposables_Reset();
        }

        /**********************************************************************************************************/

        // Stationary Tab button Events

        private async void BtnStstionaryInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtStationaryName.Text.Trim().ToUpper() != "")
                {
                    MessageBox.Show(
                        " Values for Item Id is Ignored !!"
                            + "  It will be automatically Generated by Database  ",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    var sname = (string)TxtStationaryName.Text.Trim().ToUpper();
                    int qty = (int)TxtStationaryQuantity.Value;

                    DialogResult result = MessageBox.Show(
                        "Confirm the Following Details !!\n" +
                        "      Item Name = " + sname +
                        "      Quantity = " + qty,
                        "",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        using (var context = new sampledbEntities())
                        {
                            var statObj = new STATIONARY()
                            {
                                STATIONARY_NAME = sname,
                                QUANTITY = qty
                            };

                            context.STATIONARies.Add(statObj);
                            var res = await context.SaveChangesAsync();

                            MessageBox.Show(
                                "!! New Stationary Added Successfully !!\n"
                                    + "   Item Id = "
                                    + statObj.STATIONARY_ID
                                    + "\n"
                                    + "   Item Name = "
                                    + statObj.STATIONARY_NAME
                                    + "\n"
                                    + "   Quantity = "
                                    + statObj.QUANTITY
                                    + "\n"
                            );
                        }

                        LoadDefaultTblStationary();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "                !! Please Input Valid Details !!\n"
                            + "\n1. Stationary Item Name must not be empty\n",
                        "Form Error"
                    );
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private async void BtnStstionaryUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtStationaryName.Text.Trim().ToUpper() != "" && TxtStationaryQuantity.Value >= 0)
                {
                    MessageBox.Show(
                        "Value for Item Name and Quantity will be updated for Selected Item Id in the Table !!"
                    );

                    int row = TblStationary.SelectedRows[0].Index;

                    int sid = Convert.ToInt32(TblStationary[0, row].Value);
                    int qty = (int)TxtStationaryQuantity.Value;

                    string sname = TxtStationaryName.Text.Trim().ToUpper();

                    DialogResult result = MessageBox.Show(
                        "\t!! Confirm the Following Details !!\n"
                            + "\n\t     Disposable Id    = "
                            + sid
                            + "\n\t     Disposable Name  = "
                            + sname
                            + "\n\t     Quantity = "
                            + qty,
                        "Confirmation Box",
                        MessageBoxButtons.YesNo
                    );

                    if (result == DialogResult.Yes)
                    {
                        using (var context = new sampledbEntities())
                        {
                            STATIONARY s = context.STATIONARies.Find(sid);

                            s.STATIONARY_NAME = sname;
                            s.QUANTITY = qty;

                            var res = await context.SaveChangesAsync();

                            if (res == 1)
                            {
                                MessageBox.Show(
                                    "\t!! Stationary Record Updated Successfully !!\n\n"
                                        + "\t      Stationary Id = "
                                        + s.STATIONARY_ID
                                        + "\n"
                                        + "\t      Stationary Name = "
                                        + s.STATIONARY_NAME
                                        + "\n"
                                        + "\t      Quantity = "
                                        + s.QUANTITY
                                        + "\n"
                                );
                            }
                            else
                            {
                                MessageBox.Show(
                                    "\t\t!! Database Error !!\n"
                                        + "\t!! Stationary Update Operation Failed !!"
                                );
                                Console.WriteLine("res = " + res);
                            }
                        }
                        LoadDefaultTblStationary();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "                !! Please Input Valid Details !!\n"
                            + "\n1. Item Name must not be Empty\n"
                            + "\n2. Quantity cannot be less than 0\n",
                        "Form Error"
                    );
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private async void BtnStstionaryDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int row = TblStationary.SelectedRows[0].Index;

                int sid = Convert.ToInt32(TblStationary[0, row].Value);
                string sname = (string)TblStationary[1, row].Value;

                int qty = Convert.ToInt32(TblStationary[2, row].Value);

                DialogResult result = MessageBox.Show(
                    "!! Do You want to Delete the Following Record !!\n"
                        + "\n\tStationary Id    = "
                        + sid
                        + "\n\tStationary Name    = "
                        + sname
                        + "\n\tQuantity = "
                        + qty,
                    "Confirmation Box",
                    MessageBoxButtons.YesNo
                );

                if (result == DialogResult.Yes)
                {
                    using (var context = new sampledbEntities())
                    {
                        STATIONARY s = context.STATIONARies.Find(sid);

                        context.STATIONARies.Remove(s);
                        var res = await context.SaveChangesAsync();

                        if (res == 1)
                        {
                            MessageBox.Show("Stationary Record Deleted Successfully !!");

                            LoadDefaultTblStationary();
                        }
                        else
                        {
                            MessageBox.Show(
                                    "\t\t!! Database Error !!\n"
                                        + "\t!! Stationary Delete Operation Failed !!"
                                );
                            Console.WriteLine("res = " + res);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private void BtnStstionarySearch_Click(object sender, EventArgs e)
        {
            try
            {
                TblStationary.Rows.Clear();

                string sid = TxtStationaryId.Text.Trim().ToUpper();
                string sname = TxtStationaryName.Text.Trim().ToUpper();

                string sql =
                    "SELECT * FROM STATIONARY WHERE STATIONARY_ID LIKE '%"
                    + sid
                    + "%' AND STATIONARY_NAME LIKE '%"
                    + sname
                    + "%'";

                string connstring =
                    "data source=.;initial catalog=sampledb; integrated security=True; MultipleActiveResultSets=True;";

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
                                row.CreateCells(TblStationary);
                                row.Cells[0].Value = dr["STATIONARY_ID"];
                                row.Cells[1].Value = dr["STATIONARY_NAME"];
                                row.Cells[2].Value = dr["QUANTITY"];
                                TblStationary.Rows.Add(row);
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                                "No Record To Display!",
                                "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                            TabStationary_Reset();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private void BtnStstionaryReset_Click(object sender, EventArgs e)
        {
            TabStationary_Reset();
        }

        /**********************************************************************************************************/

        // Miscellaneous Tab button Events

        private async void BtnMiscellaneousInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtMiscellaneousName.Text.Trim().ToUpper() != "")
                {
                    MessageBox.Show(
                        " Values for Item Id is Ignored !!"
                            + "  It will be automatically Generated by Database  ",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    var mname = (string)TxtMiscellaneousName.Text.Trim().ToUpper();
                    int qty = (int)TxtMiscellaneousQuantity.Value;

                    DialogResult result = MessageBox.Show(
                        "Confirm the Following Details !!\n" +
                        "      Item Name = " + mname +
                        "      Quantity = " + qty,
                        "",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        using (var context = new sampledbEntities())
                        {
                            var miscObj = new MISCELLANEOU()
                            {
                                MISCELLANEOUS_NAME = mname,
                                QUANTITY = qty
                            };

                            context.MISCELLANEOUS.Add(miscObj);
                            var res = await context.SaveChangesAsync();

                            MessageBox.Show(
                                "!! New Miscellaneous Added Successfully !!\n"
                                    + "   Item Id = "
                                    + miscObj.MISCELLANEOUS_ID
                                    + "\n"
                                    + "   Item Name = "
                                    + miscObj.MISCELLANEOUS_NAME
                                    + "\n"
                                    + "   Quantity = "
                                    + miscObj.QUANTITY
                                    + "\n"
                            );
                        }

                        LoadDefaultTblMiscellaneous();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "                !! Please Input Valid Details !!\n"
                            + "\n1. Miscellaneous Item Name must not be empty\n",
                        "Form Error"
                    );
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private async void BtnMiscellaneousUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtMiscellaneousName.Text.Trim().ToUpper() != "" && TxtMiscellaneousQuantity.Value >= 0)
                {
                    MessageBox.Show(
                        "Value for Item Name and Quantity will be updated for Selected Item Id in the Table !!"
                    );

                    int row = TblMiscellaneous.SelectedRows[0].Index;

                    int mid = Convert.ToInt32(TblMiscellaneous[0, row].Value);
                    int qty = (int)TxtMiscellaneousQuantity.Value;

                    string mname = TxtMiscellaneousName.Text.Trim().ToUpper();

                    DialogResult result = MessageBox.Show(
                        "\t!! Confirm the Following Details !!\n"
                            + "\n\t     Miscellaneous Id    = "
                            + mid
                            + "\n\t     Miscellaneous Name  = "
                            + mname
                            + "\n\t     Quantity = "
                            + qty,
                        "Confirmation Box",
                        MessageBoxButtons.YesNo
                    );

                    if (result == DialogResult.Yes)
                    {
                        using (var context = new sampledbEntities())
                        {
                            MISCELLANEOU m = context.MISCELLANEOUS.Find(mid);

                            m.MISCELLANEOUS_NAME = mname;
                            m.QUANTITY = qty;

                            var res = await context.SaveChangesAsync();

                            if (res == 1)
                            {
                                MessageBox.Show(
                                    "\t!! Miscellaneous Record Updated Successfully !!\n\n"
                                        + "\t      Miscellaneous Id = "
                                        + m.MISCELLANEOUS_ID
                                        + "\n"
                                        + "\t      Miscellaneous Name = "
                                        + m.MISCELLANEOUS_NAME
                                        + "\n"
                                        + "\t      Quantity = "
                                        + m.QUANTITY
                                        + "\n"
                                );
                            }
                            else
                            {
                                MessageBox.Show(
                                    "\t\t!! Database Error !!\n"
                                        + "\t!! Miscellaneous Update Operation Failed !!"
                                );
                                Console.WriteLine("res = " + res);
                            }
                        }
                        LoadDefaultTblStationary();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "                !! Please Input Valid Details !!\n"
                            + "\n1. Item Name must not be Empty\n"
                            + "\n2. Quantity cannot be less than 0\n",
                        "Form Error"
                    );
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private async void BtnMiscellaneousDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int row = TblMiscellaneous.SelectedRows[0].Index;

                int mid = Convert.ToInt32(TblMiscellaneous[0, row].Value);
                string mname = (string)TblMiscellaneous[1, row].Value;

                int qty = Convert.ToInt32(TblMiscellaneous[2, row].Value);

                DialogResult result = MessageBox.Show(
                    "!! Do You want to Delete the Following Record !!\n"
                        + "\n\tMiscellaneous Id    = "
                        + mid
                        + "\n\tMiscellaneous Name    = "
                        + mname
                        + "\n\tQuantity = "
                        + qty,
                    "Confirmation Box",
                    MessageBoxButtons.YesNo
                );

                if (result == DialogResult.Yes)
                {
                    using (var context = new sampledbEntities())
                    {
                        MISCELLANEOU m = context.MISCELLANEOUS.Find(mid);

                        context.MISCELLANEOUS.Remove(m);
                        var res = await context.SaveChangesAsync();

                        if (res == 1)
                        {
                            MessageBox.Show("Miscellaneous Record Deleted Successfully !!");

                            LoadDefaultTblMiscellaneous();
                        }
                        else
                        {
                            MessageBox.Show(
                                    "\t\t!! Database Error !!\n"
                                        + "\t!! Miscellaneous Delete Operation Failed !!"
                                );
                            Console.WriteLine("res = " + res);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private void BtnMiscellaneousSearch_Click(object sender, EventArgs e)
        {
            try
            {
                TblMiscellaneous.Rows.Clear();

                string mid = TxtMiscellaneousId.Text.Trim().ToUpper();
                string mname = TxtMiscellaneousName.Text.Trim().ToUpper();

                string sql =
                    "SELECT * FROM MISCELLANEOUS WHERE MISCELLANEOUS_ID LIKE '%"
                    + mid
                    + "%' AND MISCELLANEOUS_NAME LIKE '%"
                    + mname
                    + "%'";

                string connstring =
                    "data source=.;initial catalog=sampledb; integrated security=True; MultipleActiveResultSets=True;";

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
                                row.CreateCells(TblMiscellaneous);
                                row.Cells[0].Value = dr["MISCELLANEOUS_ID"];
                                row.Cells[1].Value = dr["MISCELLANEOUS_NAME"];
                                row.Cells[2].Value = dr["QUANTITY"];
                                TblMiscellaneous.Rows.Add(row);
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                                "No Record To Display!",
                                "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                            TabDisposables_Reset();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private void BtnMiscellaneousReset_Click(object sender, EventArgs e)
        {
            TabMiscellaneous_Reset();
        }

        /**********************************************************************************************************/

        // / DataGridView Cell Mouse Double Click Events

        private void TblMedicines_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int row = e.RowIndex;

                if (row >= 0)
                {
                    TxtMedicineId.Text = Convert.ToString(TblMedicines[0, row].Value);
                    TxtMedicineName.Text = Convert.ToString(TblMedicines[1, row].Value);
                    TxtMedicineQuantity.Value = Convert.ToInt32(TblMedicines[2, row].Value);
                }

            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private void TblDisposables_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int row = e.RowIndex;

                if (row >= 0)
                {
                    TxtDisposableId.Text = Convert.ToString(TblDisposables[0, row].Value);
                    TxtDisposableName.Text = Convert.ToString(TblDisposables[1, row].Value);
                    TxtDisposableQuantity.Value = Convert.ToInt32(TblDisposables[2, row].Value);
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private void TblStationary_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int row = e.RowIndex;

                if (row >= 0)
                {
                    TxtStationaryId.Text = Convert.ToString(TblStationary[0, row].Value);
                    TxtStationaryName.Text = Convert.ToString(TblStationary[1, row].Value);
                    TxtStationaryQuantity.Value = Convert.ToInt32(TblStationary[2, row].Value);
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private void TblMiscellaneous_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int row = e.RowIndex;

                if (row >= 0)
                {
                    TxtMiscellaneousId.Text = Convert.ToString(TblMiscellaneous[0, row].Value);
                    TxtMiscellaneousName.Text = Convert.ToString(TblMiscellaneous[1, row].Value);
                    TxtMiscellaneousQuantity.Value = Convert.ToInt32(TblMiscellaneous[2, row].Value);
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }

        /**********************************************************************************************************/

        private void TxtDisposableId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(TxtDisposableId.Text, "[^0-9]") && TxtDisposableId.Text != "")
                {
                    MessageBox.Show("Enter only Numbers !!");
                    TxtDisposableId.Text = TxtDisposableId.Text.Remove(TxtDisposableId.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private void TxtDisposableName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtStationaryId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(TxtStationaryId.Text, "[^0-9]") && TxtStationaryId.Text != "")
                {
                    MessageBox.Show("Enter only Numbers !!");
                    TxtStationaryId.Text = TxtStationaryId.Text.Remove(TxtStationaryId.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private void TxtStationaryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMiscellaneousId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(TxtMiscellaneousId.Text, "[^0-9]") && TxtMiscellaneousId.Text != "")
                {
                    MessageBox.Show("Enter only Numbers !!");
                    TxtMiscellaneousId.Text = TxtMiscellaneousId.Text.Remove(TxtMiscellaneousId.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                ex = ex.GetBaseException();

                MessageBox.Show("!!Error!!\n" + "Operation Failed\nMessage : " + ex.Message);
            }
        }
        private void TxtMiscellaneousName_TextChanged(object sender, EventArgs e)
        {

        }

        /**********************************************************************************************************/

        private void TblMedicinesPrintAsExcel_Click(object sender, EventArgs e)
        {
            PrintToExcel(TblMedicines);
        }
        private void TblMedicinesPrintAsPDF_Click(object sender, EventArgs e)
        {
            PrintToPDF(TblMedicines);
        }

        private void TblDisposablesPrintAsExcel_Click(object sender, EventArgs e)
        {
            PrintToExcel(TblDisposables);
        }
        private void TblDisposablesPrintAsPDF_Click(object sender, EventArgs e)
        {
            PrintToPDF(TblDisposables);
        }

        private void TblStationaryPrintAsExcel_Click(object sender, EventArgs e)
        {
            PrintToExcel(TblStationary);
        }
        private void TblStationaryPrintAsPDF_Click(object sender, EventArgs e)
        {
            PrintToPDF(TblStationary);
        }

        private void TblMiscellaneousPrintAsExcel_Click(object sender, EventArgs e)
        {
            PrintToExcel(TblMiscellaneous);
        }
        private void TblMiscellaneousPrintAsPDF_Click(object sender, EventArgs e)
        {
            PrintToPDF(TblMiscellaneous);
        }

        private void InventoryLogsTab_Enter(object sender, EventArgs e)
        {

            LoadDefaultTblInventoryLogs();

        }

    }
}
