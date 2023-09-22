using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Examinations.ExamAttemptDetailsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Examinations.ExamAttemptDetailsRow;

namespace JSPM.Examinations;

public interface IExamAttemptDetailsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ExamAttemptDetailsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamAttemptDetailsSaveHandler
{
    public ExamAttemptDetailsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}