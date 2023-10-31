using NoteTaking.Models;
using NoteTaking.Viewmodels;
using System.Windows;
using System.Windows.Controls;

namespace NoteTaking.Views
{
    /// <summary>
    /// Interação lógica para BoardUserControl.xam
    /// </summary>
    public partial class BoardUserControl : UserControl
    {
        public BoardUserControl()
        {
            InitializeComponent();
            DataContext = new BoardViewModel(CurrentBoard);
        }
        public static readonly DependencyProperty BoardProperty = 
            DependencyProperty.Register("Content", typeof(Board), typeof(BoardUserControl), new PropertyMetadata(new Board(1 ,"teste")));

        public Board CurrentBoard
        {
            get { return (Board)GetValue(BoardProperty); }
            set { SetValue(BoardProperty, value); }
        }
    }
}
