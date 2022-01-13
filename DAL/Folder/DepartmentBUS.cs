using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model.Folder;


namespace DAL.Folder
{
    public class EmploDAL : DBConnection
    {
        public List<EmploBEL> ReadEmployeeList()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select *from Employee_0223", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<EmploBEL> IstArea = new List<EmploBEL>();
            while (reader.Read())
            {
                EmploBEL Em = new EmploBEL();

                Em.IdE = int.Parse(reader["IdEmployee"].ToString());
                Em.Name = reader["Name"].ToString();
                Em.Db = DateTime.Parse(reader["DateBirth"].ToString());
                Em.Gd = bool.Parse(reader["Gender"].ToString());
                Em.Pb = reader["PlaceBirth"].ToString();
                IstArea.Add(Em);
            }
            conn.Close();
            return IstArea;
        }
        public EmploBEL ReadDepartment(int id)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select *from Department_0223 where id=" + id.ToString(), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            EmploBEL Em = new EmploBEL();
            if (reader.HasRows && reader.Read())
            {
                Em.IdD = reader["IdDepartment"].ToString();
                Em.Name = reader["Name"].ToString();
            }
            conn.Close();
            return Em;
        }
    }
}
