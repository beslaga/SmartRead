namespace SmartRead.Mobile.ViewModels
{
    public class ClanakItemViewModel : BaseViewModel
    {
        private int id;
        private string naslov;
        private string autor;

        public ClanakItemViewModel(int id, string naslov, string autor)
        {
            this.id = id;
            this.naslov = naslov;
            this.autor = autor;
        }

        public string Naslov
        {
            get => naslov;
            set => SetProperty(ref naslov, value);
        }

        public string Autor
        {
            get => autor;
            set => SetProperty(ref autor, value);
        }

        public int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }
    }
}
