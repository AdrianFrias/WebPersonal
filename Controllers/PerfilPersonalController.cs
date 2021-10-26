using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebPersonal.NewFolder
{
    [Route("api/[controller]")]
    //Para que el controlador sea una API hay que poner lo de abajo, un atributo de la clase
    [ApiController]
    public class PerfilPersonalController : ControllerBase
    {
        //Leer datos de una API
        // que metodo http va a tener
        //[HttpGet]
        //Tenemos que llamar la funcion get
        //[HttpGet("LeerPerfil/{id}")]
        public string Get(int id)
        {
            //Codigo para leer de la base de datos
            return id switch
            {
                1 => "AdrianFrias",
                2 => "Curso",
                 _=> throw new NotSupportedException("el id no es valido")
            };
        }
        [HttpPost]
        public string Post(PerfilPersonalDto perfilPersonal)
        {
            //Guardar perfil en la base de datos.
            return perfilPersonal.Nombre;
        }
        public class PerfilPersonalDto
        {
            public string Nombre { get; set; } 
            public string Apellido { get; set; } 
        }
    }
}
