using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Jobs.JobsOpeningsRow>;
using MyRow = JSPM.Jobs.JobsOpeningsRow;

namespace JSPM.Jobs;

public interface IJobsOpeningsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class JobsOpeningsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IJobsOpeningsRetrieveHandler
{
    public JobsOpeningsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}