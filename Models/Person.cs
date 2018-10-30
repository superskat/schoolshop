using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; }

        private Person() { }

        public Person(string Name, string Email)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentException("Имя не должно быть пустым");
            }
            if (string.IsNullOrWhiteSpace(Email))
            {
                throw new ArgumentException("Email не должен быть пустым");
            }

            this.Name = Name;
            this.Email = Email;
        }
    }
}
