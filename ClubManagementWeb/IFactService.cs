using System.ServiceModel;
using System.ServiceModel.Web;

[ServiceContract]
public interface IFactService
{
    [OperationContract]
    [WebGet(UriTemplate = "/getfact?category={category}",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
    string GetRandomFact(string category);

    [OperationContract]
    [WebGet(UriTemplate = "/categories",
            ResponseFormat = WebMessageFormat.Json)]
    string[] GetCategories();
}
