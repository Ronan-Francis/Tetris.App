/*
 */


namespace Tetris;

public partial class MainPage : ContentPage
{
    int maxRow = 20;
    int maxCol = 10;
    int[,] _gameArray = new int[20, 10];

    public MainPage()
    {
        InitializeComponent();
        InitializeGame();
        drawShape(0, 0, 0);
    }
    private void InitializeGame()
    {
        gameGrid.HeightRequest = maxRow * 20;
        gameGrid.WidthRequest = maxCol * 20;
        for (int i = 0; i < maxRow; i++)
        {
            gameGrid.AddRowDefinition(new RowDefinition());
        }
        for (int i = 0; i < maxCol; i++)
        {
            gameGrid.ColumnDefinitions.Add(new ColumnDefinition());
        }


        for (int r = 0; r < maxRow; r++)
        {
            for (int c = 0; c < maxCol; c++)
            {
                Image image = new Image();
                image.Source = "blankcube.png";
                image.HorizontalOptions = LayoutOptions.Center;
                image.VerticalOptions = LayoutOptions.Center;
                image.SetValue(Grid.RowProperty, r);
                image.SetValue(Grid.ColumnProperty, c);
                gameGrid.Children.Add(image);
                //_gameArray[r,c] = 0;//0 = no color
            }// end for (c = 0)

        } // end for(r = 0)
    }

    private void drawShape(int row, int col, int shape)
    {
        foreach (Image element in gameGrid.Children)
        {
            if (gameGrid.GetColumn(element) == col && gameGrid.GetRow(element) == row)
            {
                element.Source = "redcube.png";
            }
        }
    }
}

