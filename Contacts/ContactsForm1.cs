using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class ContactsForm1 : Form
    {
        List<Contact> contacts = new List<Contact>();
        public ContactsForm1()
        {
            InitializeComponent();
        }

        private void ContactsForm1_Load(object sender, EventArgs e)
        {
            fileReader();
        }

        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayDetails();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fileWriter();
            refresh();
        }

        public void refresh()
        {
            // Add this for the weather app of the POE
            txtName.Clear();
            txtSurname.Clear();
            txtCell.Clear();
            txtEmail.Clear();

            lstContacts.Items.Clear();
            foreach (Contact contact in contacts)
            {
                lstContacts.Items.Add(contact.Name + " " + contact.Surname);
            }
        }

        public void fileWriter()
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string cellphone = txtCell.Text;
            string email = txtEmail.Text;

            Contact newContact = new Contact(name, surname, cellphone, email);
            contacts.Add(newContact);

            try
            {
                // the two ways of writing to a textfile. One is commented out.
                StreamWriter sw = new StreamWriter("Contacts.txt", true);
                sw.WriteLine(newContact.Name + "," + newContact.Surname + "," + newContact.CellPhone + "," + newContact.Email);

                //foreach (Contact c in contacts)
                //{
                //    sw.WriteLine(c.Name+","+ c.Surname + "," + c.CellPhone + "," + c.Email);
                //}
                sw.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        public void fileReader()
        {
            // Implement this in the POE recomendations 
            contacts.Clear();
            string line;

            try
            {
                StreamReader file = new StreamReader("Contacts.txt");
                while ((line = file.ReadLine()) != null)
                {
                    // Can use -- var lineParts
                    string[] lineParts = line.Split(',');
                    Contact temp = new Contact(lineParts[0], lineParts[1], lineParts[2], lineParts[3]);
                    contacts.Add(temp);
                }
                file.Close();

            }
            catch (FileNotFoundException)
            {
                StreamReader sw = new StreamReader("Contacts.txt");
                sw.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            lstContacts.Items.Clear();
            foreach (Contact contact in contacts)
            {
                lstContacts.Items.Add(contact.Name + " " + contact.Surname);
            }

        }

        public void displayDetails()
        {
            string selectedName = lstContacts.SelectedItem.ToString();
            Contact selectedContact = new Contact();
            foreach (Contact contact in contacts)
            {
                if ((contact.Name + " " + contact.Surname).Equals(selectedName))
                {
                    selectedContact = contact;
                    break;
                }
            }

            List<string> contactInfo = new List<string>();
            contactInfo.Add("Details");
            contactInfo.Add("---------------------------------------------");
            contactInfo.Add("Name : " + selectedContact.Name);
            contactInfo.Add("Surame : " + selectedContact.Surname);
            contactInfo.Add("Cell : " + selectedContact.CellPhone);
            contactInfo.Add("Email : " + selectedContact.Email);

            txtContact.Lines = contactInfo.ToArray<string>();
            
        }
    }
}
