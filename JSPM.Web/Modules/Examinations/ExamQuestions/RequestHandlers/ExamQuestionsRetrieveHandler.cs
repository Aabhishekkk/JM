using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Examinations.ExamQuestionsRow>;
using MyRow = JSPM.Examinations.ExamQuestionsRow;

namespace JSPM.Examinations;

public interface IExamQuestionsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ExamQuestionsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamQuestionsRetrieveHandler
{
    public ExamQuestionsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}