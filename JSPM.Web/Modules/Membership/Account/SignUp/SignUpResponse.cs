using Serenity.Services;

namespace JSPM.Membership
{
    public class SignUpResponse : ServiceResponse
    {
        public string DemoActivationLink { get; set; }
    }
}