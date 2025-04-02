using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> marcas = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Marca marca = new Marca();
                    marca.Id = (int)datos.Lector["Id"];
                    marca.Descripcion = (string)datos.Lector["Descripcion"];
                    marcas.Add(marca);
                }
                return marcas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregarMarca(Marca nuevaMarca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into MARCAS (Descripcion) values (@marca)");
                datos.setearParametro("@marca", nuevaMarca.Descripcion);
                datos.ejecutarNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificarMarca(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update MARCAS set Descripcion = @marca where Id = @id");
                datos.setearParametro("@marca", marca.Descripcion);
                datos.setearParametro("@id", marca.Id);
                datos.ejecutarNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
