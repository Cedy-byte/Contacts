using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    public class Contact
    {
        private string name;
        private string surname;
        private string email;
        private string cellPhone;

        // how is the empty constructor used?
        public Contact()
        {

        }

        public Contact(string name, string surname, string email, string cellPhone)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.cellPhone = cellPhone;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public string CellPhone { get => cellPhone; set => cellPhone = value; }


    }
}
