using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Examinations.ExamAttemptDetailsRow>;
using MyRow = JSPM.Examinations.ExamAttemptDetailsRow;

namespace JSPM.Examinations;

public interface IExamAttemptDetailsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ExamAttemptDetailsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamAttemptDetailsRetrieveHandler
{
    public ExamAttemptDetailsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}