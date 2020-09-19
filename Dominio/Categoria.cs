using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
        public Categoria() { }
        public Categoria(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
    }
}
