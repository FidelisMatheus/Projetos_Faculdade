using GerenciadorDeTarefas.Dtos;
using GerenciadorDeTarefas.Models;
using GerenciadorDeTarefas.Repository;
using GerenciadorDeTarefas.Services;
using GerenciadorDeTarefas.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //separar as rotas da api das rotas de site - api/-recurso para tratar deixar tudo junto !_!
    public class LoginController : BaseController
    {
        //atributos privados costumam ter _ na frente - <> (generico) pois precisamos apenas do loginController
        private readonly ILogger<LoginController> _logger;
        private readonly IUsuarioRepository _usuarioRepository;

        //da para a api a função das depencies injection - somente no ponto que necessite realizar as dependencias
        public LoginController(ILogger<LoginController> logger, IUsuarioRepository usuarioRepository)
        {
            _logger = logger;
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost] //precisamos aqui receber do Body o que precisamos consultar no banco - Usuario e Senha
        [AllowAnonymous] //anotacao publica
        public IActionResult EfetuarLogin([FromBody] LoginRequisicaoDto requisicao)
        {
            try
            {   //como é string precisamos verificar se a senha é nula ou vazia - assim ja dará erro ao logar
                if (requisicao == null
                    || string.IsNullOrEmpty(requisicao.Login) || string.IsNullOrWhiteSpace(requisicao.Login)
                    || string.IsNullOrEmpty(requisicao.Senha) || string.IsNullOrWhiteSpace(requisicao.Senha))
                {
                    return BadRequest(new ErroRespostaDto() //erro usuario
                    {
                        Status = StatusCodes.Status400BadRequest,
                        Erro = "Parâmetros de entrada inválidos"
                    });
                }

                var usuario = _usuarioRepository.GetUsuarioByLoginSenha(requisicao.Login, MD5Utils.GerarHashMD5(requisicao.Senha));

                if(usuario == null)
                {
                    return BadRequest(new ErroRespostaDto() //erro usuario
                    {
                        Status = StatusCodes.Status400BadRequest,
                        Erro = "Parâmetros de entrada inválidos"
                    });
                }

                var token = TokenService.CriarToken(usuario); //como criar um novo token

                return Ok(new LoginRespostaDto()
                {
                    Email = usuario.Email,
                    Nome = usuario.Nome,
                    Token = token
                }); //certo
            }
            catch(Exception excecao)
            {
                //jogar no log para testar :D
                //_logger.LogError($"Ocorreu erro ao efetuar login", excecao, requisicao);

                _logger.LogError($"Ocorreu erro ao efetuar login: login = {excecao.Message}", excecao); //erro 500 - erro de server
                return StatusCode(StatusCodes.Status500InternalServerError, new ErroRespostaDto() //erro servidor
                {
                    Status = StatusCodes.Status500InternalServerError,
                    Erro = "Ocorreu erro ao efetuar login, tente novamente!"
                });
            }
        }

    }
}
