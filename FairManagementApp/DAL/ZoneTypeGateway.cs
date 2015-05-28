using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.Model;

namespace FairManagementApp.DAL
{
   public class ZoneTypeGateway
   {
       private string connString = ConfigurationManager.ConnectionStrings["FMS"].ConnectionString;

       public int InsertZoneType(ZoneType aZoneType)
       {
           SqlConnection connection = new SqlConnection(connString);
           string query = "Insert Into tblZoneType values('" + aZoneType.Zonetype + "')";
           SqlCommand command = new SqlCommand(query, connection);
           connection.Open();
           int rowAffected = command.ExecuteNonQuery();
           connection.Close();
           return rowAffected;

         }
       public  List<ZoneType>GetAllZoneTypes()
       {
           SqlConnection connection = new SqlConnection(connString);
           string query = "Select * from tblZoneType";
           SqlCommand command = new SqlCommand(query,connection);
           connection.Open();
           SqlDataReader reader = command.ExecuteReader();
           List<ZoneType>zoneTypes = new List<ZoneType>();
           
               while (reader.Read())
               {
                   ZoneType aZoneType = new ZoneType();
                   aZoneType.ZoneId = int.Parse(reader["ZoneId"].ToString());
                   aZoneType.Zonetype = reader["Zonetype"].ToString();
                   zoneTypes.Add(aZoneType);

               }
               reader.Close();
               connection.Close();
               return zoneTypes;
           }

       public ZoneType GetZoneType(string zoneTypeName)
       {
           SqlConnection connection = new SqlConnection(connString);
           string query = "Select * from tblZoneType where ZoneType= '" + zoneTypeName + "'";
           SqlCommand command = new SqlCommand(query, connection);
           connection.Open();
           SqlDataReader reader = command.ExecuteReader();
           ZoneType anZoneType = null;

           while (reader.Read())
           {
               if (anZoneType == null)
               {
                   anZoneType = new ZoneType();
               }
               anZoneType.Zonetype = reader["ZoneType"].ToString();
           }
           reader.Close();
           connection.Close();
           return anZoneType;
       }
   }
}
