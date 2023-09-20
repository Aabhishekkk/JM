using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Students.StudentsSkillsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Students.StudentsSkillsRow;

namespace JSPM.Students;

public interface IStudentsSkillsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class StudentsSkillsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IStudentsSkillsSaveHandler
{
    public StudentsSkillsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}