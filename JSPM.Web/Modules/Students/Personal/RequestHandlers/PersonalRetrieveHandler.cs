using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Students.PersonalRow>;
using MyRow = JSPM.Students.PersonalRow;

namespace JSPM.Students;

public interface IPersonalRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class PersonalRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPersonalRetrieveHandler
{
    public PersonalRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}