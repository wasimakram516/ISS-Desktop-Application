using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    class clsDeletion
    {
        public static void Delete(object ID, string procedure, string parameter)
        {
            try
            {
                SqlCommand com = new SqlCommand(procedure, MainClass.con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue(parameter, ID);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg("Data deleted successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }
    }
}
