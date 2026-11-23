public class Game
{
    public string Name;
    public string Genre;
    public string Releasedate;
    public double rating;

    public Game(string name, string releasedate, string genre, double rating)
    {
        Name = name;
        Genre = genre;
        Releasedate = releasedate;
        this.rating = rating;
    }

    public void updateRating(double newRating)
    {
        if (newRating < 0.0 || newRating > 10.0)
        {
            return;
        }

        rating = newRating;
    }
}
