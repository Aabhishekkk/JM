using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Examinations.ExamQuestionsRow;

namespace JSPM.Examinations;

public interface IExamQuestionsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ExamQuestionsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExamQuestionsDeleteHandler
{
    public ExamQuestionsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}