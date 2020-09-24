using EmpreasAPI.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmpreasAPI.Domain.Services
{
    public class Requisicao : ControllerBase
    {

        public async Task<ActionResult<EmpresaWS>> RequisicaoWebService(string cnpj)
        {
            var httpClient = HttpClientFactory.Create();
            var url = $"https://www.receitaws.com.br/v1/cnpj/{cnpj}";
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);

            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;

                var data = await content.ReadAsAsync<EmpresaWS>();
                data.Cnpj = cnpj;
                if (data.Status != "OK")
                {
                    return Ok(new { message = $"{data.Message}" });
                }
                return data;
            }
            else
            {
                return Ok(new { message = $"Aguarde um pouco ate o proximo registro (Erro: {httpResponseMessage.StatusCode})" });
            }
        }
    }
}
