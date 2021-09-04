using System.Collections.Generic;

namespace Product.Repository
{
    public static class FakeRepo
    {
        public static List<ProductEntity> GetProducts()
        {
            return new List<ProductEntity>
            {
                new ProductEntity(){ Id=1, Name="Pencil", UnitPrice=20 },
                new ProductEntity(){ Id=2, Name="Bag", UnitPrice=40 },
                new ProductEntity(){ Id=3, Name="Book", UnitPrice=15 },
                new ProductEntity(){ Id=4, Name="Mouse", UnitPrice=90 },
            };
        }
        
    }
}