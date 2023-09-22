using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Examinations.ExamQuestionsRow>;
using MyRow = JSPM.Examinations.ExamQuestionsRow;

namespace JSPM.Examinations;

public interface IExamQuestionsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ExamQuestionsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamQuestionsListHandler
{
    public ExamQuestionsListHandler(IRequestContext context)
            : base(context)
    {
    }
}