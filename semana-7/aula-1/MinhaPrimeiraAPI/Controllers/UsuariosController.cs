using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.Models;

namespace MinhaPrimeiraAPI.Controllers
{
    [ApiController]
    [Route("usuarios")]
    public class UsuariosController
    {
        static private List<Usuario> usuarios = new List<Usuario>();

        [HttpGet]
        public List<Usuario> GetUsuario()  
        {   
            return usuarios;
        }

        [HttpGet("{id}")]
        public Usuario GetUsuarioPorId([FromRoute] int id)
        {
            Usuario resultado = null;
            foreach (var usuario in usuarios)
            {
                if(usuario.Id == id)
                {
                    resultado = usuario;
                    break;
                }
            }
            return resultado;
        }

        [HttpGet("{id}/pedidos")]
        public string GetPedidos([FromRoute] string id)
        {
            return "Você chamou o metodo obter pedidos do usuario id " + id;
        }
        [HttpPut]
        public string AtualizaUsuario()
        {
            return "Você Atualizou o Usuario";
        }
        [HttpDelete]
        public string DeletaUsuario()
        {
            return "Você Deletou o Usuario";
        }

        [HttpPost]
        public string CriarUsario([FromBody] Usuario usuario)
        {
            usuarios.Add(usuario);

            return "Você chamou o metedo criar usuario, com o nome " + usuario.Nome + " de idade " + usuario.Idade;
        }

    }

}