using System;
using System.Data.SqlClient;
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
                    row.Cells[3].Value = m.EXPIRY.ToString("dd-MM-yyyy");
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

        /**********************************************************************************************************/

        private void TabMedicines_Reset()
        {
            TxtMedicineId.Text = "";
            TxtMedicineName.Text = "";
            TxtMedicineQuantity.Text = "";
            TxtMedicineExpiryDate.Text = "";

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

        private void BtnMedicineInsert_Click(object sender, EventArgs e) { }

        private void BtnMedicineUpdate_Click(object sender, EventArgs e) { }

        private void BtnMedicineDelete_Click(object sender, EventArgs e) { }

        private void BtnMedicineSearcch_Click(object sender, EventArgs e)
        {
            TblMedicines.Rows.Clear();

            string mid = TxtMedicineId.Text.Trim().ToUpper();
            string mname = TxtMedicineName.Text.Trim().ToUpper();
            string expiry = TxtMedicineExpiryDate.Value.ToString().Trim().ToUpper();

            string sql =
                "SELECT * FROM MEDICINES WHERE MEDICINE_ID LIKE '%"
                + mid
                + "%' AND MEDICINE_NAME LIKE '%"
                + mname
                + "%' AND EXPIRY LIKE '%"
                + expiry
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
                            row.CreateCells(TblMedicines);
                            row.Cells[0].Value = dr["MEDICINE_ID"];
                            row.Cells[1].Value = dr["MEDICINE_NAME"];
                            row.Cells[2].Value = dr["QUANTITY"];
                            row.Cells[3].Value = dr["EXPIRY"];
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

        private void BtnDisposableInsert_Click(object sender, EventArgs e) { }

        private void BtnDisposableUpdate_Click(object sender, EventArgs e) { }

        private void BtnDisposableDelete_Click(object sender, EventArgs e) { }

        private void BtnDisposableSearch_Click(object sender, EventArgs e) { }

        private void BtnDisposableReset_Click(object sender, EventArgs e)
        {
            TabDisposables_Reset();
        }

        /**********************************************************************************************************/

        // Stationary Tab button Events

        private void BtnStstionaryInsert_Click(object sender, EventArgs e) { }

        private void BtnStstionaryUpdate_Click(object sender, EventArgs e) { }

        private void BtnStstionaryDelete_Click(object sender, EventArgs e) { }

        private void BtnStstionarySearch_Click(object sender, EventArgs e) { }

        private void BtnStstionaryReset_Click(object sender, EventArgs e)
        {
            TabStationary_Reset();
        }

        /**********************************************************************************************************/

        // Miscellaneous Tab button Events

        private void BtnMiscellaneousInsert_Click(object sender, EventArgs e) { }

        private void BtnMiscellaneousUpdate_Click(object sender, EventArgs e) { }

        private void BtnMiscellaneousDelete_Click(object sender, EventArgs e) { }

        private void BtnMiscellaneousSearch_Click(object sender, EventArgs e) { }

        private void BtnMiscellaneousReset_Click(object sender, EventArgs e)
        {
            TabMiscellaneous_Reset();
        }

        /**********************************************************************************************************/

    }
}
