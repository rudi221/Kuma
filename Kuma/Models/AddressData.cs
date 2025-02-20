namespace Kuma.Models
{
    public class AddressData
    {
        public string Titel { get; set; }
        public string Company { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        public AddressData(string titel, string company, string firstname, string lastname, string email)
        {
            Titel = titel;
            Company = company;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Company},{Titel} ,{Firstname} {Lastname} {Email} ";
        }
    }
}
