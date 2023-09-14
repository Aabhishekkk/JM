using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Students.TeacherEndorsementRow>;
using MyRow = JSPM.Students.TeacherEndorsementRow;

namespace JSPM.Students;

public interface ITeacherEndorsementListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TeacherEndorsementListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITeacherEndorsementListHandler
{
    public TeacherEndorsementListHandler(IRequestContext context)
            : base(context)
    {
    }
}