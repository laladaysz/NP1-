﻿using Parking_Lot_Management.Dao;
using Parking_Lot_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot_Management.Controller
{
    public class MotoristaController
    {
        private MotoristaDao motoristaDao;

        public MotoristaController() 
        {
            motoristaDao = new MotoristaDao();
        }

        public void CadastrarMotorista(string nome, string email, string telefone, bool ativo)
        {
            Motorista motorista = new Motorista
            {
                Nome = nome,
                Email = email,
                Telefone = telefone,
                Ativo = ativo
            };
            motoristaDao.cadastrarMotorista(motorista);
        }

        public Motorista BuscarMotoristaPorId(int id)
        {
            return motoristaDao.BuscarMotoristaPorId(id);
        }

        public List<Motorista> GetAllMotoristas()
        {
            return motoristaDao.GetAllMotorista();
        }

        public void ExcluirMotorista(int id)
        {
            motoristaDao.ExcluirMotorista(id);
        }

        public void DesativarMotorista(int id)
        {
            motoristaDao.DesativarMotorista(id);
        }

        public string GetNomeMotoristaById(int motoristaId)
        {
            return motoristaDao.BuscarNomeMotoristaPorId(motoristaId);
        }

        public List<Motorista> GetMotoristaAtivos()
        {
            return motoristaDao.GetMotoristaAtivo();
        }
    }
}
