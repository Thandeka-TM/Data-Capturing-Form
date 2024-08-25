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
using PRG282_Milestone2_Project.DataLayer;
using PRG282_Milestone2_Project.PresentationLayer;

namespace PRG282_Milestone2_Project.PresentationLayer
{
    public partial class CaptureStudent : Form
    {
        public CaptureStudent()
        {
            InitializeComponent();
        }

        private void CaptureStudent_Load(object sender, EventArgs e)
        {
           
        }


        Student_DataHandler handler = new Student_DataHandler();        


        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.SearchStudent(int.Parse(txtStudNumSearch.Text));
            MessageBox.Show("Data Searched!");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.GetStudentData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            handler.InsertStudentData(int.Parse(txtStudNumber.Text), txtStudName.Text, txtStudSurname.Text, txtStudImage.Text, txtStudDOB.Text, txtStudGender.Text, txtStudPhone.Text, txtStudAddress.Text, txtStudModCodes.Text);
            MessageBox.Show("Data added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            handler.UpdateStudentData(int.Parse(txtStudNumber.Text), txtStudName.Text, txtStudSurname.Text, txtStudImage.Text, txtStudDOB.Text, txtStudGender.Text, txtStudPhone.Text, txtStudAddress.Text, txtStudModCodes.Text);
            MessageBox.Show("Data updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            handler.DeleteStudentData(int.Parse(txtStudNumber.Text));
            MessageBox.Show("Data Deleted!");
        }

        private void btnCaptureModule_Click(object sender, EventArgs e)
        {
            CaptureModule cm = new CaptureModule();
            cm.ShowDialog();
            cm.Hide();
            
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CaptureModule_Load(object sender, EventArgs e)
        {
           
        }
    }
}
