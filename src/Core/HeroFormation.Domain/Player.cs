namespace HeroFormation.Domain;

public class Player
{
    public string Name { get; set; }
    public int CurrentScore { get; set; }
    public int BestScore { get; set; }

    // TODO: create relation to user account
}