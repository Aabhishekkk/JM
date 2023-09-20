using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Students.StudentsSkillsRow>;
using MyRow = JSPM.Students.StudentsSkillsRow;

namespace JSPM.Students;

public interface IStudentsSkillsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class StudentsSkillsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IStudentsSkillsListHandler
{
    public StudentsSkillsListHandler(IRequestContext context)
            : base(context)
    {
    }
}