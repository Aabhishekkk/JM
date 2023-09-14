using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Students.ProjectRow>;
using MyRow = JSPM.Students.ProjectRow;

namespace JSPM.Students;

public interface IProjectRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ProjectRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProjectRetrieveHandler
{
    public ProjectRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}