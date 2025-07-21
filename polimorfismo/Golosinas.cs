using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    public class Golosinas : Almacen
    {
        private List<Producto> _Golosinas;
        public Golosinas()
        {
            _Golosinas = new List<Producto>();
        }
        public override void addProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public override List<Productos> getProducto(string valor)
        {
            throw new NotImplementedException();
        }
    }
}
