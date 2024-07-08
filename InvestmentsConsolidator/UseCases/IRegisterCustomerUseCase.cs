using InvestmentsConsolidator.DTO.Customer;

namespace InvestmentsConsolidator.UseCases
{
    public interface IRegisterCustomerUseCase
    {
        Task<bool> RegisterCustomerAsync(RequestRegisterCustomerDTO customer);
        Task<bool> CreateRegisterHash(RequestRegisterCustomerDTO customer);
        Task<bool> ValidateLoginHash(RequestRegisterCustomerDTO customer);
    }
}
