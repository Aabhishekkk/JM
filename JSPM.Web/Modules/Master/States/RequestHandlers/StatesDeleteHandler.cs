using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Master.StatesRow;

namespace JSPM.Master;

public interface IStatesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class StatesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IStatesDeleteHandler
{
    public StatesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}