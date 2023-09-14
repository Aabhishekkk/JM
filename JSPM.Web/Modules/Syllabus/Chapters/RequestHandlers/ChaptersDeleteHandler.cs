using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Syllabus.ChaptersRow;

namespace JSPM.Syllabus;

public interface IChaptersDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ChaptersDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IChaptersDeleteHandler
{
    public ChaptersDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}