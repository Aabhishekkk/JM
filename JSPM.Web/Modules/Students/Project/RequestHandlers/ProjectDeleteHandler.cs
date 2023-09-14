using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Students.ProjectRow;

namespace JSPM.Students;

public interface IProjectDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ProjectDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProjectDeleteHandler
{
    public ProjectDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}