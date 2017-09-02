using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace CrossPlatformTest.Pages
{
    public class HomePage
    {

        public Func<AppQuery, AppQuery> btnMore => x => x.Marked("More options");
        public Func<AppQuery, AppQuery> btnAdd => x => x.Text("Add");


        internal void ClickAdd()
        {
            Settings.AppContext.Tap(btnMore);
            Settings.AppContext.Tap(btnAdd);
        }
    }
}
