﻿using System;

namespace Consultorio.Models.Dtos
{
    public class ConsultaParams
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get;}
        public string NomeEspecialidade { get; set; }
    }
}