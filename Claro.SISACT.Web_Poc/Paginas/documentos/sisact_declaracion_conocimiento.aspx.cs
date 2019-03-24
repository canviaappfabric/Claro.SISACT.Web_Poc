using Claro.SISACT.Common;
using Claro.SISACT.Web_Poc.Base;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Claro.SISACT.Web_Poc.Paginas.documentos
{
    public partial class sisact_declaracion_conocimiento : Sisact_Webbase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Usuario"] = Request.QueryString["Usuario"];


            if (!Page.IsPostBack)
                CargarDeclConocimiento();
        }

        private  void CargarDeclConocimiento()
        {
            string CurrentUser = string.Empty;
            GeneradorLog objLog = new GeneradorLog(CurrentUser, null, null, "WEB");
            objLog.CrearArchivolog("Segmento: " + "1234", null, null);
        }
    }
}