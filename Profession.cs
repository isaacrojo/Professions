using System;

namespace Professions
{
     class Profession
    {
         string name;     

         string lastName;

         string profession;

        public Profession (string name, string lastName, string profession){
            this.name = name;
            this.lastName = lastName;
            this.profession = profession;
        }
        public void Say (){
            Console.WriteLine("Hi my name is "+this.name+" "+this.lastName+" and I am a "+this.profession);

        }
        }

             

    
    }
