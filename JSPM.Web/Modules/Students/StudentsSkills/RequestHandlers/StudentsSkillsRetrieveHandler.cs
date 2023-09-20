using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Students.StudentsSkillsRow>;
using MyRow = JSPM.Students.StudentsSkillsRow;

namespace JSPM.Students;

public interface IStudentsSkillsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class StudentsSkillsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IStudentsSkillsRetrieveHandler
{
    public StudentsSkillsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}