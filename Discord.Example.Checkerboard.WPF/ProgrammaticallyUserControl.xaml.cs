using System.Windows.Controls;
using System.Windows.Media;

namespace Discord.Example.Checkerboard.WPF;
public partial class ProgrammaticallyUserControl : UserControl
{
    public ProgrammaticallyUserControl()
    {
        InitializeComponent();

        int totalColumns = 8;
        int totalRows = 8;

        for (int row = 1; row <= totalRows; row++)
        {
            BorderGrid.ColumnDefinitions.Add(new ColumnDefinition());
            BorderGrid.RowDefinitions.Add(new RowDefinition());

            for (int column = 1; column <= totalColumns; column++)
            {
                Brush color;

                if ((column + row) % 2 == 0)
                {
                    color = Brushes.White;
                }
                else
                {
                    color = Brushes.Black;
                }

                var border = new Border
                {
                    Width = 50,
                    Height = 50,
                    Background = color,
                };

                Grid.SetColumn(border, column - 1);
                Grid.SetRow(border, row - 1);

                BorderGrid.Children.Add(border);
            }
        }
    }
}
