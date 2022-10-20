using Assignment1.Models;
using Assignment1.Services;
using Newtonsoft.Json;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

var contact = new List<Contact>();
var filePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Contact.json"; // Vart filen vi sparar skall hamna samt namn på filen


contact = JsonConvert.DeserializeObject<List<Contact>>(FileManager.Read(filePath)); // Konventerar om till Jsonfil


do
{
    
    var option = MenuManager.OptionsMenu();

    switch (option)
    {
        case "1": // visar alla kontakter i listan som vi sparat

            MenuManager.ViewContactList(contact);
            break;

            case "2": // Lägger till en Kontakt
            
            var contacts = MenuManager.ContactPersonAdd();
            if (contact != null)
            {
                contact.Add(contacts);
                FileManager.Save(filePath, JsonConvert.SerializeObject(contact, Formatting.Indented));
            }
            break;

            case "3": // Raderar en kontakt med hjälp av ett ID

            MenuManager.RemoveContact(ref contact);
            FileManager.Save(filePath, JsonConvert.SerializeObject(contact, Formatting.Indented));
            break;

        case "4": // Uppdaterar en kontakt med hjälp av ID 

            MenuManager.UpdateContact(ref contact);
            FileManager.Save(filePath, JsonConvert.SerializeObject(contact, Formatting.Indented));
            break;

        case "5": // Visar enbart en specefik kontakt ur listan med hjälp av ID
            MenuManager.ViewOneContactList(contact);
            FileManager.Save(filePath, JsonConvert.SerializeObject(contact, Formatting.Indented));
            break;

            break;

        case "6": // Avslutar programmet
            Environment.Exit(0);
            break;



        default: // om du valt fel
            Console.WriteLine("Invalid option selected");
            Console.ReadKey();
            break;
    }
} while (true);
