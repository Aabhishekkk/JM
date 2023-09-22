using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Examinations.ExamSectionsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Examinations.ExamSectionsRow;

namespace JSPM.Examinations;

public interface IExamSectionsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ExamSectionsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamSectionsSaveHandler
{
    public ExamSectionsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}