using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Students.AcademicsRow>;
using MyRow = JSPM.Students.AcademicsRow;

namespace JSPM.Students;

public interface IAcademicsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class AcademicsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicsRetrieveHandler
{
    public AcademicsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}