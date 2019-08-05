# Appearance customization of group header template

The User Interface (UI) for the group header items can be customized by using the [SfListView.GroupHeaderTemplate](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~GroupHeaderTemplate.html) property.

To customize the view for group header items and binding the [Key](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.DataSource.Portable~Syncfusion.DataSource.Extensions.GroupResult~Key.html) to it, follow the code example.

```
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms">
 <syncfusion:SfListView x:Name="listView">
  <syncfusion:SfListView.GroupHeaderTemplate>
    <DataTemplate>
      <ViewCell>
        <ViewCell.View>
          <StackLayout BackgroundColor="#E4E4E4">
            <Label Text="{Binding Key}"
                   FontSize="22"
                   FontAttributes="Bold"
                   VerticalOptions="Center"
                   HorizontalOptions="Start"
                   Margin="20,0,0,0" />
          </StackLayout>
        </ViewCell.View>
      </ViewCell>
    </DataTemplate>
  </syncfusion:SfListView.GroupHeaderTemplate>
 </syncfusion:SfListView>
</ContentPage>
```

To know more about grouping, please refer our documentation [here](https://help.syncfusion.com/xamarin/sflistview/grouping)