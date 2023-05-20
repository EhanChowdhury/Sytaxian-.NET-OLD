using Sytaxian.Properties;
using EasyTabs;

namespace Sytaxian
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();
            AeroPeekEnabled = false;
            TabRenderer = new ChromeTabRenderer(this);
            Text = "Sytaxian";
            Icon = Resources.Sytaxian__2_;
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new Sytaxian { Text = "New Tab"}
            };
        }
    }
}
