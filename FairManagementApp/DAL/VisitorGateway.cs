using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.Model;

namespace FairManagementApp.DAL
{
    
   public class VisitorGateway
   {
       private string conString = ConfigurationManager.ConnectionStrings["FMS"].ConnectionString;

       public int InsertVisitor(Visitor avVisitor)
       {
           SqlConnection connection = new SqlConnection(conString);
           string query = "Insert into tblVisitor values('" + avVisitor.Name + "', '" + avVisitor.Email + "', '" +
                          avVisitor.ContactNumber + "')";
           SqlCommand command = new SqlCommand(query, connection);
           connection.Open();
           int rowAffected = command.ExecuteNonQuery();
           connection.Close();
           return rowAffected;


       }
   }
}
