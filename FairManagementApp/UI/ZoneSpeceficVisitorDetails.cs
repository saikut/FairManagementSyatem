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
    public partial class ZoneSpeceficVisitorDetails : Form
    {
        public ZoneSpeceficVisitorDetails()
        {
            InitializeComponent();
        }
        ZoneTypeManager azoneTypeManager = new ZoneTypeManager();
        private void ZoneSpeceficVisitorDetails_Load(object sender, EventArgs e)
        {
           this.tblVisitorTableAdapter.Fill(this.fairManagementSystemDBDataSet1.tblVisitor);
            LoadSelectZoneComboBox();
        }

        private void LoadSelectZoneComboBox()
        {
            List<ZoneType> sZoneTypes = azoneTypeManager.GateAllZoneTypes();
            SelectZoneComboBox.DataSource = null;
            SelectZoneComboBox.DisplayMember = "ZoneType";
            SelectZoneComboBox.ValueMember = "ZoneId";
            SelectZoneComboBox.DataSource = null;
            SelectZoneComboBox.DataSource = sZoneTypes;



        }
        private void showButton_Click(object sender, EventArgs e)
        {

        }

       
        private void exportToExcelButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
               
                ToCsV(zoneSpecefircVisitorDetailsDataGridView, sfd.FileName); 
            }  
        }
        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
       
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
          
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

     
         
    }
}
