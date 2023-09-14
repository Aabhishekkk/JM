using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Students.TeacherEndorsementRow;

namespace JSPM.Students;

public interface ITeacherEndorsementDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TeacherEndorsementDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITeacherEndorsementDeleteHandler
{
    public TeacherEndorsementDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}