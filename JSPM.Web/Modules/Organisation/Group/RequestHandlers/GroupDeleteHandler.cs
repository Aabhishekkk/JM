using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Organisation.GroupRow;

namespace JSPM.Organisation;

public interface IGroupDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class GroupDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IGroupDeleteHandler
{
    public GroupDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}