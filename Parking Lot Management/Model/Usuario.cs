﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot_Management.Model
{
    public class Usuario
    {
        public int Id { get; set; }               
        public string Nome { get; set; }           
        public string Email { get; set; }          
        public string Senha { get; set; }          
        public string Role { get; set; }           
        public bool Ativado { get; set; }
    }
}
