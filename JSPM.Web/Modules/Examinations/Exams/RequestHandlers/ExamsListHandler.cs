using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Examinations.ExamsRow>;
using MyRow = JSPM.Examinations.ExamsRow;

namespace JSPM.Examinations;

public interface IExamsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ExamsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamsListHandler
{
    public ExamsListHandler(IRequestContext context)
            : base(context)
    {
    }
}