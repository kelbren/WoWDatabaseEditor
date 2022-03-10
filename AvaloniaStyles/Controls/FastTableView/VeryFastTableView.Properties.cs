using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Data;

namespace AvaloniaStyles.Controls.FastTableView;

public partial class VeryFastTableView
{
    public static readonly StyledProperty<IReadOnlyList<int>?> HiddenColumnsProperty = AvaloniaProperty.Register<VeryFastTableView, IReadOnlyList<int>?>(nameof(HiddenColumns));
    public static readonly StyledProperty<IReadOnlyList<ITableColumnHeader>?> ColumnsProperty = AvaloniaProperty.Register<VeryFastTableView, IReadOnlyList<ITableColumnHeader>?>(nameof(Columns));
    public static readonly StyledProperty<IReadOnlyList<ITableRow>?> RowsProperty = AvaloniaProperty.Register<VeryFastTableView, IReadOnlyList<ITableRow>?>(nameof(Rows));
    public static readonly StyledProperty<int> SelectedRowIndexProperty = AvaloniaProperty.Register<VeryFastTableView, int>(nameof(SelectedRowIndex), defaultBindingMode: BindingMode.TwoWay);
    public static readonly StyledProperty<int> SelectedCellIndexProperty = AvaloniaProperty.Register<VeryFastTableView, int>(nameof(SelectedCellIndex), defaultBindingMode: BindingMode.TwoWay);
    public static readonly StyledProperty<ICustomCellDrawer?> CustomCellDrawerProperty = AvaloniaProperty.Register<VeryFastTableView, ICustomCellDrawer?>(nameof(CustomCellDrawer));
    public static readonly StyledProperty<ICustomCellInteractor?> CustomCellInteractorProperty = AvaloniaProperty.Register<VeryFastTableView, ICustomCellInteractor?>(nameof(CustomCellInteractor));

    private List<bool> columnVisibility = new List<bool>();
    
    public IReadOnlyList<int>? HiddenColumns
    {
        get => GetValue(HiddenColumnsProperty);
        set => SetValue(HiddenColumnsProperty, value);
    }
    
    public IReadOnlyList<ITableRow>? Rows
    {
        get => GetValue(RowsProperty);
        set => SetValue(RowsProperty, value);
    }
    
    public IReadOnlyList<ITableColumnHeader>? Columns
    {
        get => GetValue(ColumnsProperty);
        set => SetValue(ColumnsProperty, value);
    }

    public int SelectedRowIndex
    {
        get => GetValue(SelectedRowIndexProperty);
        set => SetValue(SelectedRowIndexProperty, value);
    }

    public int SelectedCellIndex
    {
        get => GetValue(SelectedCellIndexProperty);
        set => SetValue(SelectedCellIndexProperty, value);
    }
    
    public ICustomCellDrawer? CustomCellDrawer
    {
        get => GetValue(CustomCellDrawerProperty);
        set => SetValue(CustomCellDrawerProperty, value);
    }
    
    public ICustomCellInteractor? CustomCellInteractor
    {
        get => GetValue(CustomCellInteractorProperty);
        set => SetValue(CustomCellInteractorProperty, value);
    }
}