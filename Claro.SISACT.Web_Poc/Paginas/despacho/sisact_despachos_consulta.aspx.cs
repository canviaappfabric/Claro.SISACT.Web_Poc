using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Claro.SISACT.Common;
using Claro.SISACT.Web_Poc.Base;

namespace Claro.SISACT.Web_Poc.Paginas.despacho
{
    public partial class sisact_despachos_consulta : Sisact_Webbase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Usuario"] = Request.QueryString["Usuario"];


            if (!Page.IsPostBack)
                CargaInicialDespacho();
        }

        private void CargaInicialDespacho()
        {
            string CurrentUser = string.Empty;
            GeneradorLog objLog = new GeneradorLog(CurrentUser, null, null, "WEB");
            objLog.CrearArchivolog("Carga con el código 123500", null, null);
        }
    }
}