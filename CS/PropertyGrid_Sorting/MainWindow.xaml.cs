using DevExpress.Xpf.PropertyGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace PropertyGrid_Sorting
{
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
        }
        
        private void PropertyGridControl_Sort(object sender, DevExpress.Xpf.PropertyGrid.PropertyGridSortingEventArgs args) {
            List<RowInfo> list = args.SourceCollection.ToList();
            if (args.SourceCollection.All(x => x.IsCategory))
                return;
            list = list.OrderByDescending(x => x.Header).ToList();
            // move ID to top
            RowInfo idRow = list.Where(r => r.Header == "ID").FirstOrDefault();
            if (idRow != null) {
                list.Remove(idRow);
                list.Insert(0, idRow);
            }
            args.ResultCollection = list;
        }

        private void pGrid_CustomExpand(object sender, CustomExpandEventArgs args) {
            args.IsExpanded = true; // to expand all rows
        }
    }
}
