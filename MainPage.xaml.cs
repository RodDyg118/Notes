using System.Diagnostics;

namespace Notes;

public partial class MainPage : ContentPage
{

    string caminho = Path.Combine (FileSystem.AppDataDirectory, "nota.txt"); 
    public MainPage()
    {
        InitializeComponent();
    }

    private void AoClicarSalvar(object sender, EventArgs e)
    {
        string conteudo = NotasEditor.Text;
        File.WriteAllText(caminho, conteudo);
    }

    private void AoClicarApagar(object sender, EventArgs e)
    {
        if (File.Exists(caminho))
        {
            File.Delete(caminho);
        }
    }

    private void AoClicarCarregar(object sender, EventArgs e)
    {
        try
        {
            string conteudo = File.ReadAllText(caminho);
            NotasEditor.Text = conteudo;
        }
        catch(Exception ex)
        {
            Debug.WriteLine(ex.Message);
            DisplayAlert("Alerta", "Operação Ilegal", "Ok");
        }
    }

}