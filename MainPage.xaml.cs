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
    }

    private void AoClicarCarregar(object sender, EventArgs e)
    {
    }

}