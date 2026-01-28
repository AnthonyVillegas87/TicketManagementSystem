using Domain.DTO.Response;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Request;
using Infrastructure.Common;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Services;

public class AccountService : IAccountService
{
    private readonly SignInManager<User> _signInManager;

    public AccountService(SignInManager<User> signInManager)
    {
        _signInManager = signInManager;
    }
    
    
    public async Task<BaseResponse<string>> VerifyUserAsync(string email, string password)
    {
        BaseResponse<string> response = new();
        var user = await _signInManager.UserManager.FindByEmailAsync(email);

        if (user == null)
        {

            response.IsSuccess = false;
            response.ErrorMessage = "User not found";
                return response;
        }

        var result = await _signInManager.UserManager.CheckPasswordAsync(user, password);
        response.IsSuccess = result;

        if (!result)
        {
            response.ErrorMessage = "Invalid password / email";
        }
        else
        {
            response.Value = user.UserName;
        }

        return response;
    }

    public async Task<BaseResponse> RegisterUserAsync(RegisterUserRequest request)
    {
        User user = new User
        {
            UserName = request.Email,
            Email = request.Email,
            AccountConfirmed = false
        };
        
        const string password = Constants.DefaultPassword;

        var result = await _signInManager.UserManager.CreateAsync(user, password);
        return new BaseResponse
        {
            IsSuccess = result.Succeeded
        };

    }
}