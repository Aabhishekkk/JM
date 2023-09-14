using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Syllabus.TopicsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Syllabus.TopicsRow;

namespace JSPM.Syllabus;

public interface ITopicsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TopicsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITopicsSaveHandler
{
    public TopicsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}