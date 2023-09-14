using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Students.ProjectRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Students.ProjectRow;

namespace JSPM.Students;

public interface IProjectSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ProjectSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProjectSaveHandler
{
    public ProjectSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}