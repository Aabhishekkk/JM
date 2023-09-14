using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Organisation.DivisionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Organisation.DivisionRow;

namespace JSPM.Organisation;

public interface IDivisionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class DivisionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IDivisionSaveHandler
{
    public DivisionSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}