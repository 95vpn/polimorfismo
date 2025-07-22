using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    public class Menu : IMenu
    {
        Almacen g = new Golosinas();
        public void golosinas()
        {
            var des = "";
            var valor = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Venta de golosinas y frutas");
                if (g.getProducto().Count.Equals(0))
                {
                    Console.WriteLine("No hay golosinas");
                    Console.WriteLine("Desea agregar golosinas? precione las s/n");
                    des = Console.ReadLine();
                    if (des.Equals("s"))
                    {
                        Console.WriteLine("Cuantas golosinas va agregar?");
                        int cant = Convert.ToInt16(Console.ReadLine());
                    }
                }

            }
            while (valor);

        }

        public double solicitarPago()
        {
            throw new NotImplementedException();
        }

        public void ventas()
        {
            throw new NotImplementedException();
        }
    }
}
