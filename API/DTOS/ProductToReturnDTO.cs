namespace API.DTOS
{
    public class ProductToReturnDTO
    {
        public int Id { get; set; }
         public string Name { get; set; }

        public string Descriptiion { get; set; }

        public decimal Price { get; set; }
        public string PictureUrl { get; set; }

        public string ProductType { get; set; }
        public string ProductBrand { get; set; }

    }
}