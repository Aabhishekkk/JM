using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Organisation.DepartmentsRow>;
using MyRow = JSPM.Organisation.DepartmentsRow;

namespace JSPM.Organisation;

public interface IDepartmentsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class DepartmentsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IDepartmentsRetrieveHandler
{
    public DepartmentsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}