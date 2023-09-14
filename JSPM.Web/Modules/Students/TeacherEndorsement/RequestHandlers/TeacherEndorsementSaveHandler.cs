using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Students.TeacherEndorsementRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Students.TeacherEndorsementRow;

namespace JSPM.Students;

public interface ITeacherEndorsementSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TeacherEndorsementSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITeacherEndorsementSaveHandler
{
    public TeacherEndorsementSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}