using DrugStore.Infrastructure;
using DrugStore.Infrastructure.Entities;

namespace DrugStore.Services;

public class TestService
{
    private readonly ApplicationDbContext _applicationDbContext;

    public TestService(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public int GetHui()
    {
        var testEntities = _applicationDbContext.Set<TestEntity>();
        
        return 1;
    }
}