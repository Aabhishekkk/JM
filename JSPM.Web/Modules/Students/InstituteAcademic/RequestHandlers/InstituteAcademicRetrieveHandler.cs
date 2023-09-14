using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Students.InstituteAcademicRow>;
using MyRow = JSPM.Students.InstituteAcademicRow;

namespace JSPM.Students;

public interface IInstituteAcademicRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class InstituteAcademicRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteAcademicRetrieveHandler
{
    public InstituteAcademicRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}