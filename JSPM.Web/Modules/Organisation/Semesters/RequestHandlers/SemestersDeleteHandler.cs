using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Organisation.SemestersRow;

namespace JSPM.Organisation;

public interface ISemestersDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class SemestersDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISemestersDeleteHandler
{
    public SemestersDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}