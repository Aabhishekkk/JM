using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Examination.ExamAttemptDetailsRow>;
using MyRow = JSPM.Examination.ExamAttemptDetailsRow;

namespace JSPM.Examination;

public interface IExamAttemptDetailsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ExamAttemptDetailsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamAttemptDetailsListHandler
{
    public ExamAttemptDetailsListHandler(IRequestContext context)
            : base(context)
    {
    }
}