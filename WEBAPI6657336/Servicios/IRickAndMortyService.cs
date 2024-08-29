using WEBAPI6657336.Modelo;

namespace WEBAPI6657336.Servicios
{
    public interface IRickAndMortyService
    {
        public Task<List<PersonajeResponse>> Obtener();


    }
}
