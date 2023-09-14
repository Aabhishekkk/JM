using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Organisation.BatchesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Organisation.BatchesRow;

namespace JSPM.Organisation;

public interface IBatchesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class BatchesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBatchesSaveHandler
{
    public BatchesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}