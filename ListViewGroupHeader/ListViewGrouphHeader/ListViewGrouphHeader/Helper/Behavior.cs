using Syncfusion.DataSource;
using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Grouping
{
   public class Behavior : Behavior<SfListView>
    {
        SfListView ListView;
        protected override void OnAttachedTo(SfListView bindable)
        {
            ListView = bindable;
            ListView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
            {
                PropertyName = "ContactName",
                KeySelector = (object obj1) =>
                {
                    var item = (obj1 as Contacts);
                    return item.ContactName[0].ToString();
                },
            });
            ListView.Loaded += ListView_Loaded;
            ListView.ItemTapped += ListView_ItemTapped;

            base.OnAttachedTo(bindable);
        }
        protected override void OnDetachingFrom(SfListView bindable)
        {
            ListView.Loaded -= ListView_Loaded;
            ListView.ItemTapped -= ListView_ItemTapped;
            base.OnDetachingFrom(bindable);
        }

        private void ListView_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            var group = ListView.DataSource.Groups[0];
            ListView.ExpandGroup(group);
            ListView.CollapseGroup(group);
        }

        private void ListView_Loaded(object sender, ListViewLoadedEventArgs e)
        {
            ListView.CollapseAll();
        }

    }
}
