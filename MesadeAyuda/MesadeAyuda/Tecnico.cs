using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesadeAyuda
{
    public class Tecnico:Persona /*Herencia*/
    {
        public string NombreTecnico;
        public GrupoSoporte GrupoSoporte;

        public Tecnico(Persona persona):base(persona) /*Herencia*/
        { 
        }

        public Tecnico(GrupoSoporte grupoSoporte) /*Constructor*/
        {
            this.GrupoSoporte = grupoSoporte; /*Composición*/
        }

        public CrearTecnico()/*Método*/
        {
        }

        public ConsultarTecnico()/*Método*/
        {
        }

        public ActualizarTecnico()/*Método*/
        {
        }
    }
}
