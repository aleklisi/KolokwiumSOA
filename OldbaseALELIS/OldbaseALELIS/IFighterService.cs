using System.Collections.Generic;
using System.ServiceModel;
using ModelALELIS;

namespace OldbaseALELIS
{
    [ServiceContract]
    public interface IFighterService
    {
        [OperationContract]
        Fighter GetFighter(string name);

        [OperationContract]
        string CreateFighter(Fighter fighter);

        [OperationContract]
        List<Fighter> GetAllFighters();
    }
}
