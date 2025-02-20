using Kuma.Models;

namespace Kuma.Services
{
    public class CustomerTourManager
    {
        private List<CustomerTour> customerTours = new List<CustomerTour>();

        public void AddCustomerTour(AddressData customer, TourData tour)
        {
            customerTours.Add(new CustomerTour(customer, tour));
        }

        public void AddFileToCustomerTour(AddressData customer, TourData tour, string fileName, string category)
        {
            var customerTour = customerTours.Find(ct => ct.Customer == customer && ct.TourData == tour);
            if (customerTour != null)
            {
                customerTour.AddFile(fileName, category);
            }
        }

        public void PrintAllCustomerTours()
        {
            foreach (var customerTour in customerTours)
            {
                Console.WriteLine(customerTour);
            }
        }
    }
}
