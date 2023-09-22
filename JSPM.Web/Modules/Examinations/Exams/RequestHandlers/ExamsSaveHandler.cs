using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Examinations.ExamsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Examinations.ExamsRow;

namespace JSPM.Examinations;

public interface IExamsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ExamsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamsSaveHandler
{
    public ExamsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}