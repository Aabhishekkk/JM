using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Organisation.BatchesRow>;
using MyRow = JSPM.Organisation.BatchesRow;

namespace JSPM.Organisation;

public interface IBatchesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class BatchesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBatchesRetrieveHandler
{
    public BatchesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}