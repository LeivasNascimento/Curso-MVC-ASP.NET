using System.Web;
using System.Web.Mvc;

namespace Introducao
{
    public class FilterConfig
    {

        //trabalha com mensagem de erros e alertas, não é obrigatório
        //
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
