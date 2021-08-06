using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DXWebApplication.App_Code.Utilidades;
using DXWebApplication.App_Code.Models;

namespace DXWebApplication.App_Code.Dal.DaoMantenimientos
{
    public class ClsDaoCliente : ClsDataLayer
    {
        ClsConexion objSql = new ClsConexion();
        ClsErrorHandler log = new ClsErrorHandler();
        string strSql = "";        
        //Estructura de un metodo para obtener informacion de la BD
        public bool GetClienteAll()
        {
            try
            {               
                strSql = "SELECT ID_CLIENTE, NOMBRE, APELLIDO, NIT, DIRECCION, TELEFONO FROM POS.CLIENTE  ";
                DsReturn = objSql.EjectuaSQL(strSql, "Cliente");                
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return true;
        }
        //Estructura de un metodo para ABC
        public bool InsertCliente(ClsCliente cliente)
        {
           
            return ExecuteSql(strSql);
        }
        //Metodo para modificar cliente
        public bool ModificaCliente(ClsCliente cliente)
        {
           

            return ExecuteSql(strSql);
        }

        //Estructura de un metodo para ejecutar una accion INSERT, UPDATE, DELETE en nuestra BD
        public bool ExecuteSql(string strSql)
        {
            try
            {
                return objSql.ejecutarNonQuery(strSql);
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }            
        }
    }
}
