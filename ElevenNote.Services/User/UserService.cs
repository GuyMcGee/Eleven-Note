
public class UserService : IUserService
{
    private ApplicationDbContext _dbcontext;

    public UserService(ApplicationDbContext dbcontext)
    {
        _dbcontext = dbcontext;
    }

    public Task<bool> RegisterUserAsync(UserRegister model)
    {
        throw new NotImplementedException();
    }
}
