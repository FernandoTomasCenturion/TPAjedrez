using System;
using System.Collections.Generic;
using System.Text;

namespace TPAjedrez
{
    public class Peon: PiezaAjedrez
    {
        public Peon()
        {
        }

        virtual public new void Mover()
        {
            Console.WriteLine("El Peon se mueve un lugar");
        }

    }
}
