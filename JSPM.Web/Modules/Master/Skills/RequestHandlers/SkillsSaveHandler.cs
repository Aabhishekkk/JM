using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Master.SkillsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Master.SkillsRow;

namespace JSPM.Master;

public interface ISkillsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class SkillsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISkillsSaveHandler
{
    public SkillsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}