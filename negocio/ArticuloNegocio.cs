using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            try
            {
                string consulta = "select A.Id, Codigo, Nombre,M.Descripcion Marca, A.Descripcion, C.Descripcion Categoria, Precio, ImagenUrl, IdMarca, IdCategoria from ARTICULOS A, CATEGORIAS C, MARCAS M where c.Id = IdCategoria and m.Id = IdMarca";

                return SetearEjecutarLectura(consulta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from ARTICULOS where Id = " + articulo.Id);
                datos.ejecutarNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, Precio, ImagenUrl, IdMarca, IdCategoria) values(@codigo, @nombre, @descripcion, @precio, @imagen, @marca, @categoria)");
                datos.setearParametro("@codigo", nuevo.Codigo);
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.setearParametro("@precio", nuevo.Precio);
                datos.setearParametro("@imagen", nuevo.ImagenUrl);
                datos.setearParametro("@marca", nuevo.Marca.Id);
                datos.setearParametro("@categoria", nuevo.Categoria.Id);

                datos.ejecutarNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, ImagenUrl = @ImagenUrl, IdMarca = @IdMarca, IdCategoria = @IdCategoria where Id = @Id");
                datos.setearParametro("@Codigo", articulo.Codigo);
                datos.setearParametro("@Nombre", articulo.Nombre);
                datos.setearParametro("@Descripcion", articulo.Descripcion);
                datos.setearParametro("@Precio", articulo.Precio);
                datos.setearParametro("@ImagenUrl", articulo.ImagenUrl);
                datos.setearParametro("@IdMarca", articulo.Marca.Id);
                datos.setearParametro("@IdCategoria", articulo.Categoria.Id);
                datos.setearParametro("@Id", articulo.Id);
                datos.ejecutarNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


        // Ordenar lista completa por precio asc o desc
        public List<Articulo> filtrar(string orden)
        {
            try
            {
                string consulta = "select A.Id, Codigo, Nombre,M.Descripcion Marca, A.Descripcion, C.Descripcion Categoria, Precio, ImagenUrl, IdMarca, IdCategoria from ARTICULOS A, CATEGORIAS C, MARCAS M where c.Id = IdCategoria and m.Id = IdMarca order by Precio " + orden;

                return SetearEjecutarLectura(consulta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // filtrar por marca o categoria y ordenar por precio asc o desc
        public List<Articulo> filtrar(string campo, int id, string orden)
        {
            try
            {
                string consulta = "select A.Id, Codigo, Nombre,M.Descripcion Marca, A.Descripcion, C.Descripcion Categoria, Precio, ImagenUrl, IdMarca, IdCategoria from ARTICULOS A, CATEGORIAS C, MARCAS M where c.Id = IdCategoria and m.Id = IdMarca";
                if (campo == "Marca")
                    consulta += " and m.Id = " + id + " order by precio " + orden;
                else
                    consulta += " and c.Id = " + id + " order by precio " + orden;

                return SetearEjecutarLectura(consulta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // filtrar por marca o categoria sin ordenar por precio
        public List<Articulo> filtrar(string campo, int Id)
        {
            try
            {
                string consulta = "select A.Id, Codigo, Nombre,M.Descripcion Marca, A.Descripcion, C.Descripcion Categoria, Precio, ImagenUrl, IdMarca, IdCategoria from ARTICULOS A, CATEGORIAS C, MARCAS M where c.Id = IdCategoria and m.Id = IdMarca";
                if (campo == "Marca")
                    consulta += " and m.Id = " + Id;
                else
                    consulta += " and c.Id = " + Id;

                return SetearEjecutarLectura(consulta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Metodo que setea la consulta y ejecuta la lectura
        public List<Articulo> SetearEjecutarLectura(string consulta)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Articulo> lista = new List<Articulo>();
            try
            {
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)datos.Lector["Id"];
                    articulo.Codigo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    articulo.Precio = (decimal)datos.Lector["Precio"];
                    articulo.PrecioFormat = string.Format("{0:C}", articulo.Precio);
                    articulo.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    articulo.Marca = new Marca();
                    articulo.Marca.Id = (int)(datos.Lector["IdMarca"]);
                    articulo.Marca.Descripcion = (string)datos.Lector["Marca"];
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    articulo.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    lista.Add(articulo);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
