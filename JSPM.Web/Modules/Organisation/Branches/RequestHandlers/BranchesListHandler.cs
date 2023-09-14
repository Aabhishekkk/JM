using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Organisation.BranchesRow>;
using MyRow = JSPM.Organisation.BranchesRow;

namespace JSPM.Organisation;

public interface IBranchesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class BranchesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBranchesListHandler
{
    public BranchesListHandler(IRequestContext context)
            : base(context)
    {
    }
}