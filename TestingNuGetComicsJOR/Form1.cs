using MarvelComicsJOR.Models;
using MarvelComicsJOR.Services;

namespace TestingNuGetComicsJOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string search = this.txtSearch.Text;
            ServiceComics service = new ServiceComics();
            ComicsList comics = await service.GetListaComicsAsync(search);

            this.lstComics.Items.Clear();
            foreach (var comic in comics.Comics)
            {
                this.lstComics.Items.Add(comic.Titulo);
            }
        }
    }
}
