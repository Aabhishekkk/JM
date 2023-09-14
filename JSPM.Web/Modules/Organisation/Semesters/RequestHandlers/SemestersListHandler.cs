using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Organisation.SemestersRow>;
using MyRow = JSPM.Organisation.SemestersRow;

namespace JSPM.Organisation;

public interface ISemestersListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class SemestersListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISemestersListHandler
{
    public SemestersListHandler(IRequestContext context)
            : base(context)
    {
    }
}