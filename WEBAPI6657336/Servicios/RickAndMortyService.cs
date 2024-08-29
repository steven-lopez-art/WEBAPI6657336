using WEBAPI6657336.Modelo;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WEBAPI6657336.Servicios
{
    public class RickAndMortyService : IRickAndMortyService
    { 
        private string urlApi = "https://rickandmortyapi.com/api/character";
        
        public async Task<List<PersonajeResponse>> Obtener()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(urlApi);
            var responseBody = await response.Content.ReadAsStringAsync();
            JsonNode nodos = JsonNode.Parse(responseBody);
            JsonNode results = nodos["results"];
            var personajeData =JsonSerializer.Deserialize<List<PersonajeResponse>>(results.ToJsonString());
            return personajeData;
        }


    }
}
