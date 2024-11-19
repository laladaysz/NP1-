using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot_Management.Model
{
    public class EntradasSaidas
    {
        public int Id {  get; set; }
        public int MotoristaId { get; set; }
        public int VeiculoId { get; set; }
        public int VagaId { get; set; }
        public DateTime Entrada {  get; set; }
        public DateTime? Saida { get; set; }
        public bool Pago { get; set; }


        public Motorista Motorista { get; set; }
        public Veiculo Veiculo { get; set; }
        public Vaga Vaga { get; set; }
    }
}
