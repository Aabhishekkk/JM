using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Students.AcademicRow>;
using MyRow = JSPM.Students.AcademicRow;

namespace JSPM.Students;

public interface IAcademicListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class AcademicListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicListHandler
{
    public AcademicListHandler(IRequestContext context)
            : base(context)
    {
    }
}