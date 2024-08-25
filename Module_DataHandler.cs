using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Milestone2_Project.BusinessLogicLayer;

namespace PRG282_Milestone2_Project.DataLayer
{
    internal class Module_DataHandler
    {
        string connect = @"Server = LAPTOP-E4N060AG\SQLEXPRESS; Initial Catalog = BelgiumCampusDatabase; Integrated Security = SSPI ";

        public void InsertModule(string Code, string Name, string Description, string Resources)
        {
            using (SqlConnection con = new SqlConnection(connect))
            {
                SqlCommand cmd = new SqlCommand("spAddModule", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@moduleCode", Code);
                cmd.Parameters.AddWithValue("@moduleName", Name);
                cmd.Parameters.AddWithValue("@moduleDescription", Description);
                cmd.Parameters.AddWithValue("@moduleResourceLink", Resources);

                con.Open();
                cmd.ExecuteNonQuery();
            }

        }
        public void UpdateModule(string Code, string Name, string Description, string Resources)
        {
            using (SqlConnection con = new SqlConnection(connect))
            {
                SqlCommand cmd = new SqlCommand("spUpdateModule", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@moduleCode", Code);
                cmd.Parameters.AddWithValue("@moduleName", Name);
                cmd.Parameters.AddWithValue("@moduleDescription", Description);
                cmd.Parameters.AddWithValue("@moduleResourceLink", Resources);

                con.Open();
                cmd.ExecuteNonQuery();
            }


        }
        public void DeleteModule(string Code)
        {
            using (SqlConnection con = new SqlConnection(connect))
            {
                SqlCommand cmd = new SqlCommand("spDeleteModule", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@moduleCode", Code);

                con.Open();

                cmd.ExecuteNonQuery();
            }
        }
        public DataTable GetModule()
        {
            SqlConnection con = new SqlConnection(connect);
            SqlDataAdapter adapter = new SqlDataAdapter("spGetModule", connect);

            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable SearchModule(string Code)
        {
            using (SqlConnection con = new SqlConnection(connect))
            {
                SqlCommand cmd = new SqlCommand("spSearchModule", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@moduleCode", Code);
                con.Open();
                DataTable table = new DataTable();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    table.Load(reader);
                    return table;
                }


            }
        }
    }
}
