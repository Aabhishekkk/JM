using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Master.SkillsRow>;
using MyRow = JSPM.Master.SkillsRow;

namespace JSPM.Master;

public interface ISkillsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class SkillsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISkillsRetrieveHandler
{
    public SkillsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}