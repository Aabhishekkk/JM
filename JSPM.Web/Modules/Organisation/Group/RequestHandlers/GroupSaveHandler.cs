using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Organisation.GroupRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Organisation.GroupRow;

namespace JSPM.Organisation;

public interface IGroupSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class GroupSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGroupSaveHandler
{
    public GroupSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}