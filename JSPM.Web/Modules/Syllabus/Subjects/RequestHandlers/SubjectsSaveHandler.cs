using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Syllabus.SubjectsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Syllabus.SubjectsRow;

namespace JSPM.Syllabus;

public interface ISubjectsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class SubjectsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISubjectsSaveHandler
{
    public SubjectsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}