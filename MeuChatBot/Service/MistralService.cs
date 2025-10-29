using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace MeuChatBot.Services
{
    public class MistralService
    {
        private readonly HttpClient _httpClient;

        public MistralService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:1234/v1/") // ajuste conforme a porta do LM Studio
            };
        }

        public async Task<string> GetResponseAsync(string prompt)
        {
            try
            {
                var request = new
                {
                    model = "mistral",
                    messages = new[]
                    {
                        new { role = "user", content = prompt }
                    }
                };

                var response = await _httpClient.PostAsJsonAsync("chat/completions", request);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();

                using var doc = JsonDocument.Parse(json);
                var root = doc.RootElement;

                // Caminho correto no JSON retornado pelo LM Studio
                var content = root.GetProperty("choices")[0]
                                  .GetProperty("message")
                                  .GetProperty("content")
                                  .GetString();

                return content ?? "⚠️ O modelo não retornou conteúdo.";
            }
            catch (Exception ex)
            {
                return $"Desculpe, estou enfrentando problemas para me conectar ao modelo local. Detalhes: {ex.Message}";
            }
        }
    }
}
