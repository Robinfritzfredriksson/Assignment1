using Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Services
{
    internal class MenuManager
    {

        public static Contact ContactPersonAdd() // Lägger vi till en person med dess olika funktionaliteter 

        {
            var contact = new Contact();

            try
            {
                Console.Clear();
                Console.WriteLine("***  Add Contact ***");

                Console.Write("First Name: ");
                contact.FirstName = Console.ReadLine() ?? "";

                Console.Write("Last Name: ");
                contact.LastName = Console.ReadLine() ?? "";

                Console.Write("Street address: ");
                contact.StreetAddress = Console.ReadLine() ?? "";
                
                Console.Write("Phonenumber: ");
                contact.PhoneNumber = Console.ReadLine() ?? "";

               
                return contact;
            }
            catch
            {
                Console.WriteLine("Invalid Option...");
                Console.ReadKey();
            }

            return null!;
        }

        public static void ViewContactList(List<Contact> list) // Skriver vi ut alla kontakter som vi laggt till i listan
        {
            Console.Clear();
            Console.WriteLine("***  Contact List ***");

            foreach (var contact in list)
            {
                Console.WriteLine($"{contact.Id}   {contact.FirstName}  {contact.LastName}  {contact.StreetAddress}  {contact.PhoneNumber}");
            }

            Console.ReadKey();
        }

        public static void RemoveContact(ref List<Contact> list) // Tar bort en kontakt med hjälp av personens ID 
        {
            try
            {
                Console.Clear();
                Console.WriteLine("***  Remove Contact ***");

                Console.Write("Contact Id: ");
                var id = Guid.Parse(Console.ReadLine());

                list = list.Where(x => x.Id != id).ToList();
            }
            catch
            {
                Console.WriteLine("Invalid Id selected.");
                Console.ReadKey();
            }

        }

        public static void UpdateContact(ref List<Contact> list) // Uppdaterar kontakten med hjälp av personen ID

        {
            try
            {
                Console.Clear();
                Console.WriteLine("***  Update Contact ***");

                Console.Write("Contact Id: ");
                var id = Guid.Parse(Console.ReadLine());

                var contact = list.FirstOrDefault(x => x.Id == id);

                Console.Write("Firstname: ");
                if (contact != null) ;
                contact.FirstName = Console.ReadLine();

                Console.Write("Lastname: ");
                if (contact != null) ;
                contact.LastName = Console.ReadLine();

                Console.Write("Steet address: ");
                if (contact != null) ;
                contact.StreetAddress = Console.ReadLine();

                Console.Write("Phonenumber: ");
                if (contact != null) ;
                contact.PhoneNumber = Console.ReadLine();

            }
            catch
            {
                Console.WriteLine("Invalid Id selected.");
                Console.ReadKey();
            }

        }


        public static void ViewOneContactList(List<Contact> list) // Skriver ut enbart ut en specefik kontakt med hjälp av personens ID 
        {
            Console.Clear();
            Console.WriteLine("***  View Specefic Contact  ***");

            Console.Write("Contact Id: ");
            var id = Guid.Parse(Console.ReadLine());

            foreach (var contact in list)
            {
                Console.WriteLine($"{contact.Id}   {contact.FirstName}  {contact.LastName}  {contact.StreetAddress}  {contact.PhoneNumber}");
            }

            Console.ReadKey();

        }

        public static string OptionsMenu() // här är vad som skall innehålla i våran Meny samt utseende 
        {
            Console.Clear();
            Console.WriteLine("*** Adreess-Book ***");
            Console.WriteLine("1. View Contact List");
            Console.WriteLine("2. Add Contact");
            Console.WriteLine("3. Remove Contact");
            Console.WriteLine("4. Update Contact");
            Console.WriteLine("5. View specefic Contact");
            Console.WriteLine("6. Exit Program");
            Console.Write("Chose One Option:   ");
            return Console.ReadLine() ?? "";
            var option = Console.ReadLine();
        }

    }
}
    

    

