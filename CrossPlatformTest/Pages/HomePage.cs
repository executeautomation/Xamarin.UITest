using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Xamarin.UITest.Queries;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace CrossPlatformTest.Pages
{
    public class HomePage
    {

        public Query btnMore => x => x.Marked("More options");
        public Query btnAdd => x => x.Text("Add");
        public Query txtEA => x => x.Text("EA");


        internal void ClickAdd()
        {
            Settings.AppContext.Tap(btnMore);
            Settings.AppContext.Tap(btnAdd);
        }

        internal void WaitForListElement()
        {
            Settings.AppContext.WaitForElement(txtEA);
        }

        internal int GetElementCount()
        {
            return Settings.AppContext.Query(x => x.Id("recyclerView").All().Text("EA")).Count();
        }
    }
}
