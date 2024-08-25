using PRG282_Milestone2_Project.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Net;

namespace PRG282_Milestone2_Project.DataLayer
{
    internal class Student_DataHandler
    {
        string connect = @"Server = LAPTOP-E4N060AG\SQLEXPRESS; Initial Catalog = BelgiumCampusDatabase; Integrated Security = SSPI ";
        
        
        DataTable table;


        public void InsertStudentData(int Number, string Name, string Surname, string Image, string DOB, string Gender, string Phone, string Address, string StudentModuleCode)
        {
            using (SqlConnection con = new SqlConnection(connect))
            {
                SqlCommand cmd = new SqlCommand("spAddStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@studentNumber", Number);
                cmd.Parameters.AddWithValue("@studentName", Name);
                cmd.Parameters.AddWithValue("@studentSurname", Surname);
                cmd.Parameters.AddWithValue("@studentImage", Image );
                cmd.Parameters.AddWithValue("@studentDOB", DOB);
                cmd.Parameters.AddWithValue("@gender", Gender);
                cmd.Parameters.AddWithValue("@phone", Phone);
                cmd.Parameters.AddWithValue("@studentAddress", Address);
                cmd.Parameters.AddWithValue("@studentModuleCodes", StudentModuleCode);

                con.Open();
                cmd.ExecuteNonQuery();
            }

        }
        public void UpdateStudentData(int Number, string Name, string Surname, string Image, string DOB, string Gender, string Phone, string Address, string StudentModuleCode)
        {
            using (SqlConnection con = new SqlConnection(connect))
            {
                SqlCommand cmd = new SqlCommand("spUpdateStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@studentNumber", Number);
                cmd.Parameters.AddWithValue("@studentName", Name);
                cmd.Parameters.AddWithValue("@studentSurname", Surname);
                cmd.Parameters.AddWithValue("@studentImage", Image);
                cmd.Parameters.AddWithValue("@studentDOB", DOB);
                cmd.Parameters.AddWithValue("@gender", Gender);
                cmd.Parameters.AddWithValue("@phone", Phone);
                cmd.Parameters.AddWithValue("@studentAddress", Address);
                cmd.Parameters.AddWithValue("@studentModuleCodes", StudentModuleCode);

                con.Open();
                cmd.ExecuteNonQuery();
            }


        }
        public void DeleteStudentData(int Number)
        {
            using (SqlConnection con = new SqlConnection(connect))
            {
                SqlCommand cmd = new SqlCommand("spDeleteStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@studentNumber", Number);

                con.Open();

                cmd.ExecuteNonQuery();
            }
        }
        public DataTable GetStudentData()
        {
            SqlConnection con = new SqlConnection(connect);
            SqlDataAdapter adapter = new SqlDataAdapter("spGetStudents", connect);

            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable SearchStudent(int Number)
        {
            using (SqlConnection con = new SqlConnection(connect))
            {
                SqlCommand cmd = new SqlCommand("spSearchStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@studentNumber", Number);
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
