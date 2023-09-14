using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Students.SkillsRow>;
using MyRow = JSPM.Students.SkillsRow;

namespace JSPM.Students;

public interface ISkillsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class SkillsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISkillsListHandler
{
    public SkillsListHandler(IRequestContext context)
            : base(context)
    {
    }
}