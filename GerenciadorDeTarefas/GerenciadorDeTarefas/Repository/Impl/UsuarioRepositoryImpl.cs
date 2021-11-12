using GerenciadorDeTarefas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Repository.Impl
{
    public class UsuarioRepositoryImpl : IUsuarioRepository
    {
        //aqui precisamos do contexto para poder acessar o banco de dados

        private readonly GerenciadorDeTarefasContext _contexto;
        public UsuarioRepositoryImpl(GerenciadorDeTarefasContext contexto)
        {
            _contexto = contexto;
        }

        public bool ExisteUsuarioPeloEmail(string email)
        { //select no C# - Any alguma condiçao -  o Where devolve uma lista
            return _contexto.Usuario.Any(usuario => usuario.Email.ToLower() == email);
        }

        public Usuario GetUsuarioByLoginSenha(string login, string senha)
        {//First se nao encontra devolve excessao ja o firstOrDefault devolve NULL
            return _contexto.Usuario.FirstOrDefault(usuario => usuario.Email == login.ToLower() && usuario.Senha == senha);
        }

        public void Salvar(Usuario usuario)
        {
            _contexto.Usuario.Add(usuario);
            _contexto.SaveChanges();//commitando
        }
    }
}
