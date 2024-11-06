using Parking_Lot_Management.Dao;
using Parking_Lot_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot_Management.Controller
{
    public class VeiculoController
    {
        private VeiculoDAO veiculoDAO;

        public VeiculoController() 
        {
            veiculoDAO = new VeiculoDAO(); 
        }

        public List<Veiculo> GetAllVeiculo()
        {
            return veiculoDAO.GetAllVeiculos();
        }

        public void CadastrarVeiculos(string placa, string modelo, string cor, int idMotorista)
        {
            Veiculo veiculo = new Veiculo()
            {
                Placa = placa,
                Modelo = modelo,
                Cor = cor
            };

            veiculoDAO.CadastrarVeiculo(veiculo, idMotorista);
        }

        public Veiculo GetVeiculoById(int id) 
        { 
            return veiculoDAO.GetVeiculoById(id);
        }

        public void DeleteVeiculo(int id) 
        {
            veiculoDAO.DeleteVeiculo(id);
        }

        public List<Veiculo> GetVeiculosByMotorista(int idMotorista)
        {
            return veiculoDAO.GetVeiculoByMotorista(idMotorista);
        }
    }
}
