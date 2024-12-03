using PhoneBook.DataAccess;
using PhoneBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhoneBook.Controller
{
    public class ContactController
    {

        public BusinessLogicLayer bll;

        public ContactController()
        {
            this.bll = new BusinessLogicLayer();
        }

        public void AddContact()
        {
            reName:
            Console.WriteLine("PLease enter your name:");
            string name = Console.ReadLine()??"";


            if (name != null) {

                Console.WriteLine("PLease enter your surname:");
                string surname = Console.ReadLine()??"";

                rePhone:
                Console.WriteLine("PLease enter your phone:");
                string phone = Console.ReadLine()??"";
                string phonePattern = @"^\+994\d{9}$";



                if (phone != null && Regex.IsMatch(phone, phonePattern)) {


                reEmail:
                    Console.WriteLine("PLease enter your Email:");
                    string email = Console.ReadLine()??"";
                    string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                    if (Regex.IsMatch(email, emailPattern))
                    {


                        Contact contact = new Contact(name, surname, phone, email);
                        try
                        {
                            this.bll.CheckContact(contact);
                        }
                        catch (Exception exp)
                        {
                            Console.WriteLine(exp.Message
                                );
                        }
                        Console.WriteLine("Contact successfully added !");
                        Console.ReadLine();

                    }

                    else
                    {
                        Console.WriteLine("please enter correct form: ");
                        goto reEmail;
                    }
                }

                else
                {

                    Console.WriteLine("enter phone number!!");
                    goto rePhone;
                }

            }

            else
            {
                Console.WriteLine("You can not pass name empty!");
                goto reName;
            }
      

        }
       
        public void GetAllContact()
        {
          List<Contact> contacts = bll.GetContactList();

            foreach (Contact contact in contacts)
            {
                Console.WriteLine($"Id: {contact.Id}");
                Console.WriteLine($"Name: {contact.Name}");
                Console.WriteLine($"Surname: {contact.Surname}");
                Console.WriteLine($"Phone: {contact.Phone}");
                Console.WriteLine($"Email: {contact.Email}");

            }



        }

        public void UpdateContactName(string newvalue, int id)
        {
            bll.UpdateName(newvalue, id);

        }

        public void UpdateContactPhone(string newvalue, int id)
        {
            bll.UpdatePhone(newvalue, id);
        }

        public void DeleteContact(int id)
        {
            bll.DeleteContact(id);
        }
    }
}
