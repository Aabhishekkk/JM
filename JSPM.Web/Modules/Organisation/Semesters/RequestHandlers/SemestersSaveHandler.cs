using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Organisation.SemestersRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Organisation.SemestersRow;

namespace JSPM.Organisation;

public interface ISemestersSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class SemestersSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISemestersSaveHandler
{
    public SemestersSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}