namespace ClubManagementWeb
{
    public class ValidationService : IValidationService
    {
        public string Validate(string input, string type)
        {
            return KeenanValidator.GetValidationMessage(input, type);
        }
    }
}