using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Students.AcademicsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Students.AcademicsRow;

namespace JSPM.Students;

public interface IAcademicsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class AcademicsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicsSaveHandler
{
    public AcademicsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}