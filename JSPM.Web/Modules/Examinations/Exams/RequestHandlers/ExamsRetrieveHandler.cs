using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Examinations.ExamsRow>;
using MyRow = JSPM.Examinations.ExamsRow;

namespace JSPM.Examinations;

public interface IExamsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ExamsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamsRetrieveHandler
{
    public ExamsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}