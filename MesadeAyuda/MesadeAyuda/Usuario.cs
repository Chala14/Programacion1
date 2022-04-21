using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesadeAyuda
{
    public class Usuario: Persona /*Herencia*/
    {
        private int Id;
        public string NombreUsuario;
        private string Password;
        public bool EsActivo;
        public Persona Persona;
        public Rol Rol;

        public Usuario(Persona persona):base(persona) /*Herencia*/
        { 
        }

        public CrearUsuario()/*Método*/
        { 
        }

        public ConsultarUsuario()/*Método*/
        {
        }

        public ActualizarUsuario()/*Método*/
        {
        }

        public VerificarPassword()/*Método*/
        {
        }
    }
}
