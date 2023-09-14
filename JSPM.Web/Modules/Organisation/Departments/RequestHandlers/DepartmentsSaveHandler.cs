using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Organisation.DepartmentsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Organisation.DepartmentsRow;

namespace JSPM.Organisation;

public interface IDepartmentsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class DepartmentsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IDepartmentsSaveHandler
{
    public DepartmentsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}