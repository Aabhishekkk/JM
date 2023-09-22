using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Examinations.ExamSectionsRow;

namespace JSPM.Examinations;

public interface IExamSectionsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ExamSectionsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExamSectionsDeleteHandler
{
    public ExamSectionsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}