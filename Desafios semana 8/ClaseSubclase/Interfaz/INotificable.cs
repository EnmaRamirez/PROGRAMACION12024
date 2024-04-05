using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    public interface INotificable
    {
        void Notifica();
    }
    class NotificacionEmail : INotificable
    {
        private string direccionCorreo;
        public NotificacionEmail(string direccionCorreo)
        {
            this.direccionCorreo = direccionCorreo;
        }
        public void Notifica()
        {
            //Codigo para el envio del correo
            Console.WriteLine($"Enviar correo a: {direccionCorreo}");
        }

    }
    class NotificacionWhatsapp : INotificable
    {
        private string numeroTelefono;
        public NotificacionWhatsapp(string numeroTelefono)
        {
            this.numeroTelefono = numeroTelefono;
        }
        public void Notifica()
        {
            //Codigo para enviar numero de whatsapp
            Console.WriteLine($"Enviando mensaje al whatsapp con el numero: {numeroTelefono}");

        }
    }
    class NotificacionSMS : INotificable
    {
        private string numeroTelefono;

        public NotificacionSMS(string numeroTelefono)
        {
            this.numeroTelefono = numeroTelefono;
        }
        public void Notifica()
        {
            // Codigo para el envio de SMS
            Console.WriteLine($"Enviando el SMS al numero: {numeroTelefono}");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            NotificacionEmail email = new NotificacionEmail("eramirezc38@miumg.edu.gt");
            NotificacionWhatsapp whatsapp = new NotificacionWhatsapp("+50257494773");
            NotificacionSMS SMS = new NotificacionSMS("+50247700567");

            email.Notifica();
            whatsapp.Notifica();
            SMS.Notifica();
        }
    }
        

}
