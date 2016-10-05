using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(name: "Home", url: "", defaults: new { controller = "TelaLogin", action = "Login" });
            routes.MapRoute(name: "CadastrarCliente", url: "cadastrar", defaults: new { controller = "TelaCadastroCliente", action = "CadastrarCliente" });


            routes.MapRoute(name: "IndexCliente", url: "cliente", defaults: new { controller = "TelaCliente", action = "Index" });
            routes.MapRoute(name: "novoChamado", url: "cliente/novochamado", defaults: new { controller = "TelaCliente", action = "NovoChamado" });

        }
    }
}
