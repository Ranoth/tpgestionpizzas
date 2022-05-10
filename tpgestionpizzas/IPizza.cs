using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpgestionpizzas
{
    interface IPizza
    {
        void AfficheDetail();
        decimal GetPrix();
        double GetSurface();
    }
}
