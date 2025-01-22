namespace MauiApp2_HACB;

public partial class CalculadoraIMC : ContentPage
{
	public CalculadoraIMC()
	{
        InitializeComponent();
    }

    private void Calcular_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Peso.Text))
        {
            var peso = float.Parse(Peso.Text);
            var altura = float.Parse(Altura.Text);

            var imc = peso / (altura * altura);

            IMC.Text = imc.ToString();

            string resultado = "";
            if (imc < 18.5)
            {
                resultado = "Tiene bajo peso";
                BajoPeso.IsVisible = true;
                PesoNormal.IsVisible = false;
                SobrePeso.IsVisible = false;
                Obesidad.IsVisible = false;
            }
            else if (imc >= 18.5 && imc <= 25)
            {
                resultado = "Tu peso es normal";
                BajoPeso.IsVisible = false;
                PesoNormal.IsVisible=true;
                SobrePeso.IsVisible=false;
                Obesidad.IsVisible=true;

            }
            else if (imc >= 25 && imc <= 29.9)
            {
                resultado = "Tiene sobre peso";
                BajoPeso.IsVisible = false;
                PesoNormal.IsVisible=false;
                SobrePeso.IsVisible=true;
                Obesidad.IsVisible=false;
            }
            else
            {
                resultado = "Tienes obesidad, cuidarte";
                BajoPeso.IsVisible=false;
                PesoNormal.IsVisible=false;
                SobrePeso.IsVisible = false;
                Obesidad.IsVisible=true;
            }
            DisplayAlert("Resultado: ", resultado, "Quitar");
        }
        else
        {
            DisplayAlert("Datos erroneos", "Por favol, llena todo la informacion", "Quitar");
        }
    }

    private void mainPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}