using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Organisation.InstituteRow>;
using MyRow = JSPM.Organisation.InstituteRow;

namespace JSPM.Organisation;

public interface IInstituteRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class InstituteRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteRetrieveHandler
{
    public InstituteRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}