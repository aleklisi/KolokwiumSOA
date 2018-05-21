using System.Collections.Generic;

namespace ModelALELIS
{
    public interface IFighterRepository
    {
        List<Fighter> Get();// - zwraca wszystkie obiekty Fighter
        List<Fighter> GetAll();// - zwraca wszystkie obiekty Fighter
        Fighter Get(int id);// - zwraca obiekt Fighter o zadanym id
        string Post(Fighter fighter);// - pozwala doda� obiekt Fighter z sekcji http body
        string Add(Fighter fighter);// - pozwala doda� obiekt Fighter z sekcji http body
        Fighter Put(Fighter fighter);// - pozwala podmieni� obiekt Fighter z sekcji http body
        bool Delete(int id); // - pozwala usun�� obiekt Fighter o zadanym id
    }
}