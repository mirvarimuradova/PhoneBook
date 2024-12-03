using PhoneBook.Controller;
using static System.Collections.Specialized.BitVector32;

ContactController contactController = new ContactController();


reSection:
Console.WriteLine("Choose the section:" +
    "1.Add Contact \n" +
    "2.Update Contact \n" +
    "3.Show All Contacts \n" +
    "4.Remove Contact \n");

var section = Console.ReadLine() ?? "";

int a; 

bool check = int.TryParse(section, out a);


if (check)
{

   a = Convert.ToInt32(section);

    if (a == 1)
    {

        contactController.AddContact();
    }

    else if (a == 2)
    {
    
        contactController.GetAllContact();
        reId:
        Console.WriteLine("Enter the contact's id ");
    
       var contactid = Console.ReadLine();

        int b;

        bool checkid = int.TryParse(contactid, out b);


        if (checkid)
        {

            int ID = Convert.ToInt32(contactid);
            reproperty:
            Console.WriteLine("Which property do you want to change?" +
                "1.Name" +
                "2.Phone");


            var propertynum = Console.ReadLine();
            int c;

            bool checkContactProperty = int.TryParse(propertynum, out c);

            if (checkContactProperty)
            {
            
                c = Convert.ToInt32(propertynum);
                if (c == 1)
                {
                    Console.WriteLine("Please enter new name: ");
                    string newname = Console.ReadLine() ?? "";
                    contactController.UpdateContactName(newname, ID);
                }
                else if (c == 2)
                {
                
                    Console.WriteLine("Please enter new phone number: ");
                    string newphone = Console.ReadLine() ?? "";
                    contactController.UpdateContactName(newphone, ID);
                }
                else
                {
                    Console.WriteLine("Wrong value");
                    goto reproperty;
                }
            }
            else
            {
                Console.WriteLine("wrong value!");

                goto reproperty;
            }
    }
        else
        {
            Console.WriteLine("ID's format is not correct!");

            goto reId;
        }
    }

    else if (a == 3)
    {
        Console.WriteLine("Contacts");
        contactController.GetAllContact();
    }

    else if (a == 4) { 

        Console.WriteLine("Which contact do you want to remove? please enter his id.");
        contactController.GetAllContact();

        var contactid = Console.ReadLine();

        int b;

        bool checkid = int.TryParse(contactid, out b);
        if (checkid) { 
        
            int contactID= Convert.ToInt32(contactid);
            contactController.DeleteContact(contactID);
        
        }


    }

    else
    {

        Console.WriteLine("wrong value!");
        goto reSection;
    }
}
else
{
    Console.WriteLine("Value is not true !");

    goto reSection;
}

