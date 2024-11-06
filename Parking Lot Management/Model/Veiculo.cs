using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot_Management.Model
{
    public class Veiculo
    {
        public int Id { get; set; }                
        public string Placa { get; set; }          
        public string Modelo { get; set; }         
        public string Cor { get; set; }            
        public int MotoristaId { get; set; }       

    }
}
