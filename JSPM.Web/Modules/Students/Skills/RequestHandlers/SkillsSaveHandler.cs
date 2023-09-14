using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Students.SkillsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Students.SkillsRow;

namespace JSPM.Students;

public interface ISkillsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class SkillsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISkillsSaveHandler
{
    public SkillsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}