using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Students.AcademicRow;

namespace JSPM.Students;

public interface IAcademicDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class AcademicDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicDeleteHandler
{
    public AcademicDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}