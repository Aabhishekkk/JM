using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Organisation.BranchesRow>;
using MyRow = JSPM.Organisation.BranchesRow;

namespace JSPM.Organisation;

public interface IBranchesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class BranchesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBranchesRetrieveHandler
{
    public BranchesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}