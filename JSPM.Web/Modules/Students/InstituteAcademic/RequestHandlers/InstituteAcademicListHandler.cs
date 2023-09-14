using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Students.InstituteAcademicRow>;
using MyRow = JSPM.Students.InstituteAcademicRow;

namespace JSPM.Students;

public interface IInstituteAcademicListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class InstituteAcademicListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteAcademicListHandler
{
    public InstituteAcademicListHandler(IRequestContext context)
            : base(context)
    {
    }
}