using System.ServiceModel;

namespace ClubManagementWeb
{
    [ServiceContract]
    public interface IValidationService
    {
        [OperationContract]
        string Validate(string input, string type);
    }
}