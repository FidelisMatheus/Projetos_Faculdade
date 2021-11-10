using GerenciadorDeTarefas.Dtos;
using GerenciadorDeTarefas.Models;
using GerenciadorDeTarefas.Services;
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

        //Usuário Mockado
        private readonly string loginTeste = "admin@admin.com";
        private readonly string senhaTeste = "Admin1234@";

        //da para a api a função das depencies injection - somente no ponto que necessite realizar as dependencias
        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpPost] //precisamos aqui receber do Body o que precisamos consultar no banco - Usuario e Senha
        [AllowAnonymous] //anotacao publica
        public IActionResult EfetuarLogin([FromBody] LoginRequisicaoDto requisicao)
        {
            try
            {   //como é string precisamos verificar se a senha é nula ou vazia - assim ja dará erro ao logar
                if (requisicao == null
                    || string.IsNullOrEmpty(requisicao.Login) || string.IsNullOrWhiteSpace(requisicao.Login)
                    || string.IsNullOrEmpty(requisicao.Senha) || string.IsNullOrWhiteSpace(requisicao.Senha)
                    || requisicao.Login != loginTeste || requisicao.Senha != senhaTeste)
                {
                    return BadRequest(new ErroRespostaDto() //erro usuario
                    {
                        Status = StatusCodes.Status400BadRequest,
                        Erro = "Parâmetros de entrada inválidos"
                    });
                }

                var usuarioTeste = new Usuario()
                {
                    Id = 1,
                    Nome = "Usuário de Teste",
                    Email = loginTeste,
                    Senha = senhaTeste
                };

                var token = TokenService.CriarToken(usuarioTeste); //como criar um novo token

                return Ok(new LoginRespostaDto()
                {
                    Email = usuarioTeste.Email,
                    Nome = usuarioTeste.Nome,
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
