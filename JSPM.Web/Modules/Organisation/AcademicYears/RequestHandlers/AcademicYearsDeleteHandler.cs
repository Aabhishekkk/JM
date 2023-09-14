using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Organisation.AcademicYearsRow;

namespace JSPM.Organisation;

public interface IAcademicYearsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class AcademicYearsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicYearsDeleteHandler
{
    public AcademicYearsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}