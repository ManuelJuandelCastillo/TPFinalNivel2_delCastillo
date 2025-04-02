using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> categorias = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, Descripcion from CATEGORIAS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = (int)datos.Lector["Id"];
                    categoria.Descripcion = (string)datos.Lector["Descripcion"];
                    categorias.Add(categoria);
                }
                return categorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregarCategoria(Categoria nuevaCategoria)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into CATEGORIAS (Descripcion) values (@categoria)");
                datos.setearParametro("@categoria", nuevaCategoria.Descripcion);
                datos.ejecutarNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificarCategoria(Categoria categoria)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update CATEGORIAS set Descripcion = @categoria where Id = @id");
                datos.setearParametro("@categoria", categoria.Descripcion);
                datos.setearParametro("@id", categoria.Id);
                datos.ejecutarNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
