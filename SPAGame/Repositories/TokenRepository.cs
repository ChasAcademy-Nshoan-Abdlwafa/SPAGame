﻿using Microsoft.IdentityModel.Tokens;
using SPAGame.Data;
using SPAGame.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SPAGame.Repositories
{
    public class TokenRepository : ITokenRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public TokenRepository(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        public string CreateToken(Account account)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim("id", account.AccountId.ToString()),
                new Claim("name", account.AccountName),
                new Claim("email", account.AccountEmail)
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("Appsettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}
