using HeroFormation.Application.DTOs.Common;

namespace HeroFormation.Application.DTOs;

public class PlayerDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CurrentScore { get; set; }
    public int BestScore { get; set; }
}