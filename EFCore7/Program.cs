using Microsoft.EntityFrameworkCore;

namespace EFCore7;

public class Program
{
    public static async Task Main(string[] args)
    {
        using var db = new ApplicationDbContext();

        try
        {
            await db.Customers.ExecuteDeleteAsync();
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}

