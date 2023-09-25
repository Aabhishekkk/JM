using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Examination.ExamsRow>;
using MyRow = JSPM.Examination.ExamsRow;

namespace JSPM.Examination;

public interface IExamsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ExamsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamsListHandler
{
    public ExamsListHandler(IRequestContext context)
            : base(context)
    {
    }
}