using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Students.AcademicSubjectLevelRow;

namespace JSPM.Students;

public interface IAcademicSubjectLevelDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class AcademicSubjectLevelDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicSubjectLevelDeleteHandler
{
    public AcademicSubjectLevelDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}