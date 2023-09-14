using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Organisation.GroupRow>;
using MyRow = JSPM.Organisation.GroupRow;

namespace JSPM.Organisation;

public interface IGroupListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class GroupListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IGroupListHandler
{
    public GroupListHandler(IRequestContext context)
            : base(context)
    {
    }
}