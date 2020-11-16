using System;

namespace BilleteraClip
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona objetoPersona = new Persona("Maximo", "Iglesias");
            objetoPersona.Apellido = "Rojas";
            Console.WriteLine(objetoPersona.ToString());

            Persona objetoPersona2 = new Persona();
            objetoPersona2.Apellido = "Iglesias";
            objetoPersona2.Nombre = "Maximiliano";
            Console.WriteLine(objetoPersona2.ToString());
        }
    }
}
