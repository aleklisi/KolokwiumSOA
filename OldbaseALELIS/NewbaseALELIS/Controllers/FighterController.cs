using System.Collections.Generic;
using System.Web.Http;
using ModelALELIS;

namespace NewbaseALELIS.Controllers
{
    public class FighterController : ApiController
    {
        private readonly IFighterRepository _fighterRepository;

        public FighterController()
        {
            _fighterRepository = new FighterRepository();
        }

        public IEnumerable<Fighter> Get()
        {
            return _fighterRepository.GetAll();
        }

        public string Get(int id)
        {
            return _fighterRepository.Get(id).Name;
        }

        public string Post(Fighter fiighter)
        {
            return _fighterRepository.Post(fiighter);
        }
        //za 1 pkt
        public Fighter Put([FromBody]Fighter fiighter)
        {
            return _fighterRepository.Put(fiighter);
        }
        public bool Delete(int id)
        {
            return _fighterRepository.Delete(id);
        }
    }
}
