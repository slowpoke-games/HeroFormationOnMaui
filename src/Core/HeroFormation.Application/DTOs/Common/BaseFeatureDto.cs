namespace HeroFormation.Application.DTOs.Common;

public class BaseFeatureDto<T> : BaseDto where T : class
{
    public T TEntity { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime RequestedDate { get; set; }
    public bool Cancelled { get; set; }
}