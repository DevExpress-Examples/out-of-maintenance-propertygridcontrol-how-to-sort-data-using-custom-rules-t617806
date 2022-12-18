<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655294/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T617806)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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


