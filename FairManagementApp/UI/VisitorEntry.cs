using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementApp.BLL;
using FairManagementApp.Model;

namespace FairManagementApp
{
    public partial class VisitorEntry : Form
    {
        public VisitorEntry()
        {
            InitializeComponent();
        }
         VisitorManager manager = new VisitorManager();
        private void saveButton_Click(object sender, EventArgs e)
        {
            string visitorName = nameTextBox.Text;
            string VisitorEmail = emailTextBox.Text;
            int contactNumber = Convert.ToInt32(contactTextBox.Text);
            Visitor aVisitor = new Visitor();

            aVisitor.Name = visitorName;
            aVisitor.Email = VisitorEmail;
            aVisitor.ContactNumber = contactNumber;
            bool IsSaved = manager.Save(aVisitor);

            if (IsSaved)
            {
                MessageBox.Show("All Information Saved Successfully");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }
        }
    }
}
