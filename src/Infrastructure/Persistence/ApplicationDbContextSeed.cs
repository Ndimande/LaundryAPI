using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Infrastructure.Persistence;

public static class ApplicationDbContextSeed
{
    public static async Task SeedDefaultUserAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        var administratorRole = new IdentityRole("Administrator");


        if (roleManager.Roles.All(r => r.Name != administratorRole.Name))
        {
            await roleManager.CreateAsync(administratorRole);
        }

        var administrator = new ApplicationUser { UserName = "administrator@localhost", Email = "administrator@localhost" };

        if (userManager.Users.All(u => u.UserName != administrator.UserName))
        {
            await userManager.CreateAsync(administrator, "Administrator1!");
            await userManager.AddToRolesAsync(administrator, new[] { administratorRole.Name });
        }
    }

    public static async Task SeedSampleDataAsync(ApplicationDbContext context)
    {
        // Seed, if necessary
        if (!context.Baskets.Any())
        {
            context.Baskets.Add(
            new Basket
            {
         
                ImageUrl = "assets/images/baskets/basket1.jpg",
                Size = 10,
                EstimatedPrize = "100.00",
            });


            context.Baskets.Add(
            new Basket
            {
            
                ImageUrl = "assets/images/baskets/basket2.jpg",
                Size = 20,
                EstimatedPrize = "200.00",
            });

            context.Baskets.Add(
            new Basket
            {
              
                ImageUrl = "assets/images/baskets/basket3.jpg",
                Size = 15,
                EstimatedPrize = "149.00",
            });

            context.Baskets.Add(
            new Basket
            {
             
                ImageUrl = "assets/images/baskets/basket4.jpg",
                Size = 40,
                EstimatedPrize = "499.00",
            });

            context.Baskets.Add(
            new Basket
            {
    
                ImageUrl = "assets/images/baskets/basket5.jpg",
                Size = 70,
                EstimatedPrize = "699.99",
            });

            context.Baskets.Add(
            new Basket
            {
       
                ImageUrl = "assets/images/baskets/basket6.jpg",
                Size = 4,
                EstimatedPrize = "49.99",
            });


            context.Baskets.Add(
            new Basket
            {
          
                ImageUrl = "assets/images/baskets/basket7.jpg",
                Size = 25,
                EstimatedPrize = "249.99",
            });


            context.Baskets.Add(
            new Basket
            {
      
                ImageUrl = "assets/images/baskets/basket8.jpg",
                Size = 45,
                EstimatedPrize = "549.99",
            });

            context.Baskets.Add(
            new Basket
            {
              
                ImageUrl = "assets/images/baskets/basket9.jpg",
                Size = 19,
                EstimatedPrize = "200.00",
            });

            context.Baskets.Add(
            new Basket
            {
   
                ImageUrl = "assets/images/baskets/basket10.jpg",
                Size = 10,
                EstimatedPrize = "100.00",
            });

            context.Baskets.Add(
            new Basket
            {
          
                ImageUrl = "assets/images/baskets/basket11.jpg",
                Size = 10,
                EstimatedPrize = "100.99",
            });

            context.Baskets.Add(
            new Basket
            {
           
                ImageUrl = "assets/images/baskets/basket12.jpg",
                Size = 100,
                EstimatedPrize = "999.99",
            });

            await context.SaveChangesAsync();
        }

        if (!context.Register.Any())
        {
            context.Register.Add(new SignUp
            {
                Firstname = "p",
                Contact = "p",
                Created = DateTime.Now,
                Email = "p",
                Lastname = "p",
                CreatedBy = "Patrick",
                Password = "p",
                LastModified = DateTime.Now,
                LastModifiedBy = "1"

            });
            await context.SaveChangesAsync();
        }
    }
}
