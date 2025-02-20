using Kuma.Models;

namespace Kuma.Services
{
    public class AddressSelectedEventArgs
    {
        public AddressData AddressData { get; }

        public AddressSelectedEventArgs(AddressData addressData)
        {
            AddressData = addressData;
        }
    }
}
