using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAnimales
{
    public abstract class Animal
    {
        public int Edad { get; }
        public int Altura { get; }
        public int Peso { get; }


        public Animal()
        {

        }
        public virtual void ImprimirEdad()
        {
            Console.WriteLine(Edad.ToString());
        }
        public virtual void ImprimirAltura()
        {
            Console.WriteLine(Altura.ToString());
        }

        public virtual void ImprimirPeso()
        {
            Console.WriteLine(Peso.ToString());
        }

        public virtual void ComerAlimento()
        {
            Console.WriteLine("El animal come 100 gramos de alimento");
        }


    }

}
