using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace CrossPlatformTest.Pages
{
    class AddItemPage
    {

        public Query txtTitle => x => x.Id("txtTitle");
        public Query txtDescription => x => x.Id("txtDesc");
        public Query btnSave => x => x.Id("save_button");


        internal void AddItem(string title, string description)
        {
            Settings.AppContext.EnterText(txtTitle, title);
            Settings.AppContext.DismissKeyboard();
            Settings.AppContext.EnterText(txtDescription, description);
            Settings.AppContext.DismissKeyboard();

            //Back door demo commented, for Xamarin Cloud demo
            //BackDoorInvoke();

            Settings.AppContext.Tap(btnSave);
        }

        internal void BackDoorInvoke()
        {
            Settings.AppContext.Invoke("BackDoorDemo");
        }
    }
}
