using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Administration.UserRow>;
using MyRow = JSPM.Administration.UserRow;


namespace JSPM.Administration
{
    public interface IUserRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
    public class UserRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IUserRetrieveHandler
    {
        public UserRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}