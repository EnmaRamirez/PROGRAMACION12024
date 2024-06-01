using CreacionBotones.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionBotones.Datos
{
    public class Usuario
    {
        List<Modelo.UsuarioModel> lista = new List<Modelo.UsuarioModel>();
        //sumar
        //Guardar los usuarios
        //</sumary>
        //<param name="modelo">datos del usuario</param>

        public void Guardar(Modelo.UsuarioModel modelo) {
            lista.Add(modelo);
        }
        //sumar
        //consulta todos los usuarios
        //</sumar>
        //<returns> datos de usuarios<returns>
        public List<Modelo.UsuarioModel> Consultar()
        {
            return lista;
        }

       
    }
}
