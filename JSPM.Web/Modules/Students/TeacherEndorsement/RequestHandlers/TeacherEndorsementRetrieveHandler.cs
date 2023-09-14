using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Students.TeacherEndorsementRow>;
using MyRow = JSPM.Students.TeacherEndorsementRow;

namespace JSPM.Students;

public interface ITeacherEndorsementRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TeacherEndorsementRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITeacherEndorsementRetrieveHandler
{
    public TeacherEndorsementRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}