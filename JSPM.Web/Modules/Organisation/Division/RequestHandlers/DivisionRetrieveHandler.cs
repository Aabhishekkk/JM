using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Organisation.DivisionRow>;
using MyRow = JSPM.Organisation.DivisionRow;

namespace JSPM.Organisation;

public interface IDivisionRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class DivisionRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IDivisionRetrieveHandler
{
    public DivisionRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}