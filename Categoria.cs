using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Principal
{
    public class Categoria
    {
        public int Codigo_Categoria { get; set; }
        public string Descripcion_Categoria { get; set; }

        public List<Producto1> producto1s { get; set; }
    }
}
