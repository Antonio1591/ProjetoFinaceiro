using apiProjetoFinaceiro.Model.Domain.UsuarioIdentityRepositorio;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using ProjetoFinaceiro.Model;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Security.Policy;
using System.Text;

namespace ProjetoFinaceiro.Services
{
    public class ApiClient
    {
        private readonly HttpClient client;
        private readonly AspNetUser _user;

        public ApiClient(HttpClient client, AspNetUser user)
        {
            this.client = client;
            client.BaseAddress = new Uri("https://localhost:44358/api/");
            _user = user;
        }

        private void ConfigurarCabecalho()
        {
            if (string.IsNullOrEmpty(_user.AccessToken)) return;

            if (client.DefaultRequestHeaders.Contains("Authorization"))
            {ss
                client.DefaultRequestHeaders.Remove("Authorization");
            }

            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_user.AccessToken}");
        }

        public async Task<T> getAsync<T>(string url)
        {
            ConfigurarCabecalho();

            var response = await client.GetAsync(url);
            var context = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(context);

        }
    
        public async Task<RespostaApi<TViweModel>> Create<TViweModel, TInputModel>(string url,TInputModel imput)
        {
            ConfigurarCabecalho();

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

        public async Task<UsuarioLoginResponse> LoginIdentity(UsuarioLoginRequest usuairo)
        {
            client.DefaultRequestHeaders.Accept.Clear();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var jsonContent = JsonConvert.SerializeObject(usuairo);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            contentString.Headers.ContentType = new MediaTypeHeaderValue(MediaTypeNames.Application.Json);
            HttpResponseMessage responsePost = await client.PostAsync("UsuarioIdentity/Login", contentString);
            var resultado = await responsePost.Content.ReadAsStringAsync();
            if (responsePost.IsSuccessStatusCode)
            {
                var resposta = JsonConvert.DeserializeObject<UsuarioLoginResponse>(resultado);

                _user.AccessToken = resposta.Token;

                return resposta;
            }
            else if (responsePost.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                var resposta = JsonConvert.DeserializeObject<UsuarioLoginResponse>(resultado);

                _user.AccessToken = null;

                return resposta;
            }

            return null;
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
            ConfigurarCabecalho();


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

    public class AspNetUser
    {
        public string AccessToken { get; set; }
    }
}
