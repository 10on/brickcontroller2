﻿using BrickController2.UI.ViewModels;

namespace BrickController2.UI.Pages
{
	public partial class CreationListPage : PageBase
	{
		public CreationListPage(ViewModelBase vm)
		{
			InitializeComponent();
		    BindingContext = vm;
		}
	}
}