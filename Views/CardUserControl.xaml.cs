using NoteTaking.Models;
using NoteTaking.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NoteTaking.Views
{
    /// <summary>
    /// Interação lógica para CardUserControl.xam
    /// </summary>
    public partial class CardUserControl : UserControl
    {
        public CardUserControl()
        {
            //DataContext = new CardViewModel(SelectedCard);
            InitializeComponent();
        }
        public static readonly DependencyProperty CardProperty = DependencyProperty.Register("Content", typeof(Board), typeof(CardUserControl), new PropertyMetadata());

        public Card SelectedCard { get => (Card)GetValue(CardProperty); set => SetValue(CardProperty, value); }
    }
}
