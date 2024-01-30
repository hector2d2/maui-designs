﻿using ExploracionPaquetes.Src.Security.Interfaces;

namespace ExploracionPaquetes.Src.Security.Views;

public partial class InvoqueNativeCodeView : ContentPage
{
	public InvoqueNativeCodeView()
	{
		InitializeComponent();
	}

    void BtmDoNativecode_Clicked(System.Object sender, System.EventArgs e)
    {
        ShowTextInterface showTextInterface = new ShowTextService();
        TxtNativeCode.Text = showTextInterface.TextFromPlatform();
    }
}