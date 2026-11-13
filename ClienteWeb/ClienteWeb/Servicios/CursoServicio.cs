using ClienteWeb.Models;

namespace ClienteWeb.Servicios
{
    //Este servicio va ser pe pal api
    public class CursoServicio
    {
        public readonly HttpClient _httpClient;
        public readonly string Ruta = "api/Cursos";

        public CursoServicio(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<CursoDto>> GetAllCursos() 
        {
            var resultado = await _httpClient.GetFromJsonAsync<List<CursoDto>>(Ruta);

            if (resultado == null)
            {
                return new List<CursoDto>();
            }

            return resultado.ToList();
        }
    }
    
    
}
