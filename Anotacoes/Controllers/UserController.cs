using AN.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Anotacoes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            using var db = new AN.Api.Data.ApplicationContext();
            List<Usuario> usuarios = new List<Usuario>();
            foreach (var item in db.Usuarios)
            {
                usuarios.Add(item);
            }
            return JsonConvert.SerializeObject(usuarios);
        }

        [HttpGet("{id}")]

        public Usuario Get(int id)
        {
            using var db = new AN.Api.Data.ApplicationContext();
            return db.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Usuario Usuario)
        {
            if (!UsuarioExiste(Usuario.Id))
            {
                using var db = new AN.Api.Data.ApplicationContext();
                db.Usuarios.Add(Usuario);
                db.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Usuario value)
        {
            using var db = new AN.Api.Data.ApplicationContext();
            try
            {
                if (UsuarioExiste(id))
                {
                    var objUsuario = db.Usuarios.FirstOrDefault(x => x.Id == id);
                    var obj = new
                    {
                        Nome = value.Nome,
                        Email = value.Email,
                    };

                    db.Entry(objUsuario).CurrentValues.SetValues(obj);
                    db.SaveChanges();
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch
            {
                return NoContent();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (UsuarioExiste(id))
            {
                using var db = new AN.Api.Data.ApplicationContext();
                db.Usuarios.Remove(db.Usuarios.FirstOrDefault(x => x.Id == id));
                db.SaveChanges();
                return Ok();
            }
            else
            {
                return NoContent();
            }
        }

        private bool UsuarioExiste(int id)
        {
            using var db = new AN.Api.Data.ApplicationContext();
            return db.Usuarios.Any(e => e.Id == id);
        }
    }
}

