using System;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace mvc_AuthenticationFilter.Filters
{
    public class UserAuthenticationFilter : ActionFilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            // Check Session is Empty Em seguida, o resultado é HttpUnauthorizedResult 
            if (string.IsNullOrEmpty(Convert.ToString(filterContext.HttpContext.Session["UserID"])))
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }


        // é executado após o método OnAuthentication  
        // ------------ //
        // OnAuthenticationChallenge: - se o método for chamado quando a autenticação ou autorização for 
        // falhou e este método é chamado depois
        // Execução do Método de Ação, mas antes da renderização do View
        // ------------ //

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            // Estamos verificando O resultado é nulo ou O resultado é HttpUnauthorizedResult 
            // se sim, então estamos Redirect to Error View
            if (filterContext.Result == null || filterContext.Result is HttpUnauthorizedResult)
            {
                filterContext.Result = new ViewResult
                {
                    ViewName = "Error"
                };
            }
        }

    }
}