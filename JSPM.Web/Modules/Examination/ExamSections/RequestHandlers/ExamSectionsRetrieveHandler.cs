using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Examination.ExamSectionsRow>;
using MyRow = JSPM.Examination.ExamSectionsRow;

namespace JSPM.Examination;

public interface IExamSectionsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ExamSectionsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamSectionsRetrieveHandler
{
    public ExamSectionsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}