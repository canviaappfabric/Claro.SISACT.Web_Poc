using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Claro.SISACT.Common;

namespace Claro.SISACT.Web_Poc.Paginas.despacho
{
    public partial class sisact_pool_despachos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Usuario"] = Request.QueryString["Usuario"];


            if (!Page.IsPostBack)
                CargaInicialPool();
        }

        private void CargaInicialPool()
        {
            string CurrentUser = string.Empty;
            GeneradorLog objLog = new GeneradorLog(CurrentUser, null, null, "WEB");


            try
            {
                throw new Exception("Ocurrio un error de negocio, con el usuario EF0009");
            }
            catch (Exception ex)
            {
                objLog.CrearArchivolog(null, null, ex);       
                
            }
        }
    }
}