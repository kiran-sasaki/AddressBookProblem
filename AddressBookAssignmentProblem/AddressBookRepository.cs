using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookAssignmentProblem
{
    public class AddressBookRepository
    {
        public static string connectionString = "data source=(localdb)\\MSSQLLocalDB; initial catalog=AddressBookService; integrated security=true";
        SqlConnection sqlconnection = new SqlConnection(connectionString);
        public int GetPerson()
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    List<ContactModel> PersonList = new List<ContactModel>();
                    SqlCommand command = new SqlCommand("spGetPerson", this.sqlconnection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    this.sqlconnection.Close();
                    int count = 0;
                    foreach (DataRow dr in table.Rows)
                    {
                        PersonList.Add(new ContactModel
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            FirstName = Convert.ToString(dr["FirstName"]),
                            LastName = Convert.ToString(dr["LastName"]),
                            Address = Convert.ToString(dr["Address"]),
                            PhoneNumber = Convert.ToString(dr["PhoneNumber"]),
                            EmailAddress = Convert.ToString(dr["EmailAddress"]),
                            City = Convert.ToString(dr["City"]),
                            State = Convert.ToString(dr["State"]),
                            ZipCode = Convert.ToInt32(dr["ZipCode"])
                        });
                        count++;
                    }
                    return count;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
