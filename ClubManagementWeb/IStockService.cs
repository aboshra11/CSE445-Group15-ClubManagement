using System.ServiceModel;

namespace ClubManagementWeb
{
    [ServiceContract]
    public interface IStockService
    {
        [OperationContract]
        string GetStockPrice(string symbol);
    }
}