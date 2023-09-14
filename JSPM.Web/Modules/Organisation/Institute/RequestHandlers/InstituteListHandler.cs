using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Organisation.InstituteRow>;
using MyRow = JSPM.Organisation.InstituteRow;

namespace JSPM.Organisation;

public interface IInstituteListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class InstituteListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteListHandler
{
    public InstituteListHandler(IRequestContext context)
            : base(context)
    {
    }
}