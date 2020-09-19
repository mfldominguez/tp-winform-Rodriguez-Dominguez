using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Marca
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
        public Marca() { }
        public Marca(int codigo, string nombre)
        {
            Id = codigo;
            Descripcion = nombre;

        }
    }
}