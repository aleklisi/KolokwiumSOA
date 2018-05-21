using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using ModelALELIS;

namespace OldbaseALELIS
{
    //serwis działa w trybie Single (jedna instancja służy wszystkim klientom)
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class FighterService : IFighterService
    {
        private readonly FighterRepository _fighterRepostiry;

        public FighterService()
        {
            _fighterRepostiry = new FighterRepository();
        }

        public Fighter GetFighter(string name)
        {
            return GetAllFighters().FirstOrDefault(f => f.Name == name);
        }

        public string CreateFighter(Fighter fighter)
        {
            return _fighterRepostiry.Add(fighter);
        }
        // metoda GetAllFighters() – zwraca kolekcję wszystkich obiektów Fighter
        public List<Fighter> GetAllFighters()
        {
            return _fighterRepostiry.GetAll().ToList();
        }
    }
}
