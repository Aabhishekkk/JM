using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Syllabus.TopicsRow>;
using MyRow = JSPM.Syllabus.TopicsRow;

namespace JSPM.Syllabus;

public interface ITopicsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TopicsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITopicsListHandler
{
    public TopicsListHandler(IRequestContext context)
            : base(context)
    {
    }
}