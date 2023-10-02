using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Students.AcademicsRow>;
using MyRow = JSPM.Students.AcademicsRow;

namespace JSPM.Students;

public interface IAcademicsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class AcademicsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicsListHandler
{
    public AcademicsListHandler(IRequestContext context)
            : base(context)
    {
    }
}