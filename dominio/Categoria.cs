using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Categoria
    {
        public int Id { get; set; }

        [DisplayName("Categoría")]
        public string Descripcion { get; set; }

        // sobreescritura del metodo toString para que devuelva el dato que nos interesa mostrar
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
