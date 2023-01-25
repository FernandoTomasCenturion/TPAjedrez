using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAnimales
{
    public class Loro: Animal
    {
        public Loro()
        {
        }

        public override void ImprimirEdad()
        {
            Console.WriteLine(Edad.ToString());
        }
        public override void ImprimirAltura()
        {
            Console.WriteLine(Altura.ToString());
        }

        public override void ImprimirPeso()
        {
            Console.WriteLine(Peso.ToString());
        }

        public override void ComerAlimento()
        {
            Console.WriteLine("El loro come 200 gramos de girasol");
        }

    }

}

