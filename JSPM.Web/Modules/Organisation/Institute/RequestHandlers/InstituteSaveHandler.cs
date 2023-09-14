using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Organisation.InstituteRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Organisation.InstituteRow;

namespace JSPM.Organisation;

public interface IInstituteSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class InstituteSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteSaveHandler
{
    public InstituteSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}