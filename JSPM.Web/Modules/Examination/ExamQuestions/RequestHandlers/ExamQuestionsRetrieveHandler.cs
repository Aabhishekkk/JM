using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Examination.ExamQuestionsRow>;
using MyRow = JSPM.Examination.ExamQuestionsRow;

namespace JSPM.Examination;

public interface IExamQuestionsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ExamQuestionsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamQuestionsRetrieveHandler
{
    public ExamQuestionsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}