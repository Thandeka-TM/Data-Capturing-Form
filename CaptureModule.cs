using PRG282_Milestone2_Project.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PRG282_Milestone2_Project.PresentationLayer
{
    public partial class CaptureModule : Form
    {
        public CaptureModule()
        {
            InitializeComponent();
        }

        private void txtModCode_TextChanged(object sender, EventArgs e)
        {

        }

        Module_DataHandler handler = new Module_DataHandler();

        private void btnModSearch_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = handler.SearchModule(txtModCodeSearch.Text);
            MessageBox.Show("Data Searched!");
        }

        private void btnModDisplay_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = handler.GetModule();
        }

        private void btnModAdd_Click(object sender, EventArgs e)
        {
            handler.InsertModule(txtModCode.Text, txtModName.Text, txtModDescription.Text, txtModResources.Text);
            MessageBox.Show("Data Added!");
        }

        private void btnModUpdate_Click(object sender, EventArgs e)
        {
            handler.UpdateModule(txtModCode.Text, txtModName.Text, txtModDescription.Text, txtModResources.Text);
            MessageBox.Show("Data Updated!");
        }

        private void btnModDelete_Click(object sender, EventArgs e)
        {
            handler.DeleteModule(txtModCodeSearch.Text);
            MessageBox.Show("Data Deleted!");
        }

        private void CaptureModule_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCaptureStud_Click(object sender, EventArgs e)
        {            
            CaptureStudent cs = new CaptureStudent();
            cs.ShowDialog();
            cs.Hide();
            this.Close();
        }
    }
}
