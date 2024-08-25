using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Milestone2_Project.BusinessLogicLayer
{
    internal class Student
    {
        private int number;
        private string name, surname, image, dob, gender, phone, address, studentModuleCode;

        public Student()
        {
            /*
            number = 0009;
            name = "Shawn";
            surname = "Martin";
            image = "shawnmartin.png";
            dob = "2003-10-26";
            gender = "Male";
            phone = "222-445-7884";
            address = "68 Peperbloom str, Orchards, Pretoria";
            studentModuleCode = "LPR281, IOT281, MAT281, PRG282";*/
        }

        public Student(int number, string name, string surname, string image, string dob, string gender, string phone, string address, string studentModuleCode)
        {
            this.Number = number;
            this.Name = name;
            this.Surname = surname;
            this.Image = image;
            this.DOB = dob;
            this.Gender = gender;
            this.Phone = phone;
            this.Address = address;
            this.StudentModuleCode = studentModuleCode;
        }

        public int Number { get => number; set => number = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Image { get => image; set => image = value; }
        public string DOB { get => dob; set => dob = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string StudentModuleCode { get => studentModuleCode; set => studentModuleCode = value; }

        public override string ToString()
        {
            return $"Student Number:{Number}\nFullName{Name}{Surname}\nStudent Image:{Image}\nDate of Birth:{DOB}\nGender:{Gender}\nPhone:{Phone}\nAddress:{Address}";
        }
    }
}
