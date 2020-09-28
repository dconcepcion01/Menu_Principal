using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Principal
{
    public class DataBaseContext
    {   
        public DataBaseContext()
        {
            this.producto1s = new List<Producto1>() {

                new Producto1(){Codigo=1,Descripcion="Cpu dell",Codigo_Categoria=1,Descripcion_Categoria="cpu dell",Precio=2343,Cantidad=1,Marca="dell",Costo=2903,Itbis=0.18,Referencia="omega"},
                 new Producto1(){Codigo=2,Descripcion="mouse",Codigo_Categoria=1,Descripcion_Categoria="mouse",Precio=2343,Cantidad=1,Marca="dell",Costo=2903,Itbis=0.18,Referencia="ceconsa"},
                  new Producto1(){Codigo=3,Descripcion="bocina logiteg",Codigo_Categoria=1,Descripcion_Categoria="Teclado",Precio=2343,Cantidad=1,Marca="dell",Costo=2903,Itbis=0.18,Referencia="omega"},
                   new Producto1(){Codigo=4,Descripcion="celular",Codigo_Categoria=1,Descripcion_Categoria="Elctronica",Precio=2343,Cantidad=1,Marca="dell",Costo=2903,Itbis=0.18,Referencia="omega"},
                    new Producto1(){Codigo=5,Descripcion="impresora",Codigo_Categoria=1,Descripcion_Categoria="electronica",Precio=2343,Cantidad=1,Marca="dell",Costo=2903,Itbis=0.18,Referencia="plazaglobal"},
                     new Producto1(){Codigo=6,Descripcion="vga",Codigo_Categoria=1,Descripcion_Categoria="informatca",Precio=2343,Cantidad=1,Marca="dell",Costo=2903,Itbis=0.18,Referencia="omega"},
                      new Producto1(){Codigo=7,Descripcion="power suplay",Codigo_Categoria=1,Descripcion_Categoria="informatica",Precio=2343,Cantidad=1,Marca="dell",Costo=2903,Itbis=0.18,Referencia="puntolaptop"},
                       new Producto1(){Codigo=8,Descripcion="blootoo",Codigo_Categoria=1,Descripcion_Categoria="informatica",Precio=2343,Cantidad=1,Marca="dell",Costo=2903,Itbis=0.18,Referencia="puntolaptop"},
                        new Producto1(){Codigo=9,Descripcion="camara web",Codigo_Categoria=1,Descripcion_Categoria="informatica",Precio=2343,Cantidad=1,Marca="dell",Costo=2903,Itbis=0.18,Referencia="puntolaptop"},
                         new Producto1(){Codigo=10,Descripcion="memoria ram",Codigo_Categoria=1,Descripcion_Categoria="informatica",Precio=2343,Cantidad=1,Marca="dell",Costo=2903,Itbis=0.18,Referencia="puntolaptop"}


            };
        }

        public List<Producto1> producto1s;


    }
}
