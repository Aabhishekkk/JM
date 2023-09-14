using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Students.ProjectRow>;
using MyRow = JSPM.Students.ProjectRow;

namespace JSPM.Students;

public interface IProjectListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ProjectListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProjectListHandler
{
    public ProjectListHandler(IRequestContext context)
            : base(context)
    {
    }
}