using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Organisation.BatchesRow>;
using MyRow = JSPM.Organisation.BatchesRow;

namespace JSPM.Organisation;

public interface IBatchesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class BatchesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBatchesListHandler
{
    public BatchesListHandler(IRequestContext context)
            : base(context)
    {
    }
}