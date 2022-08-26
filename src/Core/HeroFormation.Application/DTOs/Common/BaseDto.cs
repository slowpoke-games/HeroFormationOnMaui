namespace HeroFormation.Application.DTOs.Common;

public abstract class BaseDto
{
    public int Id { get; set; }
    public PlayerDto Player { get; set; }
}