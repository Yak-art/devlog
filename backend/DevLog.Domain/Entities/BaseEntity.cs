namespace DevLog.Domain.Entities
{
    /// <summary>
    /// Базовая сущность доменной модели.
    /// </summary>
    public abstract class BaseEntity
    {
        public Guid Id { get; protected set; }

        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
