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
        /*
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]Something value)
        {
            int i = 10;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }*/
    }
}
