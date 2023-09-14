using Serenity.Navigation;
using MyPages = JSPM.Master.Pages;

[assembly: NavigationLink(int.MaxValue, "Master/States", typeof(MyPages.StatesPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Master/Skills", typeof(MyPages.SkillsPage), icon: null)]