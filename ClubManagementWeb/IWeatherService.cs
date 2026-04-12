using System.ServiceModel;

namespace ClubManagementWeb
{
    // ServiceContract tells WCF: "this interface defines a web service"
    [ServiceContract]
    public interface IWeatherService
    {
        // OperationContract tells WCF: "this method is callable remotely"
        // Input:  zipCode (string) — e.g. "85281"
        // Output: string — formatted weather description
        [OperationContract]
        string GetWeather(string zipCode);
    }
}