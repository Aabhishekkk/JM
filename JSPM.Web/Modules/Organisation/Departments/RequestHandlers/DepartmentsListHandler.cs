using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Organisation.DepartmentsRow>;
using MyRow = JSPM.Organisation.DepartmentsRow;

namespace JSPM.Organisation;

public interface IDepartmentsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class DepartmentsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IDepartmentsListHandler
{
    public DepartmentsListHandler(IRequestContext context)
            : base(context)
    {
    }
}