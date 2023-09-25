using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Examination.ExamAttemptDetailsRow;

namespace JSPM.Examination;

public interface IExamAttemptDetailsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ExamAttemptDetailsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExamAttemptDetailsDeleteHandler
{
    public ExamAttemptDetailsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}