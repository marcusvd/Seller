namespace Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IM { get; set; }
        public int IE { get; set; }
        public string CNPJ { get; set; }
        public Address Address {get; set;}
        public Contact Contact {get; set;}
    }

}