using Serenity.Navigation;
using MyPages = JSPM.Examination.Pages;

[assembly: NavigationLink(int.MaxValue, "Examination/Exam Attempt Details", typeof(MyPages.ExamAttemptDetailsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Examination/Exam Questions", typeof(MyPages.ExamQuestionsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Examination/Exams", typeof(MyPages.ExamsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Examination/Exam Sections", typeof(MyPages.ExamSectionsPage), icon: null)]