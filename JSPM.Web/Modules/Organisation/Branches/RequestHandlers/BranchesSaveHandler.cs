using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Organisation.BranchesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Organisation.BranchesRow;

namespace JSPM.Organisation;

public interface IBranchesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class BranchesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBranchesSaveHandler
{
    public BranchesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}