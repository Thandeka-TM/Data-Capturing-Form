using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PRG282_Milestone2_Project.PresentationLayer;
using System.Drawing;


namespace PRG282_Milestone2_Project.BusinessLogicLayer
{
    internal class User_Manager
    {
        string filePath = @"Login.txt";
        User user = new User();

        public User_Manager(string filePath)
        {
            this.filePath = filePath;

            // Create the file if it doesn't exist.
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
        }
        public void SaveUser(string UserName, string Password)
        {

            string userData = $"{UserName},{Password}";

            // Append to the file or create a new one if it doesn't exist.
            File.AppendAllLines(filePath, new[] { userData });
        }
        public void GetUser(string UserName, string Password)
        {
            // Read all lines from the file.
            string[] lines = File.ReadAllLines(filePath);

            bool found = false;

            foreach (string line in lines)
            {
                // Split the line into username and password.
                string[] parts = line.Split(',');

                // Check if the username matches.
                if (parts.Length == 2 && parts[0] == UserName)
                {
                    //return new User(parts[0], parts[1]);
                    if (parts.Length == 2 && parts[1] == Password)
                    {
                        MessageBox.Show("Login Successfull!");
                        CaptureStudent cs = new CaptureStudent();
                        cs.ShowDialog();
                        cs.Hide();
                        found = true;
                    }
                }
            }

            //validating that it has not been found
            if (!found)
            {
                MessageBox.Show("User not found");
            }

        }
    }
}
