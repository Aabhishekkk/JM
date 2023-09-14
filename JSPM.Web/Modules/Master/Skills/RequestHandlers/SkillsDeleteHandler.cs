using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Master.SkillsRow;

namespace JSPM.Master;

public interface ISkillsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class SkillsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISkillsDeleteHandler
{
    public SkillsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}