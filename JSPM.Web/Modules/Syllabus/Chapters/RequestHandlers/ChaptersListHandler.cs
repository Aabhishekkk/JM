using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Syllabus.ChaptersRow>;
using MyRow = JSPM.Syllabus.ChaptersRow;

namespace JSPM.Syllabus;

public interface IChaptersListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ChaptersListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IChaptersListHandler
{
    public ChaptersListHandler(IRequestContext context)
            : base(context)
    {
    }
}