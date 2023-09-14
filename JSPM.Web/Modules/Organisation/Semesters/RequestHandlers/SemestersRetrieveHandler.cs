using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Organisation.SemestersRow>;
using MyRow = JSPM.Organisation.SemestersRow;

namespace JSPM.Organisation;

public interface ISemestersRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class SemestersRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISemestersRetrieveHandler
{
    public SemestersRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}