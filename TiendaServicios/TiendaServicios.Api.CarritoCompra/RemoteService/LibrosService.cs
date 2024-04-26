﻿using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TiendaServicios.Api.CarritoCompra.RemoteInterface;
using TiendaServicios.Api.CarritoCompra.RemoteModel;

namespace TiendaServicios.Api.CarritoCompra.RemoteService
{
    public class LibrosService : ILibrosService
    {
        private readonly IHttpClientFactory _httpClient;
        private readonly ILogger<LibrosService> _logger;

        public LibrosService(IHttpClientFactory httpClient , ILogger<LibrosService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }
        public async Task<(bool resultado, LibroRemote libro, string ErrorMessage)> GetLibro(Guid LibroId)
        {
            try
            {
                var cliente = _httpClient.CreateClient("Libros");
                var response = await cliente.GetAsync($"api/LibroMaterial/{LibroId}");

                if (response.IsSuccessStatusCode)
                {
                      var contenido = await response.Content.ReadAsStringAsync();
                      var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                      var resultado = JsonSerializer.Deserialize<LibroRemote>(contenido,options);
                      return (true, resultado, null);
                }
                return( false, null, response.ReasonPhrase);

            } catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return(false, null, ex.Message);  
            }
        }
    }
}
