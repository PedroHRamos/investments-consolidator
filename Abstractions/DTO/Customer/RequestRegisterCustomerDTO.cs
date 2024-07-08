namespace InvestmentsConsolidator.DTO.Customer
{
    public class RequestRegisterCustomerDTO
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
