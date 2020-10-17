﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace Dominios
{
    public class Articulo
    {
        public int Id { get; set; }
        public string CodArt { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public string ImagenURL { get; set; }
        public decimal Precio { get; set; }

    }
}

