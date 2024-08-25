using PRG282_Milestone2_Project.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282_Milestone2_Project.PresentationLayer;
using System.Drawing;
using System.IO;

namespace PRG282_Milestone2_Project.DataLayer
{
    internal class User_FileHandler
    {
        string filePath = @"C:\Users\Nicole N.T Mavunda\Downloads\tHEaPP\Login.txt";


        public void SignUpUser(string UserName, string Password)
        {
            User_Manager manage = new User_Manager(filePath);
            manage.SaveUser(UserName, Password);

        }
        public void LoginUserValidation(string UserName, string Password)
        {
            User_Manager manage = new User_Manager(filePath);
            User user = new User();
            manage.GetUser(UserName, Password);
        }
    }
}
