using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Aircrafts
{
    internal class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, vendos sudeste, ventos ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros ok, ligando as helices");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem!");
        }
    }
}
