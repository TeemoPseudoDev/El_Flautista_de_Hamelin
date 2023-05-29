using System;
using El_Flautista_de_Hamelin.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Flautista_de_Hamelin.Controllers
{
    internal class ComidaController
    {
        private Comida comidaModel;

        public ComidaController()
        {
            comidaModel = new Comida();
        }

        public List<Comida> obtenerComidas(){
            return comidaModel.traerComidas();

        }
    }
}
