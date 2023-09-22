using Serenity.Navigation;
using MyPages = JSPM.Examinations.Pages;

[assembly: NavigationLink(int.MaxValue, "Examinations/Exam Attempt Details", typeof(MyPages.ExamAttemptDetailsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Examinations/Exam Questions", typeof(MyPages.ExamQuestionsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Examinations/Exams", typeof(MyPages.ExamsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Examinations/Exam Sections", typeof(MyPages.ExamSectionsPage), icon: null)]