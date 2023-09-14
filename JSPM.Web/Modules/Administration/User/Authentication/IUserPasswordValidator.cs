namespace JSPM.Administration
{
    public interface IUserPasswordValidator
    {
        PasswordValidationResult Validate(ref string username, string password);
    }
}