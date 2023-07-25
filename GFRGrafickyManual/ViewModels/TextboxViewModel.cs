using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;

namespace GFRGrafickyManual.ViewModels
{
    public class TextboxViewModel : MasterPageViewModel
    {

		public string Title { get; set;}

		public TextboxViewModel()
		{
			Title = "Hello from DotVVM!";
		}

    }
}
