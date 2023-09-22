using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Examinations.ExamSectionsRow>;
using MyRow = JSPM.Examinations.ExamSectionsRow;

namespace JSPM.Examinations;

public interface IExamSectionsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ExamSectionsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamSectionsListHandler
{
    public ExamSectionsListHandler(IRequestContext context)
            : base(context)
    {
    }
}