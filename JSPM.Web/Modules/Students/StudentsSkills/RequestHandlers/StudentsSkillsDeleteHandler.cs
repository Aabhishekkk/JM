using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Students.StudentsSkillsRow;

namespace JSPM.Students;

public interface IStudentsSkillsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class StudentsSkillsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IStudentsSkillsDeleteHandler
{
    public StudentsSkillsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}