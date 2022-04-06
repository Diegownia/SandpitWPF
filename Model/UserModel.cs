using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandpitWPF.Model
{
    public class UserModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        //public UserModel(int ID, string Name, string Surname, int Age)
        //{
        //    this.ID = ID;
        //    this.Name = Name;
        //    this.Surname = Surname;
        //    this.Age = Age;
        //} Leaving this here as it's the other way of making stuff


    }
}
