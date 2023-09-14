using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = JSPM.Syllabus.SubjectsRow;

namespace JSPM.Syllabus;

public interface ISubjectsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class SubjectsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISubjectsDeleteHandler
{
    public SubjectsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}