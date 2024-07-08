using InvestmentsConsolidator.DTO.Customer;

namespace InvestmentsConsolidator.UseCases
{
    public class RegistercustomerUseCase : IRegisterCustomerUseCase
    {

        public Task<bool> RegisterCustomerAsync(RequestRegisterCustomerDTO customer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateRegisterHash(RequestRegisterCustomerDTO customer)
        {
            //concat email + salt + password -> use some hash or crypt algorithym and save this hash on database
            throw new NotImplementedException();
        }

        public Task<bool> ValidateLoginHash(RequestRegisterCustomerDTO customer)
        {
            //get salt on db, concat email + salt + password -> use some hash or crypt algorithym and compare with hash on database
            throw new NotImplementedException();
        }
    }
}
