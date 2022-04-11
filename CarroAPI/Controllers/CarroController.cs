using Classes;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {
        [HttpGet]
        public List<LocadoraCarro> Get()
        {
            var listaCarro = new List<LocadoraCarro>();

            var carro1 = new LocadoraCarro(1, "Fiat Uno", "123456", "Veiculo Urbano", "789101112");
            var carro2 = new LocadoraCarro(2, "Chevrolet Corsa", "3412669", "Veiculo Urbano", "676454131");

            listaCarro.Add(carro1);
            listaCarro.Add(carro2);

            return listaCarro;
        }

        [HttpGet("{id}")]
        public LocadoraCarro Get(int id)
        {
            var listaCarro = new List<LocadoraCarro>();

            var carro1 = new LocadoraCarro(1, "Fiat Uno", "123456", "Veiculo Urbano", "789101112");
            var carro2 = new LocadoraCarro(2, "Chevrolet Corsa", "3412669", "Veiculo Urbano", "676454131");

            listaCarro.Add(carro1);
            listaCarro.Add(carro2);

            return listaCarro.FirstOrDefault(x => x.Id == id);
        }
    }
}
