using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Students.PersonalRow;

namespace JSPM.Students;

public interface IPersonalDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class PersonalDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPersonalDeleteHandler
{
    public PersonalDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}