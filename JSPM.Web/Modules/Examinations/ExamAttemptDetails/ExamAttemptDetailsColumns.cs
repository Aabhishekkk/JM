﻿using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Examinations.Columns;

[ColumnsScript("Examinations.ExamAttemptDetails")]
[BasedOnRow(typeof(ExamAttemptDetailsRow), CheckNames = true)]
public class ExamAttemptDetailsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string ExamQuestionQuestionNumber { get; set; }
    public int NumberofAttempts { get; set; }
    public string BranchName { get; set; }
}