namespace Services.Dto
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IM { get; set; }
        public int IE { get; set; }
        public string CNPJ { get; set; }
        public AddressDto Address {get; set;}
        public ContactDto Contact {get; set;}
    }

}