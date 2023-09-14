using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Master.StatesRow>;
using MyRow = JSPM.Master.StatesRow;

namespace JSPM.Master;

public interface IStatesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class StatesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IStatesListHandler
{
    public StatesListHandler(IRequestContext context)
            : base(context)
    {
    }
}