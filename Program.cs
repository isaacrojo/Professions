using System;

namespace Professions
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Animal(); tipo variable, nombre variable, y nueva clase tipo pato
            Profession uno = new Profession("Ruben", "Najera", "Policeman");
            uno.Say();
            Profession dos = new Profession("Jorge", "Najera", "Astronaut"); 
            dos.Say();          
            Profession tres = new Profession("Lourdes", "Najera", "Housewife");
            tres.Say();

            
           

        }

    }
}