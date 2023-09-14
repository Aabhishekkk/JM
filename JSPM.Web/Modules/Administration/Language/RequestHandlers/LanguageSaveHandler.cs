using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Administration.LanguageRow;


namespace JSPM.Administration
{
    public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
    {
        public LanguageSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}