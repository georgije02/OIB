using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface IDBConnection
    {

        [OperationContract]
        List<Measurement> DataTransfer();

        [OperationContract]
        void UpdatingCentralDataBase(List<Measurement> updatedList);

        [OperationContract]
        void AddNewEntityToCentralDB(List<Measurement> listOfNewEntities);

        [OperationContract]
        void DeleteEntityFromCentralDB(List<Measurement> listWithDeletedEntities);

        [OperationContract]
        void TestCommunication();
    }
}
