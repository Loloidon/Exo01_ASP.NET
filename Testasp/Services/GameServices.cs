namespace Testasp.Controllers
{
    public class GameService
    {
        
        public List<Game> Games { get; set; } = new List<Game>();

        public GameService()
        {
            // Ajout de jeux à la liste
            Games.Add(new Game { Id = 1, Titre = "Nom du jeu 1", Annee = 2020, Genre = "Action", Resume = "Résumé du jeu 1" });
            Games.Add(new Game { Id = 2, Titre = "Nom du jeu 2", Annee = 2021, Genre = "Aventure", Resume = "Résumé du jeu 2" });
            // Ajoutez autant de jeux que nécessaire.
        }
        public void addGame(int id, string desc,int date , string genre,string titre)
        {
            Games.Add(new Game { Id = id, Titre = titre, Annee = date, Genre = genre, Resume = desc });
        }
        public List<Game> Getgames()
        {
            return Games;
        }
   
    }

}

