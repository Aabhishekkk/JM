using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Examination.ExamAttemptDetailsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Examination.ExamAttemptDetailsRow;

namespace JSPM.Examination;

public interface IExamAttemptDetailsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ExamAttemptDetailsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamAttemptDetailsSaveHandler
{
    public ExamAttemptDetailsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}