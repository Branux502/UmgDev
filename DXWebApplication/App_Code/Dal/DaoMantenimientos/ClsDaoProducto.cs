using DXWebApplication.App_Code.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXWebApplication.App_Code.Dal.DaoMantenimientos
{
    public class ClsDaoProducto : ClsDataLayer
    {
        ClsConexion objSql = new ClsConexion();
        ClsErrorHandler log = new ClsErrorHandler();
        string strSql = "";
        //Estructura de un metodo para obtener informacion de la BD
        public bool GetProductoAll()
        {
            try
            {
                strSql = "SELECT ID_PRODUCTO, ID_TIPO_PRODUCTO, DESCRIPCION, PRECIO, EXISTENCIA, ESTADO FROM POS.PRODUCTO  ";
                DsReturn = objSql.EjectuaSQL(strSql, "Producto");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return true;
        }
    }
}