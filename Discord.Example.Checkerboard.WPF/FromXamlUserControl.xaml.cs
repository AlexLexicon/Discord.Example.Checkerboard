using System.Windows.Controls;
using System.Windows.Media;

namespace Discord.Example.Checkerboard.WPF;
public partial class FromXamlUserControl : UserControl
{
    public FromXamlUserControl()
    {
        InitializeComponent();

        for (int index = 0; index < BorderGrid.Children.Count; index++)
        {
            if (BorderGrid.Children[index] is Border border)
            {
                Color color;

                if (index % 2 == 0)
                {
                    //odd color
                    color = Colors.Black;
                }
                else
                {
                    //even color
                    color = Colors.Red;
                }

                border.Background = new SolidColorBrush(color);
            }
        }
    }
}
