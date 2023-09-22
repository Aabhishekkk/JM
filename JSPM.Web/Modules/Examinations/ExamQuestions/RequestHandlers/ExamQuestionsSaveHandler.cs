using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Examinations.ExamQuestionsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Examinations.ExamQuestionsRow;

namespace JSPM.Examinations;

public interface IExamQuestionsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ExamQuestionsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamQuestionsSaveHandler
{
    public ExamQuestionsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}