using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Students.AcademicRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Students.AcademicRow;

namespace JSPM.Students;

public interface IAcademicSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class AcademicSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicSaveHandler
{
    public AcademicSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}