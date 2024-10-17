using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class UsuarioController : ApiController
    {
        // GET api/<controller>
        // listar todos los usuarios
        public List<Usuario> Get()
        {
            return UsuarioData.Listar();
        }
        // GET api/<controller>/5
        // listar un usuario en particular
        public Usuario Get(int id)
        {
            return UsuarioData.Obtener(id);
        }
        // POST api/<controller>
        // registrar un usuario
        public bool Post([FromBody] Usuario oUsuario)
        {
            return UsuarioData.Registrar(oUsuario);
        }
        // PUT api/<controller>/5
        // editar un usuario
        public bool Put([FromBody] Usuario oUsuario)
        {
            return UsuarioData.Modificar(oUsuario);
        }
        // DELETE api/<controller>/5
        // eliminar un usuario
        public bool Delete(int id)
        {
            return UsuarioData.Eliminar(id);
        }
    }
}