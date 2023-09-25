using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Examination.ExamQuestionsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Examination.ExamQuestionsRow;

namespace JSPM.Examination;

public interface IExamQuestionsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ExamQuestionsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamQuestionsSaveHandler
{
    public ExamQuestionsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}