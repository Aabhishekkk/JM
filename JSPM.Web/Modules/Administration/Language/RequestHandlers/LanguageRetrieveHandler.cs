using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Administration.LanguageRow>;
using MyRow = JSPM.Administration.LanguageRow;


namespace JSPM.Administration
{
    public interface ILanguageRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageRetrieveHandler
    {
        public LanguageRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}