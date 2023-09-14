using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Master.StatesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Master.StatesRow;

namespace JSPM.Master;

public interface IStatesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class StatesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IStatesSaveHandler
{
    public StatesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}