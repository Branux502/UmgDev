using DXWebApplication.App_Code.Controller.ControllerMantenimientos;
using DXWebApplication.App_Code.Models;
using DXWebApplication.App_Code.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXWebApplication.WebForms.Mantenimientos.Producto
{
    public partial class WebProducto : System.Web.UI.Page
    {

        ClsErrorHandler log = new ClsErrorHandler();
        DataSet dsProducto = new DataSet();
        ClsControllerProducto objProducto = new ClsControllerProducto();
        ClsProducto producto = new ClsProducto();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                    CargaProductos();
                else
                    SetGridProducto();
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
            }
        }


        void CargaProductos()
        {
            if (objProducto.GetProductoAll())
            {
                dxGridProducto.DataSource = objProducto.DsReturn.Tables["Producto"];
                dxGridProducto.DataBind();
                Session["Producto"] = objProducto.DsReturn;
            }
        }
        void SetGridProducto()
        {
            dxGridProducto.DataSource = ((DataSet)Session["Producto"]);
            dxGridProducto.DataBind();
        }
        void VaciarGridProducto()
        {
            dxGridProducto.DataSource = null;
            dxGridProducto.DataBind();
        }

    }
}