﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Marca
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
