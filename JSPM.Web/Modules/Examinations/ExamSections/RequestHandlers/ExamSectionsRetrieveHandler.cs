using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Examinations.ExamSectionsRow>;
using MyRow = JSPM.Examinations.ExamSectionsRow;

namespace JSPM.Examinations;

public interface IExamSectionsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ExamSectionsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamSectionsRetrieveHandler
{
    public ExamSectionsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}