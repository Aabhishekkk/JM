using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Students.AcademicSubjectLevelRow>;
using MyRow = JSPM.Students.AcademicSubjectLevelRow;

namespace JSPM.Students;

public interface IAcademicSubjectLevelListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class AcademicSubjectLevelListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicSubjectLevelListHandler
{
    public AcademicSubjectLevelListHandler(IRequestContext context)
            : base(context)
    {
    }
}