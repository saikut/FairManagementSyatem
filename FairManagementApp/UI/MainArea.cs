using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementApp.UI;

namespace FairManagementApp
{
    public partial class MainArea : Form
    {
        public MainArea()
        {
            InitializeComponent();
        }

        private void visitorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorEntry visitorEntry = new VisitorEntry();
            visitorEntry.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zoneTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeEntry zoneTypeEntry = new ZoneTypeEntry();
            zoneTypeEntry.Show();
        }

        private void zoneSpeceficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneSpeceficVisitorDetails zoneSpeceficVisitorDetails = new ZoneSpeceficVisitorDetails();
            zoneSpeceficVisitorDetails.Show();
        }

        private void zoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeWiseVisitorNumber zoneTypeWiseVisitorNumber = new ZoneTypeWiseVisitorNumber();
            zoneTypeWiseVisitorNumber.Show();
        }

       
    }
}
