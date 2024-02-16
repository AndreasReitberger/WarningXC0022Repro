using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlCompiledBinding.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        #region Properties
        [ObservableProperty]
        string name = "This is a name";
        #endregion
    }
}
