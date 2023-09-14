using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Master.SkillsRow>;
using MyRow = JSPM.Master.SkillsRow;

namespace JSPM.Master;

public interface ISkillsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class SkillsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISkillsListHandler
{
    public SkillsListHandler(IRequestContext context)
            : base(context)
    {
    }
}