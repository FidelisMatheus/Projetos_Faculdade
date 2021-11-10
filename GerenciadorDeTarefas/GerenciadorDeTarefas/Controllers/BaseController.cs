using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Controllers
{
    [Authorize] //todos os metodos dessa classe serão privados - authorizacao pelo token - precisa passar o token senao nao funciona
    public class BaseController : ControllerBase
    {
    }
}
//a estrategia do authorize é que todos serao privados assim tendo apenas a necessidade de colocar qual será publico