using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<JSPM.Examination.ExamSectionsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = JSPM.Examination.ExamSectionsRow;

namespace JSPM.Examination;

public interface IExamSectionsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ExamSectionsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamSectionsSaveHandler
{
    public ExamSectionsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}