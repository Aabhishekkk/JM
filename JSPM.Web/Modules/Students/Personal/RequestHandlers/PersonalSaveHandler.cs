using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Students.PersonalRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Students.PersonalRow;

namespace JSPM.Students;

public interface IPersonalSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class PersonalSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPersonalSaveHandler
{
    public PersonalSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}