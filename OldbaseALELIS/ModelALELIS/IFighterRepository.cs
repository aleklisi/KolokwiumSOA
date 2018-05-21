using System.Collections.Generic;

namespace ModelALELIS
{
    public interface IFighterRepository
    {
        List<Fighter> Get();// - zwraca wszystkie obiekty Fighter
        List<Fighter> GetAll();// - zwraca wszystkie obiekty Fighter
        Fighter Get(int id);// - zwraca obiekt Fighter o zadanym id
        string Post(Fighter fighter);// - pozwala dodaæ obiekt Fighter z sekcji http body
        string Add(Fighter fighter);// - pozwala dodaæ obiekt Fighter z sekcji http body
        Fighter Put(Fighter fighter);// - pozwala podmieniæ obiekt Fighter z sekcji http body
        bool Delete(int id); // - pozwala usun¹æ obiekt Fighter o zadanym id
    }
}