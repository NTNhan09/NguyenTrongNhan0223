using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model.Folder;
using System.Data;
using System.Configuration;

namespace DAL.Folder
{
    public class CustomDAL : DBConnection
    {
        public List<CustomBEL> ReadEmployee()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Employee_0223", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<CustomBEL> Istcus = new List<CustomBEL>();
            EmploDAL are = new EmploDAL();
            while (reader.Read())
            {
                CustomBEL cus = new CustomBEL();
                cus.IdE = int.Parse(reader["IdEmployee"].ToString());
                cus.Name = reader["Name"].ToString();
                cus.Db = DateTime.Parse(reader["DateBirth"].ToString());
                cus.Gd = bool.Parse(reader["Gender"].ToString());
                cus.Pb = reader["PlaceBirth"].ToString();
                cus.IdD = reader["IdDepartment"].ToString();
                Istcus.Add(cus);

            }
            conn.Close();
            return Istcus;
        }
        public void NewEmployee(CustomBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Employee_0223 values(@IdEmployee,@Name,@DateBirth,@Gender,@PlaceBirth,@IdDepartment)", conn);
            cmd.Parameters.Add(new SqlParameter("@IdEmployee", cus.IdE));
            cmd.Parameters.Add(new SqlParameter("@Name", cus.Name));
            cmd.Parameters.Add(new SqlParameter("@DateBirth", cus.Db));
            cmd.Parameters.Add(new SqlParameter("@Gender", cus.Gd));
            cmd.Parameters.Add(new SqlParameter("@PlaceBirth", cus.Pb));
            cmd.Parameters.Add(new SqlParameter("@IdDepartment", cus.IdD));
            cmd.ExecuteNonQuery();
            conn.Close();


        }


        public void EditEmployee(CustomBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Employee_0223 set Name = @name, Db = @DateBirth, Gd = @Gender, Pb = @PlaceBirth, IdD = @IdDepartment where IdE = @IdEmployee", conn);
            cmd.Parameters.Add(new SqlParameter("@IdEmployee", cus.IdE));
            cmd.Parameters.Add(new SqlParameter("@Name", cus.Name));
            cmd.Parameters.Add(new SqlParameter("@DateBirth", cus.Db));
            cmd.Parameters.Add(new SqlParameter("@Gender", cus.Gd));
            cmd.Parameters.Add(new SqlParameter("@PlaceBirth", cus.Pb));
            cmd.Parameters.Add(new SqlParameter("@IdDepartment", cus.IdD));
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void DeleteEmployee(CustomBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete Employee_0223 where IdE = @IdEmployee", conn);
            cmd.Parameters.Add(new SqlParameter("@IdEmployee", cus.IdE));
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
