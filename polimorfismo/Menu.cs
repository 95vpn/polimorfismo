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
                        for (int i = 0; i < cant; i++)
                        {
                            Console.WriteLine("Nueva golosinas");
                            Console.WriteLine("Ingrese la id");
                            var id = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre");
                            var nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el precio");
                            var precio = Convert.ToDouble(Console.ReadLine());
                            g.addProducto(new Producto
                            {
                                ID = id,
                                Nombre = nombre,
                                Precio = precio
                            }); 
                        }
                        Console.WriteLine("Desea ir al inicio s/n");
                        des = Console.ReadLine();
                        if (des.Equals("s"))
                        {
                            valor = true;
                        }
                        else
                        {
                            valor = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Desea ir al inicio s/n");
                        des = Console.ReadLine();
                        if (des.Equals("s"))
                        {
                            Console.Clear();
                            Console.WriteLine("vENTA DE GOLOSINAS Y FRUTAS");
                        }
                        else
                        {
                            valor = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Lista de golosinas");
                    foreach (var item in g.getProducto())
                    {
                        Console.WriteLine($"Codigo {item.ID} Golosinas {item.Nombre} Precio {item.Precio}");
                    }
                    Console.WriteLine("Desea realizar ventas de golosinas? s/n");
                    des = Console.ReadLine();
                }

            }
            while (valor);

        }

        public double solicitarPago()
        {
            bool pagoCorrecto = false;
            double res = 0;
            while (!pagoCorrecto)
            {
                Console.WriteLine("Como desea pagar con: 10, 5");
                res = double.Parse(Console.ReadLine());
                if (res != 5 && res != 10)
                {
                    Console.WriteLine("Pago no valido");
                }
                else
                {
                    pagoCorrecto= true;
                }
            }
            return res;
        }

        public void ventas()
        {
            double total = 0;
            string des = "";
            do
            {
                Console.WriteLine("Ingrese el producto");
                string producto = Console.ReadLine();
                var productos = g.getProducto(producto);
            }
            while (true);
        }
    }
}
