using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Administration.RoleRow>;
using MyRow = JSPM.Administration.RoleRow;


namespace JSPM.Administration
{
    public interface IRoleRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
    public class RoleRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleRetrieveHandler
    {
        public RoleRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}