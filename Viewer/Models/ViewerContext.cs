using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Viewer.Models
{
    public class ViewerContext : DbContext
    {
        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Trait> Traits { get; set; }
        public virtual DbSet<CharacterTrait> CharacterTraits { get; set; }
        public ViewerContext(DbContextOptions<ViewerContext> options) : base(options)
        {

        }

    }
}