using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Jobs.JobsOpeningsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Jobs.JobsOpeningsRow;

namespace JSPM.Jobs;

public interface IJobsOpeningsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class JobsOpeningsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IJobsOpeningsSaveHandler
{
    public JobsOpeningsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}