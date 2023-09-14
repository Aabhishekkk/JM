using Serenity.Navigation;
using MyPages = JSPM.Syllabus.Pages;

[assembly: NavigationLink(int.MaxValue, "Syllabus/Subjects", typeof(MyPages.SubjectsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Syllabus/Chapters", typeof(MyPages.ChaptersPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Syllabus/Topics", typeof(MyPages.TopicsPage), icon: null)]