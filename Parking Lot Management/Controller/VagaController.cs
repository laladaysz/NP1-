using Parking_Lot_Management.Dao;
using Parking_Lot_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot_Management.Controller
{
    public class VagaController
    {
        private VagaDAO vagaDAO;

        public VagaController()
        {
            vagaDAO = new VagaDAO();
        }

        public void CadastrarVaga( string numero, string tipo, bool disponivel, string localizacao)
        {
            Vaga vaga = new Vaga
            {
                Numero = numero,
                Tipo = tipo,
                Disponivel = disponivel,
                Localizacao = localizacao
            };

        }
    }
}
