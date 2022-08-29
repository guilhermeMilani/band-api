using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BandaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BandaController : ControllerBase
    {
        private BandaRepository bandaRepository;

        public BandaController()
        {
            this.bandaRepository = new BandaRepository();
        }

        [HttpGet]
        public List<Banda> Get()
        {
            bandaRepository = new BandaRepository();
            return bandaRepository.GetAll();
        }

        [HttpPost]
        public string Post(Banda banda)
        {
            bandaRepository = new BandaRepository();
            return bandaRepository.Create(banda);
        }

        [HttpPut]
        public string Put(Banda banda)
        {
            bandaRepository = new BandaRepository();
            return bandaRepository.Update(banda);
        }

        [HttpDelete]
        public string Delete(int id)
        {
            bandaRepository = new BandaRepository();
            return bandaRepository.Delete(id);
        }
    }
}
