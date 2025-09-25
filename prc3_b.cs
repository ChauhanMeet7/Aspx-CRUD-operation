using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Configuration;
using System.Data;

// Replace with your actual namespace

    /// <summary>
    /// Business logic class for managing student master data.
    /// </summary>
    public class prc3_b
    {
        // Private backing fields
        private Int64 sid;
        private string sname;
        private string scity;
        private readonly SqlConnection con; // Declare SqlConnection field

        // Constructor to initialize database connection
        public prc3_b()
        {
    Configuration CONF = WebConfigurationManager.OpenWebConfiguration("~/");
    ConnectionStringSettingsCollection CONSC = CONF.ConnectionStrings.ConnectionStrings;
    con = new SqlConnection(CONSC["Data Source=DESKTOP-QLOEDOJ\\SQLEXPRESS;Initial Catalog=PRACTICE;Integrated Security=True"].ConnectionString);

        }

        // Public properties with different names from backing fields
        public Int64 M_sid
        {
            get { return sid; }
            set { sid = value; }
        }

        public string M_sname
        {
            get { return sname; }
            set { sname = value; }
        }

        public string M_scity
        {
            get { return scity; }
            set { scity = value; }
        }

        // Method to add a new student record using stored procedure
        public void prc3_add()
        {
            try
            {
                con.Open();
                SqlParameter[] par = {
                    
                    new SqlParameter("@sname", M_sname),
                    new SqlParameter("@scity", M_scity),
                    new SqlParameter("@sid",M_sid)
                };

                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Connection = con,
                    CommandText = "prac3add"
                };

                foreach (SqlParameter p in par)
                {
                    cmd.Parameters.Add(p);
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions (log or throw as needed)
                throw new Exception("Error adding student record: " + ex.Message);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
        public DataSet prc3_fetch()
{
    con.Open();
    DataSet ds = new DataSet();
    SqlDataAdapter da = new SqlDataAdapter("", con);
    SqlParameter[] par = {
        new SqlParameter("@sid", M_sid)
    };
    SqlCommand cmd = new SqlCommand();
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Connection = con;
    cmd.CommandText = "prac3fetch";
    foreach (SqlParameter p in par)
    {
        cmd.Parameters.Add(p);
    }
    da.SelectCommand = cmd;
    da.Fill(ds);
    con.Close();
    return ds;
}
        public void prc3update()
{
    con.Open();
    SqlParameter[] par = {
        new SqlParameter("@sid", M_sid),
        new SqlParameter("@sname", M_sname),
        new SqlParameter("@scity", M_scity),  // Assuming @city parameter
    };
    SqlCommand cmd = new SqlCommand();
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Connection = con;
    cmd.CommandText = "prac3edit";
    foreach (SqlParameter p in par)
    {
        cmd.Parameters.Add(p);
    }
    cmd.ExecuteNonQuery();
    con.Close();
}
        public void prc3delete()
{
    con.Open();
    SqlParameter[] par = {
        new SqlParameter("@sid", M_sid)
    };
    SqlCommand cmd = new SqlCommand();
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Connection = con;
    cmd.CommandText = "prac3delete";
    foreach (SqlParameter p in par)
    {
        cmd.Parameters.Add(p);
    }
    cmd.ExecuteNonQuery();
    con.Close();
}
    }
