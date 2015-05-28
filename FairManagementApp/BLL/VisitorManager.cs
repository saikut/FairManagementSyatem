using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.DAL;
using FairManagementApp.Model;

namespace FairManagementApp.BLL
{
    public class VisitorManager
    {
        VisitorGateway aGateway =new VisitorGateway();

        public bool Save(Visitor aVisitor)
        {
            return aGateway.InsertVisitor(aVisitor) > 0;
        }
    }
}
