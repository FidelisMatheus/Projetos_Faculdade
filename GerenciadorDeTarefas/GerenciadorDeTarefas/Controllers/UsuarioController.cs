using GerenciadorDeTarefas.Dtos;
using GerenciadorDeTarefas.Models;
using GerenciadorDeTarefas.Repository;
using GerenciadorDeTarefas.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : BaseController
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(ILogger<UsuarioController> logger,  IUsuarioRepository usuarioRepository)
        {
            _logger = logger;
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult SalvarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                var erros = new List<string>();//caso erro vai salvar aqui
                if(string.IsNullOrEmpty(usuario.Nome) || string.IsNullOrWhiteSpace(usuario.Nome) || usuario.Nome.Length < 2)
                {
                    erros.Add("Nome inválido");
                }

                //antiga solucao legal
                //var obrigatorios = new List<string>() { "@", "!", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                //obrigatorios.Any(e => usuario.Senha.Contains(e))

                //pelo menos 1 minusculo, 1 maiusculo e um numero - regex guia
                if (string.IsNullOrEmpty(usuario.Senha) || string.IsNullOrWhiteSpace(usuario.Senha) 
                    || usuario.Senha.Length < 4 && Regex.IsMatch(usuario.Senha, "[a-zA-Z0-9]+", RegexOptions.IgnoreCase)) 
                {
                    erros.Add("Senha Inválida");
                }

                //^serve para introduzir o regex
                Regex regex = new Regex(@"^([\w\.\-\+\d]+)@([\w\-]+)((\.(\w){2,4})+)$");
                if(string.IsNullOrEmpty(usuario.Email) || string.IsNullOrWhiteSpace(usuario.Email)
                    || !regex.Match(usuario.Email).Success)
                {
                    erros.Add("Email Inválido");
                }

                if(_usuarioRepository.ExisteUsuarioPeloEmail(usuario.Email))
                {
                    erros.Add("Já existe uma conta com o email informado");
                }

                if(erros.Count > 0)
                {
                    return BadRequest(new ErroRespostaDto()
                    {
                        Status = StatusCodes.Status400BadRequest,
                        Erros = erros
                    });
                }

                usuario.Email = usuario.Email.ToLower();
                usuario.Senha = MD5Utils.GerarHashMD5(usuario.Senha);
                _usuarioRepository.Salvar(usuario);

                return Ok(new { msg= "Usuario Criado com sucesso" });
            } 
            catch(Exception e)
            {
                _logger.LogError("Ocorreu erro ao salvar usuário", e); 
                return StatusCode(StatusCodes.Status500InternalServerError, new ErroRespostaDto() 
                {
                    Status = StatusCodes.Status500InternalServerError,
                    Erro = "Ocorreu erro ao efetuar login, tente novamente!"
                });
            }
        }
    }
}
