using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<JSPM.Syllabus.SubjectsRow>;
using MyRow = JSPM.Syllabus.SubjectsRow;

namespace JSPM.Syllabus;

public interface ISubjectsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class SubjectsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISubjectsRetrieveHandler
{
    public SubjectsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}