using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Organisation.DivisionRow>;
using MyRow = JSPM.Organisation.DivisionRow;

namespace JSPM.Organisation;

public interface IDivisionListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class DivisionListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IDivisionListHandler
{
    public DivisionListHandler(IRequestContext context)
            : base(context)
    {
    }
}