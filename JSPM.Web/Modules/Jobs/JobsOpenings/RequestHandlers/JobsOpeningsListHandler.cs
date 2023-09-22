using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Jobs.JobsOpeningsRow>;
using MyRow = JSPM.Jobs.JobsOpeningsRow;

namespace JSPM.Jobs;

public interface IJobsOpeningsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class JobsOpeningsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IJobsOpeningsListHandler
{
    public JobsOpeningsListHandler(IRequestContext context)
            : base(context)
    {
    }
}