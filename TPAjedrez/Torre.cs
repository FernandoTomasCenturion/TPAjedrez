using System;
using System.Collections.Generic;
using System.Text;

namespace TPAjedrez
{
    public class Torre: PiezaAjedrez
    {
        public Torre()
        {
        }


        virtual public new void Mover()
        {
            Console.WriteLine("La torre se mueve a la derecha");
        }

    }
}
