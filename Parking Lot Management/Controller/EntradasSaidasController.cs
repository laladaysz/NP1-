using Parking_Lot_Management.Dao;
using Parking_Lot_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot_Management.Controller
{
    public class EntradasSaidasController
    {
        EntradasSaidasDAO entradasSaidasDAO;

        public EntradasSaidasController()
        {
            entradasSaidasDAO = new EntradasSaidasDAO();
        }

        public void CadastrarEntrada(int MotoristaId, int VeiculoId, int VagaId)
        {
            EntradasSaidas entrada = new EntradasSaidas
            {
                VeiculoId = VeiculoId,
                VagaId = VagaId,
                MotoristaId = MotoristaId,
                Entrada = DateTime.Now
            };

            entradasSaidasDAO.CadastrarEntrada(entrada);

        }
    }
}
