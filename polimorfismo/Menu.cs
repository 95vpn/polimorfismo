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
