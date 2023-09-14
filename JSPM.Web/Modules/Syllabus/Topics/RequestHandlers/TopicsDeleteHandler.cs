using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Syllabus.TopicsRow;

namespace JSPM.Syllabus;

public interface ITopicsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TopicsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITopicsDeleteHandler
{
    public TopicsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}