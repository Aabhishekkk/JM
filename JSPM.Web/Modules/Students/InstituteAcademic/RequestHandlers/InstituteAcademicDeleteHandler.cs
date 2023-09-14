using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Students.InstituteAcademicRow;

namespace JSPM.Students;

public interface IInstituteAcademicDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class InstituteAcademicDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteAcademicDeleteHandler
{
    public InstituteAcademicDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}