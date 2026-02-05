using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Request;

namespace Domain.Interfaces;

public interface IAccountService
{
    Task<BaseResponse<string>> VerifyUserAsync(string email, string password); 
    Task<BaseResponse> RegisterUserAsync(RegisterUserRequest request);
}

