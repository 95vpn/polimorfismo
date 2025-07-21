using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    public interface IMenu
    {
        void golosinas();
        void ventas();
        double solicitarPago();
    }
}
