using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Syllabus.ChaptersRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Syllabus.ChaptersRow;

namespace JSPM.Syllabus;

public interface IChaptersSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ChaptersSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IChaptersSaveHandler
{
    public ChaptersSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}