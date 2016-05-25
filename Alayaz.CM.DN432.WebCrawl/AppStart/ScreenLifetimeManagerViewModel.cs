using Alayaz.Graph.WPF.Common;
using Caliburn.Micro;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Configuration;

namespace Alayaz.CM.DN432.WebCrawl.ViewModels
{
    //public class ShellViewModel : Screen, IShell
    [Export(typeof(IShell))]
    public class ScreenLifetimeManagerViewModel : Conductor<object>, IShell
    {
        readonly CrawlViewModel screen1;
        readonly LoginViewModel screen2;
        readonly Screen initialialScreen;
        readonly Stack<object> previous = new Stack<object>();
        bool goingBack;
        [ImportingConstructor]
        public ScreenLifetimeManagerViewModel(CrawlViewModel screen1, LoginViewModel screen2)
        {
            this.WindowTitle = string.IsNullOrEmpty(ConfigurationManager.AppSettings.Get("WindowTitle")) ? this.GetType().FullName : ConfigurationManager.AppSettings.Get("WindowTitle");

            this.initialialScreen = !string.IsNullOrEmpty(GlobalData.PWD) ? (Screen)screen1 : (Screen)screen2;

          //  GlobalData.ImpInvViewModel.BootMode
        }

        private string windowTitle;
        public string WindowTitle
        {
            get { return windowTitle; }

            set
            {
                windowTitle = value;
                NotifyOfPropertyChange(() => WindowTitle);
            }
        }
        public bool CanGoBack
        {
            get { return previous.Count > 0; }
        }

        /// <summary>
        /// “¿¿µ”⁄ StartScreenViewModel
        /// </summary>
        protected override void OnInitialize()
        {
            ActivateItem(initialialScreen);

            // new MainWindow().ShowDialog();
            base.OnInitialize();
        }

        protected override void ChangeActiveItem(object newItem, bool closePrevious)
        {
            if (ActiveItem != null && !goingBack)
                previous.Push(ActiveItem);

            NotifyOfPropertyChange(() => CanGoBack);

            base.ChangeActiveItem(newItem, closePrevious);
        }

        //WindowTitle


        public void GoBack()
        {
            goingBack = true;
            ActivateItem(previous.Pop());
            goingBack = false;
        }




    }
}