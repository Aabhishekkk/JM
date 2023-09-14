using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<JSPM.Syllabus.SubjectsRow>;
using MyRow = JSPM.Syllabus.SubjectsRow;

namespace JSPM.Syllabus;

public interface ISubjectsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class SubjectsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISubjectsListHandler
{
    public SubjectsListHandler(IRequestContext context)
            : base(context)
    {
    }
}