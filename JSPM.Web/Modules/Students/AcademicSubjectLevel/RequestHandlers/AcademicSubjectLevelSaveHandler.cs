using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Students.AcademicSubjectLevelRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Students.AcademicSubjectLevelRow;

namespace JSPM.Students;

public interface IAcademicSubjectLevelSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class AcademicSubjectLevelSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicSubjectLevelSaveHandler
{
    public AcademicSubjectLevelSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}