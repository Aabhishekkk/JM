using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Organisation.BranchesRow;

namespace JSPM.Organisation;

public interface IBranchesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class BranchesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IBranchesDeleteHandler
{
    public BranchesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}