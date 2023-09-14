using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Organisation.GroupRow>;
using MyRow = JSPM.Organisation.GroupRow;

namespace JSPM.Organisation;

public interface IGroupRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class GroupRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IGroupRetrieveHandler
{
    public GroupRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}