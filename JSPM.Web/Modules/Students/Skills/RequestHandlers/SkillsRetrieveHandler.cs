using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Students.SkillsRow>;
using MyRow = JSPM.Students.SkillsRow;

namespace JSPM.Students;

public interface ISkillsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class SkillsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISkillsRetrieveHandler
{
    public SkillsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}