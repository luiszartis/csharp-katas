namespace WebAPIClient.Model;

public interface ICharacter
{
    public Task<bool> Move();
    
    public Task<bool> Attack();
}
public abstract class Character: ICharacter
{
    public abstract Task<bool> Move();

    public abstract Task<bool> Attack();
}

public class Warrior : Character
{
    public override Task<bool> Move()
    {
        return Task.FromResult(true);
    }

    public override Task<bool> Attack()
    {
        return Task.FromResult(true);
    }
}

public class Archer : Character
{
    public override Task<bool> Move()
    {
        return Task.FromResult(false);
    }

    public override Task<bool> Attack()
    {
        return Task.FromResult(false);
    }
}
