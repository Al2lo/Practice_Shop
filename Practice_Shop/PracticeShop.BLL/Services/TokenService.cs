using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PracticeShop.BLL.Configuration;
using PracticeShop.BLL.Services.Interfaces;
using PracticeShop.DAL.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PracticeShop.BLL.Services
{
    public class TokenService : ITokenService
    {
        private readonly JwtOptions _options;

        public TokenService(IOptions<JwtOptions> options)
        {
            _options = options.Value;
        }
        public string GenerateToken(User user)
        {
            Claim[] claims = [new("userId", user.Id.ToString())];

            var siginngCredentials = new SigningCredentials(
               new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_options.SecretKeyAccess)),
               SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _options.Issuer,
                audience: _options.Audience,   
                claims:claims,
                signingCredentials:siginngCredentials,
                expires: DateTime.UtcNow.AddMinutes(30));

            var tokenValue = new JwtSecurityTokenHandler().WriteToken(token);

            return tokenValue;
        }
        
    }
}
