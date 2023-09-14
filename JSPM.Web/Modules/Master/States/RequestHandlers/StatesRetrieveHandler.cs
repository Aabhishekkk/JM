using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Master.StatesRow>;
using MyRow = JSPM.Master.StatesRow;

namespace JSPM.Master;

public interface IStatesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class StatesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IStatesRetrieveHandler
{
    public StatesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}