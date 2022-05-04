namespace Services.Dto
{
    public class AddressDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IM { get; set; }
        public int IE { get; set; }
        public int CNPJ { get; set; }
        public AddressDto Address {get; set;}
        public ContactDto Contact {get; set;}
    }

}