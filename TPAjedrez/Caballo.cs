using System;
using System.Collections.Generic;
using System.Text;

namespace TPAjedrez
{
    public class Caballo : PiezaAjedrez
    {
        public Caballo()
        {
        }

        virtual public new void Mover()
        {
            Console.WriteLine("El Caballo se mueve un lugar");
        }
    }
}
