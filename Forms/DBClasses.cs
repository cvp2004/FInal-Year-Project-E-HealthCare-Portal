using System.Data.SqlClient;

namespace OPD_Section.Forms
{
    public class DBClasses
    {

        // DATA MEMBERS!
        SqlConnection connection;



        // CREATING CONNECTION!
        public void CreateConnection()
        {

            string link = "Data Source=.;Initial Catalog=Sampledb;Integrated Security=True;MultipleActiveResultSets=true";
            connection = new SqlConnection(link);
            connection.Open();
        }


        // CLOSING CONNECTION!
        public void CloseConnection()
        {
            connection.Close();
        }

        /*
                string sql = "select count(UserID) from user_login where UserID=@UserID and pwd=@pwd";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@UserID", txtUSerID.Text);
                param[1] = new SqlParameter("@pwd", txtPwd.Text);
                cmd.Parameters.Add(param[0]);
        cmd.Parameters.Add(param[1]);
        */


        // SETTING DATA
        public int setData(string query)
        {
            string link = "Data Source=.;Initial Catalog=Sampledb;Integrated Security=True;MultipleActiveResultSets=true";
            SqlConnection connection = new SqlConnection(link);
            connection.Open();
            string sql = query;
            SqlCommand cmd = new SqlCommand(sql, connection);
            int res = cmd.ExecuteNonQuery();
            return res;
        }





        // GETTING DATA!
        public SqlDataReader getData(string query)
        {
            string sql = query;
            SqlCommand cmd2 = new SqlCommand(sql, connection);
            SqlDataReader res2 = cmd2.ExecuteReader();
            return res2;
        }
    }
}
