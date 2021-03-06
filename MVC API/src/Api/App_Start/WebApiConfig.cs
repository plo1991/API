using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",

                //adicionamos {action} na rota padrão do web api
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //para a api soltar dados em formato json remova a convensão de formato de saida XML
            config.Formatters.Remove(config.Formatters.XmlFormatter);

        }
    }
}
