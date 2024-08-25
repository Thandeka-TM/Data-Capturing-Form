using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Milestone2_Project.BusinessLogicLayer
{
    internal class Module
    {
        private string code, name, description, resources;

        public Module()
        {
            /*
            code = "LPR281";
            name = "Linear Programming";
            description = "Linear Programming module for second years.";
            resources = "www.youtube/moduleslearning/linearprogramming.com";*/
        }

        public Module(string code, string name, string description, string resources)
        {
            this.Code = code;
            this.Name = name;
            this.Description = description;
            this.Resources = resources;
        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Resources { get => resources; set => resources = value; }
        
        
        public override string ToString()
        {
            return $"Module Code:{Code}\nModule Name:{Name}\nModule Description:{Description}\nOnline Resources:{Resources}";
        }
    }
}
