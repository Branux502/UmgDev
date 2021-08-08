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

namespace DXWebApplication.WebForms.Mantenimientos.Biblioteca
{
    public partial class WebBiblioteca : System.Web.UI.Page
    {

        ClsErrorHandler log = new ClsErrorHandler();
        DataSet dsBiblioteca = new DataSet();
        ClsControllerBiblioteca objBiblioteca = new ClsControllerBiblioteca();
        ClsBiblioteca biblioteca = new ClsBiblioteca();
        
        

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                    CargaBiblioteca();
                else
                    SetDropMenu();
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
            }
        }

        void CargaBiblioteca()
        {
            if(objBiblioteca.GetLibrosAll())
            {
                /*
                ddlista.DataTextField = dsBiblioteca.Tables[0].Columns["NOMBRE"].ToString();
                ddlista.DataValueField = dsBiblioteca.Tables[0].Columns["ID_LIBRO"].ToString();
                ddlista.DataSource = dsBiblioteca.Tables[0];
                ddlista.DataBind();
                */
                //ddlista.DataTextField = objBiblioteca.DsReturn.Tables["Libro"].Columns["NOMBRE"].ToString();
                //ddlista.DataSource = objBiblioteca.DsReturn.Tables["Libro"].Columns;
                ListItem i;
                foreach (DataRow r in objBiblioteca.DsReturn.Tables["Libro"].Rows)
                {
                    i = new ListItem(r["NOMBRE"].ToString(), r["ID_LIBRO"].ToString());
                    ddlista.Items.Add(i);
                }
                //ddlista.DataBind();
              //  Session["Libro"] = objBiblioteca.DsReturn;
                
            }
        }

        void SetDropMenu()
        {
            ddlista.DataSource = ((DataSet)Session["Libro"]);
            ddlista.DataBind();
        }
        
    }
}