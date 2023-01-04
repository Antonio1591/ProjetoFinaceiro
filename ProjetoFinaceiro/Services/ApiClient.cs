using Newtonsoft.Json;
using ProjetoFinaceiro.Model;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;

namespace ProjetoFinaceiro.Services
{
    public class ApiClient
    {
        private readonly HttpClient client;

        public ApiClient(HttpClient client)
        {
            this.client = client;
            client.BaseAddress = new Uri("https://localhost:44358/api/");
        }

        public async Task<T> getAsync<T>(string url)
        {
            var response = await client.GetAsync(url);
            var context = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(context);

        }
        public async Task<RespostaApi<TViweModel>> Create<TViweModel, TInputModel>(string url, 
            
            
            TInputModel imput)
        {

            client.DefaultRequestHeaders.Accept.Clear();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var jsonContent = JsonConvert.SerializeObject(imput);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            contentString.Headers.ContentType = new MediaTypeHeaderValue(MediaTypeNames.Application.Json);
            HttpResponseMessage responsePost = await client.PostAsync(url, contentString);
            var resultado = await responsePost.Content.ReadAsStringAsync();
            if (responsePost.IsSuccessStatusCode)
            {
                return new RespostaApi<TViweModel>
                {
                    Dados = JsonConvert.DeserializeObject<TViweModel>(resultado),

                };
            }

            return new RespostaApi<TViweModel>
            {
                MensagemErro = JsonConvert.DeserializeObject<IEnumerable<string>>(resultado),

                Erro = true,
            };

        }
        public async Task<RespostaApi<TViweModel>> Login<TViweModel, TInputModel>(string url, TInputModel imput)
        {

            client.DefaultRequestHeaders.Accept.Clear();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var jsonContent = JsonConvert.SerializeObject(imput);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            contentString.Headers.ContentType = new MediaTypeHeaderValue(MediaTypeNames.Application.Json);
            HttpResponseMessage responsePost = await client.PostAsync(url, contentString);
            var resultado = await responsePost.Content.ReadAsStringAsync();
            if (responsePost.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<RespostaApi<TViweModel>>(resultado);

            return new RespostaApi<TViweModel>
            {
                MensagemErro = JsonConvert.DeserializeObject<IEnumerable<string>>(resultado),

                Erro = true,
            };
    }
        public async Task<RespostaApi<TViweModel>> Update<TViweModel, TInputModel>(string url, TInputModel imput)
        {

            client.DefaultRequestHeaders.Accept.Clear();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var jsonContent = JsonConvert.SerializeObject(imput);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            contentString.Headers.ContentType = new MediaTypeHeaderValue(MediaTypeNames.Application.Json);
            HttpResponseMessage responsePost = await client.PutAsync(url, contentString);
            var resultado = await responsePost.Content.ReadAsStringAsync();
            if (responsePost.IsSuccessStatusCode)
            {
                return new RespostaApi<TViweModel>
                {
                    Dados = JsonConvert.DeserializeObject<TViweModel>(resultado),

                };
            }

            return new RespostaApi<TViweModel>
            {
                MensagemErro = JsonConvert.DeserializeObject<IEnumerable<string>>(resultado),

                Erro = true,
            };

        }
    }
}
