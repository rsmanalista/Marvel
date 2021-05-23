﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarkets.Marvel.Application.ViewModels
{
    public class MarvelFanViewModel
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Cpf { get; private set; }
        public string Email { get; private set; }
        public DateTime DtNasc { get; private set; }
    }
}
