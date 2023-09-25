using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Examination.ExamQuestionsRow>;
using MyRow = JSPM.Examination.ExamQuestionsRow;

namespace JSPM.Examination;

public interface IExamQuestionsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ExamQuestionsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamQuestionsListHandler
{
    public ExamQuestionsListHandler(IRequestContext context)
            : base(context)
    {
    }
}