using GerenciadorDeTarefas.Dtos;
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
    public class LoginController : ControllerBase
    {
        //atributos privados costumam ter _ na frente - <> (generico) pois precisamos apenas do loginController
        private readonly ILogger<LoginController> _logger; 

        //da para a api a função das depencies injection - somente no ponto que necessite realizar as dependencias
        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpPost]//precisamos aqui receber do Body o que precisamos consultar no banco - Usuario e Senha
        public IActionResult EfetuarLogin([FromBody] LoginRequisicaoDto requisicao)
        {
            try
            {
                if(requisicao == null || requisicao.Login == null || requisicao.Senha == null)
                {
                    return BadRequest(new ErroRespostaDto() //erro usuario
                    {
                        Status = StatusCodes.Status400BadRequest,
                        Erro = "Parâmetros de entrada inválidos"
                    });
                }

                return Ok("Usuário authenticado com sucesso"); //certo
            }
            catch(Exception excecao)
            {
                _logger.LogError($"Ocorreu erro ao efetuar login: login = {excecao.Message}", excecao); //erro 500 - erro de server
                //jogar no log para testar :D
                //_logger.LogError($"Ocorreu erro ao efetuar login", excecao, requisicao);
                return StatusCode(StatusCodes.Status500InternalServerError, new ErroRespostaDto() //erro servidor
                {
                    Status = StatusCodes.Status500InternalServerError,
                    Erro = "Ocorreu erro ao efetuar login, tente novamente!"
                });
            }
        }

    }
}
