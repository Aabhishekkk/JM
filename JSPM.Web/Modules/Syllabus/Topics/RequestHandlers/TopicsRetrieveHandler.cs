using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Syllabus.TopicsRow>;
using MyRow = JSPM.Syllabus.TopicsRow;

namespace JSPM.Syllabus;

public interface ITopicsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TopicsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITopicsRetrieveHandler
{
    public TopicsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}