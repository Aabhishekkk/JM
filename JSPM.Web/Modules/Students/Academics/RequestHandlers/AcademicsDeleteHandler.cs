using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Students.AcademicsRow;

namespace JSPM.Students;

public interface IAcademicsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class AcademicsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicsDeleteHandler
{
    public AcademicsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}