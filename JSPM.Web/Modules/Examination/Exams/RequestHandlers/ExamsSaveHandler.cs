using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Examination.ExamsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Examination.ExamsRow;

namespace JSPM.Examination;

public interface IExamsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ExamsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamsSaveHandler
{
    public ExamsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}