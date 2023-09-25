using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Examination.ExamsRow>;
using MyRow = JSPM.Examination.ExamsRow;

namespace JSPM.Examination;

public interface IExamsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ExamsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamsRetrieveHandler
{
    public ExamsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}