﻿using Parking_Lot_Management.Dao;
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

        public void CadastrarVaga( string numero, string tipo, string localizacao)
        {
            Vaga vaga = new Vaga
            {
                Numero = numero,
                Tipo = tipo,
                Disponivel = true,
                Localizacao = localizacao
            };

            vagaDAO.CadastrarVaga(vaga);

        }

        public List<Vaga> GetAllVagas() { 
            return vagaDAO.GetAllVagas();
        }

        public void DeletarVaga(int id)
        {
            vagaDAO.DeleteVaga(id);
        }

        public Vaga GetVagaById(int id)
        {
            return vagaDAO.GetVagaById(id);
        }

        public void AtualizarVaga(int id, string numero,  string tipo, string localizacao)
        {
            Vaga vaga = new Vaga
            {
                Id = id,
                Numero = numero,
                Tipo = tipo,
                Disponivel = true,
                Localizacao = localizacao
            };

            vagaDAO.AtualizarVaga(vaga);
        }

        public List<Vaga> GetVagasDisponiveis()
        {
            return vagaDAO.GetVagasDisponiveis();

        }

        public void OcuparVaga(int Id)
        {
            vagaDAO.OcuparVaga(Id);
        }

        public void DesocuparVaga(int Id)
        {
            vagaDAO.DesocuparVaga(Id);
        }
    }
}
