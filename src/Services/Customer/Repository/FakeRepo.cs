using System.Collections.Generic;

namespace Customer.Repository
{
    public static class FakeRepo
    {
        public static List<CustomerEntity> GetCustomers()
        {
            return new List<CustomerEntity>
            {
                new CustomerEntity(){ Id=1, Name="John", Email="john@mail.com" },
                new CustomerEntity(){ Id=2, Name="Fatma", Email="fatma@mail.com" },
                new CustomerEntity(){ Id=3, Name="Rose", Email="rose@mail.com" },
                new CustomerEntity(){ Id=4, Name="Ahmet", Email="ahmet@mail.com" },
            };
        }
        
    }
}