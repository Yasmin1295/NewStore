using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Seller
    {
        public string Name;
        public int Age;
        public Experience Experience;

        public Seller (string name, int age, Experience experience)
        {
            this.Name = name;
            this.Age = age;
            this.Experience = experience;
        }
       
     
    }
}
