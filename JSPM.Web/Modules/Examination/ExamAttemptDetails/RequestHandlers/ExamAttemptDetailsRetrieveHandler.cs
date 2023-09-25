using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Examination.ExamAttemptDetailsRow>;
using MyRow = JSPM.Examination.ExamAttemptDetailsRow;

namespace JSPM.Examination;

public interface IExamAttemptDetailsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ExamAttemptDetailsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamAttemptDetailsRetrieveHandler
{
    public ExamAttemptDetailsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}