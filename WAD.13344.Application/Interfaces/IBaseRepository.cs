namespace WAD._13344.Application.Interfaces
{
	public interface IBaseRepository<TEntity> where TEntity : class
	{
		IQueryable<TEntity> GetAll();
		Task<List<TEntity>> GetAllAsync();
		Task<TEntity> GetByIdAsync(int id);
		Task CreateAsync(TEntity entity);
		Task UpdateAsync(TEntity entity);
		Task DeleteAsync(int id);
	}
}
