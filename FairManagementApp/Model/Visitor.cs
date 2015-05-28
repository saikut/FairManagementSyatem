using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairManagementApp.Model
{
    public class Visitor
    {
        private int visitorId;
        private string name;
        private string email;
        private int contactNumber;

        public int VisitorId
        {
            get { return visitorId; }
            set { visitorId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }
    }
}
