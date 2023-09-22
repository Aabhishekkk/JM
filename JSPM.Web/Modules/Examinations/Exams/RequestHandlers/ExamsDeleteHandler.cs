using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Examinations.ExamsRow;

namespace JSPM.Examinations;

public interface IExamsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ExamsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExamsDeleteHandler
{
    public ExamsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}