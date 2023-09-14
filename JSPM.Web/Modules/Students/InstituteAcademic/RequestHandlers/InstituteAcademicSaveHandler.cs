using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Students.InstituteAcademicRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Students.InstituteAcademicRow;

namespace JSPM.Students;

public interface IInstituteAcademicSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class InstituteAcademicSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteAcademicSaveHandler
{
    public InstituteAcademicSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}