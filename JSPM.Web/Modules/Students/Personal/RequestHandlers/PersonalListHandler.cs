using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Students.PersonalRow>;
using MyRow = JSPM.Students.PersonalRow;

namespace JSPM.Students;

public interface IPersonalListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class PersonalListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPersonalListHandler
{
    public PersonalListHandler(IRequestContext context)
            : base(context)
    {
    }
}