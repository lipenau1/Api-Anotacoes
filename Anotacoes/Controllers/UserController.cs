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
    }
}
