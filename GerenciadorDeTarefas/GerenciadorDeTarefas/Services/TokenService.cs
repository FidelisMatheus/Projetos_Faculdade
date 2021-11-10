using GerenciadorDeTarefas.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Services
{
    public class TokenService
    {
        public static string CriarToken(Usuario usuario)
        {//handler - manipular

            var tokenHandler = new JwtSecurityTokenHandler();
            var chaveCriptografiaEmBytes = Encoding.ASCII.GetBytes(ChaveJWT.ChaveSecreta); //de string para bytes

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] //lista de clains
                {
                    new Claim(ClaimTypes.Sid, usuario.Id.ToString()),
                    new Claim(ClaimTypes.Name, usuario.Nome)
                }), //chave de segurança e chave de criptografia(algoritmo)
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(chaveCriptografiaEmBytes), SecurityAlgorithms.HmacSha256Signature)
                //Issuer - colocar expiracao do token

            };

            var token = tokenHandler.CreateToken(tokenDescriptor); //de bytes para string
            return tokenHandler.WriteToken(token);
        }
    }
}
