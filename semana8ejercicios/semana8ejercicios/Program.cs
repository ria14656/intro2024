using System;

// Definición de la interfaz INotificable
interface INotificable
{
    void Notifica(string mensaje);
}

//añadir Notificacion gmail
class NotificacionEmail : INotificable
{
    public string DireccionCorreo { get; }

    public NotificacionEmail(string direccionCorreo)
    {
        DireccionCorreo = direccionCorreo;
    }

    public void Notifica(string mensaje)
    {
        Console.WriteLine($"Enviando correo a {DireccionCorreo}: {mensaje}");
    }
}

// añadir Notificacion en Whatsapp
class NotificacionWhatsapp : INotificable
{
    public string NumeroTelefono { get; }

    public NotificacionWhatsapp(string numeroTelefono)
    {
        NumeroTelefono = numeroTelefono;
    }

    public void Notifica(string mensaje)
    {
        Console.WriteLine($"Enviando mensaje de WhatsApp al numero {NumeroTelefono}: {mensaje}");
    }
}

// añadir Notificacion a SMS
class NotificacionSMS : INotificable
{
    public string NumeroTelefono { get; }

    public NotificacionSMS(string numeroTelefono)
    {
        NumeroTelefono = numeroTelefono;
    }

    public void Notifica(string mensaje)
    {
        Console.WriteLine($"Enviando SMS a número {NumeroTelefono}: {mensaje}");
    }
}

class Program
{
    static void Main()
    {
        // Crear instancias de cada implementación
        var emailNotification = new NotificacionEmail(direccionCorreo: "inge@correo.com");
        var whatsappNotification = new NotificacionWhatsapp(numeroTelefono: "58302525");
        var smsNotification = new NotificacionSMS(numeroTelefono: "58309696");

        // Probar métodos de notificación
        emailNotification.Notifica("¡Hola desde GMAIL!");
        whatsappNotification.Notifica("¡Hola desde WhatsApp!");
        smsNotification.Notifica("¡Hola desde SMS!");
    }
}