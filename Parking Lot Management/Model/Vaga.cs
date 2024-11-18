using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot_Management.Model
{
    public class Vaga
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public bool Disponivel { get; set; } = true;
        public string Localizacao { get; set; }
    }
}
