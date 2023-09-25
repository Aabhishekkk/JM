using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Jobs.JobsOpeningsRow;

namespace JSPM.Jobs;

public interface IJobsOpeningsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class JobsOpeningsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IJobsOpeningsDeleteHandler
{
    public JobsOpeningsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}