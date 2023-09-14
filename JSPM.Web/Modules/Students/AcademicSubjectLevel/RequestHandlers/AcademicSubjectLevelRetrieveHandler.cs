using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Students.AcademicSubjectLevelRow>;
using MyRow = JSPM.Students.AcademicSubjectLevelRow;

namespace JSPM.Students;

public interface IAcademicSubjectLevelRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class AcademicSubjectLevelRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicSubjectLevelRetrieveHandler
{
    public AcademicSubjectLevelRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}