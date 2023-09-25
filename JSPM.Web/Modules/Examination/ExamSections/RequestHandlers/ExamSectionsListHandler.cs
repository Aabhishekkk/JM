using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Examination.ExamSectionsRow>;
using MyRow = JSPM.Examination.ExamSectionsRow;

namespace JSPM.Examination;

public interface IExamSectionsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ExamSectionsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamSectionsListHandler
{
    public ExamSectionsListHandler(IRequestContext context)
            : base(context)
    {
    }
}