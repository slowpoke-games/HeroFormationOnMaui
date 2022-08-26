namespace HeroFormation.Domain.Common;

public abstract class BaseDomainRequest<T> : BaseDomainEntity where T : class
{
    public T TEntity { get; set; }
    public DateTime RequestedDate { get; set; }
}