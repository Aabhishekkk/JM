using Serenity.Services;
using MyRequest = JSPM.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Administration.UserRow>;
using MyRow = JSPM.Administration.UserRow;

namespace JSPM.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}