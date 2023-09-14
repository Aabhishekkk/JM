using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Syllabus.ChaptersRow>;
using MyRow = JSPM.Syllabus.ChaptersRow;

namespace JSPM.Syllabus;

public interface IChaptersRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ChaptersRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IChaptersRetrieveHandler
{
    public ChaptersRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}