using GerenciadorDeTarefas.Models;
using GerenciadorDeTarefas.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Controllers
{
    [Authorize] //todos os metodos dessa classe serão privados - authorizacao pelo token - precisa passar o token senao nao funciona
    public class BaseController : ControllerBase
    {
        protected readonly IUsuarioRepository _usuarioRepository;

        public BaseController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        protected Usuario ReadToken()
        {   //pegar o ID do usuario que foi criado na TokenService - ou seja fazer a pesquisa do token
            var idUsuarioString = User.Claims.Where(c => c.Type == ClaimTypes.Sid).Select(u => u.Value).FirstOrDefault();

            if (!string.IsNullOrEmpty(idUsuarioString))
            {
                var usuario = _usuarioRepository.GetById(int.Parse(idUsuarioString));
                return usuario;
            }

            throw new UnauthorizedAccessException("Token não informado ou inválido");
        }
    }
}
//a estrategia do authorize é que todos serao privados assim tendo apenas a necessidade de colocar qual será publico