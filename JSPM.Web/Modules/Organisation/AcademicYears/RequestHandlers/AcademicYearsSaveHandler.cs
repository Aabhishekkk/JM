using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Organisation.AcademicYearsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Organisation.AcademicYearsRow;

namespace JSPM.Organisation;

public interface IAcademicYearsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class AcademicYearsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicYearsSaveHandler
{
    public AcademicYearsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}