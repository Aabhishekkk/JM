using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Organisation.BatchesRow;

namespace JSPM.Organisation;

public interface IBatchesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class BatchesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IBatchesDeleteHandler
{
    public BatchesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}