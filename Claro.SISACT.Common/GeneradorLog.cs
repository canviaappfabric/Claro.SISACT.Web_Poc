using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web;

namespace Claro.SISACT.Common
{
    public class GeneradorLog
    {
        private static ILog _loggerManager = LogManager.GetLogger(Constantes.nombrePagina);
        public GeneradorLog(string usuario, string idIdentificador, string idIdTansaccion, string archivo)
        {
            idIdentificador = Guid.NewGuid().ToString();
            usuario = Convert.ToString(HttpContext.Current.Session["Usuario"]);
            MDC.Set("HostName", Environment.MachineName);
            LogicalThreadContext.Properties["Usuario"] = usuario;
            LogicalThreadContext.Properties["Identificador"] = idIdentificador;
            LogicalThreadContext.Properties["ApplicationName"] = ConfigurationManager.AppSettings["ApplicationName"];


        }

        public void CrearArchivolog(string evento, List<String> lstLog, Exception objException)
        {
            if (objException == null)
                _loggerManager.Info(evento);
            else
                _loggerManager.Error(evento,objException);
        }
    }
}
