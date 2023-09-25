using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Examination.Columns;

[ColumnsScript("Examination.ExamSections")]
[BasedOnRow(typeof(ExamSectionsRow), CheckNames = true)]
public class ExamSectionsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public string ExamName { get; set; }
    public string Instructions { get; set; }
    public int SectionDurationInSeconds { get; set; }
    public int NumberOfQuestions { get; set; }
    public int NumberofMandatoryQuestions { get; set; }
}