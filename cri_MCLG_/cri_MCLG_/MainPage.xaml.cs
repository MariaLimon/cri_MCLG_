using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cri_MCLG_
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(Nombre.Text))
			{
				var nombrePersona = Nombre.Text;
				List<string> atributoPersona = new List<string>();

				if (RadioBHombre.IsChecked == false)
				{
					if(alto.IsChecked == true)
					{
						atributoPersona.Add("alta");
					}
					if (listo.IsChecked == true)
					{
						atributoPersona.Add("lista");
					}
					if(raro.IsChecked == true) 
					{
						atributoPersona.Add("rara");
					}
					if (chaparro.IsChecked == true)
					{
						atributoPersona.Add("chaparra");
					}
					
				}
				else
				{
					if (alto.IsChecked == true)
					{
						atributoPersona.Add("alto");
					}
					if (listo.IsChecked == true)
					{
						atributoPersona.Add("listo");
					}
					if (raro.IsChecked == true)
					{
						atributoPersona.Add("raro");
					}
					if (chaparro.IsChecked == true)
					{
						atributoPersona.Add("chaparro");
					}
				}
				if (extravagante.IsChecked == true)
				{
					atributoPersona.Add("extravagante");
				}
				if (grande.IsChecked == true)
				{
					atributoPersona.Add("grande");
				}
				int lonfitud = atributoPersona.Count;
				var cadena = string.Join(", ", atributoPersona.Take(lonfitud-1));
				string ultimo = atributoPersona[lonfitud-1];
				criticaEditor.Text = $"{nombrePersona} es {cadena} y {ultimo}";
			}
			else
			{
				DisplayAlert("Datos erroneos", "Por favor, llena la información que se solicita", "Ok");
			}
		}
    }
}
