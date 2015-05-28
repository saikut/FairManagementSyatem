using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.DAL;
using FairManagementApp.Model;

namespace FairManagementApp.BLL
{
   public class ZoneTypeManager
    {
       ZoneTypeGateway zoneTypeGateway = new ZoneTypeGateway();

       public bool Save(ZoneType anZoneType)
       {
           return zoneTypeGateway.InsertZoneType(anZoneType) > 0;
       }

       public List<ZoneType> GateAllZoneTypes()
       {
           return zoneTypeGateway.GetAllZoneTypes();
       }

       public bool GetZoneTyepe(string azonetype)
       {
           ZoneType anZoneType = zoneTypeGateway.GetZoneType(azonetype);
           if (anZoneType!=null)
           {
               return true;
           }
           else
           {
              return false;
           }
       }
    }
}
