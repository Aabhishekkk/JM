using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Organisation.AcademicYearsRow>;
using MyRow = JSPM.Organisation.AcademicYearsRow;

namespace JSPM.Organisation;

public interface IAcademicYearsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class AcademicYearsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicYearsListHandler
{
    public AcademicYearsListHandler(IRequestContext context)
            : base(context)
    {
    }
}