namespace Kuma.Services
{
    public class AddressSelectedEventArgs
    {
        public Adresse Adresse { get; }

        public AddressSelectedEventArgs(Adresse adresse)
        {
            Adresse = adresse;
        }
    }
}
