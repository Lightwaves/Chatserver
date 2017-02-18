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
using MaterialDesignTest.ViewModel;



namespace MaterialDesignTest
{
    /// <summary>
    /// Interaction logic for LoginCard.xaml
    /// </summary>
    public partial class LoginCard : UserControl
    {
        
        public LoginCard()
        {
            InitializeComponent();
            LoginCardViewModel.PasswordHandler = () => this.PasswordBox.Password;
            
            
        }
        
       
        
        
        
        
      
        
    }
}
