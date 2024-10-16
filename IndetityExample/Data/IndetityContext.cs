using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class IndetityContext : IdentityDbContext<IdentityUser> {

    public IndetityContext(DbContextOptions<IndetityContext> options) : base(options) { }



}