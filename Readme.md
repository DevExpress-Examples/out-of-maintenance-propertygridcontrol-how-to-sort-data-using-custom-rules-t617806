<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/PropertyGrid_Sorting/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/PropertyGrid_Sorting/MainWindow.xaml))
* **[MainWindow.xaml.cs](./CS/PropertyGrid_Sorting/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/PropertyGrid_Sorting/MainWindow.xaml.vb))**
* [MyViewModel.cs](./CS/PropertyGrid_Sorting/MyViewModel.cs) (VB: [MyViewModel.vb](./VB/PropertyGrid_Sorting/MyViewModel.vb))
* [Person.cs](./CS/PropertyGrid_Sorting/Person.cs) (VB: [Person.vb](./VB/PropertyGrid_Sorting/Person.vb))
<!-- default file list end -->
# PropertyGridControl - How to sort data using custom rules


You can sort data rows and categories in a custom way by handling the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.PropertyGrid.PropertyGridControl.Sort.event">PropertyGridControl.Sort</a> event. This examples demonstrates how to handle this event so that non-category rows are sorted in the descending order but every ID row is always on top.

<br/>


