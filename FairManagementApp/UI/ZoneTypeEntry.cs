using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementApp.BLL;
using FairManagementApp.Model;

namespace FairManagementApp.UI
{
    public partial class ZoneTypeEntry : Form
    {
        public ZoneTypeEntry()
        {
            InitializeComponent();
        }

        private ZoneTypeManager zoneTypeManager = new ZoneTypeManager();

        private void ZoneTypeEntry_Load(object sender, EventArgs e)
        {
            this.tblZoneTypeTableAdapter.Fill(this.fairManagementSystemDBDataSet.tblZoneType);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string nameZoneType = zoneTypeNameTextBox.Text;
            ZoneType anZoneType = new ZoneType();
            anZoneType.Zonetype = nameZoneType;
            bool isZoneTypeExist = zoneTypeManager.GetZoneTyepe(nameZoneType);
            if (isZoneTypeExist)
            {
                MessageBox.Show("Zone Type Already Exists");
            }
            else
            {
                bool IsSaved = zoneTypeManager.Save(anZoneType);
                if (IsSaved)
                {
                    MessageBox.Show("Zone Type Has been Saved Successfully");
                    zoneTypeNameTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to Save");
                }
            }
            this.tblZoneTypeTableAdapter.Fill(this.fairManagementSystemDBDataSet.tblZoneType);



        }

        
    }
}
