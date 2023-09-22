using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Examinations.ExamAttemptDetailsRow>;
using MyRow = JSPM.Examinations.ExamAttemptDetailsRow;

namespace JSPM.Examinations;

public interface IExamAttemptDetailsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ExamAttemptDetailsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamAttemptDetailsListHandler
{
    public ExamAttemptDetailsListHandler(IRequestContext context)
            : base(context)
    {
    }
}