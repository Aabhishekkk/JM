using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Students.AcademicRow>;
using MyRow = JSPM.Students.AcademicRow;

namespace JSPM.Students;

public interface IAcademicRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class AcademicRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicRetrieveHandler
{
    public AcademicRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}