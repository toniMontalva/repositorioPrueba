using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder
{
    class PizzaOrder
    {
        private static int reference = 0;
        private int id;
        private string nombreCliente;
        private string direccionPedido;
        private string[] tipoMasa = { "thin", "thick", "thick filled with cheese" };
        private string[] tipoSalsa = { "tomato", "cheese" };
        private string[] toppings = { "ham", "four cheese", "pineapple", "basil",
            "pork", "salami", "pepper", "mushrooms", "chicken" };

        public PizzaOrder(int id, string nombre, string direccion,
            string tipoM, string tipoS, string[] toppings)
        {
            this.id = id;
            nombreCliente = nombre;
            direccionPedido = direccion;
            bool masaCorrecta = false;
            for(int i=0; i < tipoMasa.Length - 1; i++)
            {
                if (tipoMasa[i].Equals(tipoM.ToLower()))
                {
                    masaCorrecta = true;

                }
            }
            if (!masaCorrecta)
            {
                Console.Write("Masa incorrecta");
            }
            tipoMasa = tipoM;
        }
        static void Main(string[] args)
        {
        }
    }
}
