#if IOS
using Drastic.IQKeyboardManager;
#endif

namespace IQKeyboardManagerIssue;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();

#if IOS
        IQKeyboardManager.SharedManager().Enable = true;
        IQKeyboardManager.SharedManager().ShouldResignOnTouchOutside = true;
        IQKeyboardManager.SharedManager().ToolbarManageBehaviour = IQAutoToolbarManageBehaviour.Position;
        IQKeyboardManager.SharedManager().EnableAutoToolbar = true;
        IQKeyboardManager.SharedManager().ShouldShowToolbarPlaceholder = true;
#endif
    }
}