using System;
using El_Flautista_de_Hamelin.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Flautista_de_Hamelin.Controllers
{
    internal class comidaController
    {
        private Comida comidaModel;

        public comidaController()
        {
            comidaModel = new Comida();
        }

        public List<Comida> obtenerComidas(){
            return comidaModel.traerComidad();

        }
    }
}
