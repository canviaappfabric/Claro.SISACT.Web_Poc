using Claro.SISACT.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Claro.SISACT.Web_Poc.Base
{
    public class Sisact_Webbase : System.Web.UI.Page
    {
     
        protected override void OnInit(EventArgs e)
        {
            var childPage = this.GetType().UnderlyingSystemType;
            Constantes.nombrePagina = childPage.ToString();

        }
    }
}