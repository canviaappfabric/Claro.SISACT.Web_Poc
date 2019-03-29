using Claro.SISACT.Common;
using System;


namespace Claro.SISACT.Web_Poc.Base
{
    public class Sisact_Webbase : System.Web.UI.Page
    {
     
        protected override void OnInit(EventArgs e)
        {
            var childPage = this.GetType().UnderlyingSystemType;
            Constantes.NombrePagina = Convert.ToString(childPage.Name);

        }
    }
}