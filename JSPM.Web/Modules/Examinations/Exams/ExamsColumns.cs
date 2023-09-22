using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace JSPM.Examinations.Columns;

[ColumnsScript("Examinations.Exams")]
[BasedOnRow(typeof(ExamsRow), CheckNames = true)]
public class ExamsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public Guid Id { get; set; }
    [EditLink]
    public string ExamName { get; set; }
    public string ExamInstructions { get; set; }
}