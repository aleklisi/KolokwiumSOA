using System.Collections.Generic;
using System.Linq;
using LiteDB;

namespace ModelALELIS
{
    public class FighterRepository : IFighterRepository
    {
        private readonly string _fighterConnection = DatabaseConnections.FighterConnection;
        public List<Fighter> GetAll()
        {
            return Get();
        }

        public string Add(Fighter fighter)
        {
            return Post(fighter);
        }
        public List<Fighter> Get()
        {
            using (var db = new LiteDatabase(_fighterConnection))
            {
                var repository = db.GetCollection<Fighter>("fighters");
                var results = repository.FindAll();

                return results.ToList();
            }
        }

        public Fighter Get(int id)
        {
            using (var db = new LiteDatabase(_fighterConnection))
            {
                var repository = db.GetCollection<Fighter>("fighters");
                var results = repository.FindAll();

                return results.ToList().FirstOrDefault(x => x.Id == id);
            }
        }

        public Fighter Put(Fighter fighter)
        {
            using (var db = new LiteDatabase(_fighterConnection))
            {

                var repository = db.GetCollection<Fighter>("fighter");

                if (repository.Update(fighter))
                {
                    return fighter;
                }
                return null;
            }
        }

        public bool Delete(int id)
        {
            using (var db = new LiteDatabase(_fighterConnection))
            {
                var repository = db.GetCollection<Fighter>("fighter");
                return repository.Delete(id);
            }
        }

        public string Post(Fighter fighter)
        {
            using (var db = new LiteDatabase(_fighterConnection))
            {
                var dbObject = fighter;

                var repository = db.GetCollection<Fighter>("fighters");
                //w trakcie tworzenia sprawdza, czy Fighter o zadanej nazwie ju¿ istnieje – jeœli istnieje, nie zostaje dodany
                if (repository.Exists(f => f.Name == fighter.Name))
                    return "";
                if (repository.FindById(fighter.Id) == null)
                    repository.Insert(dbObject);

                return dbObject.Name;
            }
        }
    }
}