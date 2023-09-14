using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Organisation.AcademicYearsRow>;
using MyRow = JSPM.Organisation.AcademicYearsRow;

namespace JSPM.Organisation;

public interface IAcademicYearsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class AcademicYearsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicYearsRetrieveHandler
{
    public AcademicYearsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}