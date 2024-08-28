using Microsoft.EntityFrameworkCore;
using Domain.Entities;

public class OpBlogDbContext : DbContext
{
    public DbSet<Article> Articles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Tag> Tags { get; set; }

    public OpBlogDbContext(DbContextOptions<OpBlogDbContext> options) : base(options)
    {
    }
 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Indexes

        modelBuilder.Entity<Article>()
            .HasIndex(a => a.Slug)
            .IsUnique();

        modelBuilder.Entity<User>()
            .HasIndex(u => u.UserName)
            .IsUnique();

        modelBuilder.Entity<Tag>()
            .HasIndex(t => t.Name)
            .IsUnique();
        #endregion
        
        #region Relationships
        // Article - Tag (Many - Many)
        modelBuilder.Entity<Article>()
            .HasMany(a => a.Tags)
            .WithMany()
            .UsingEntity<Dictionary<string, object>>(
                "ArticleTags",
                j => j.HasOne<Tag>().WithMany().HasForeignKey("Tag"),
                j => j.HasOne<Article>().WithMany().HasForeignKey("ArticleId")
            );
        
        // Article -> Author (Many - One)
        modelBuilder.Entity<Article>()
            .HasOne(a => a.Author)
            .WithMany()
            .HasForeignKey("AuthorUserName") // Specify the foreign key property name
            .OnDelete(DeleteBehavior.Cascade);
        
        // Article -> Comments (One - Many)
        modelBuilder.Entity<Article>()
            .HasMany(a => a.Comments)
            .WithOne(c => c.Article)
            .HasForeignKey("ArticleId")
            .OnDelete(DeleteBehavior.Cascade);

        // Article -> User (Many - Many)
        modelBuilder.Entity<Article>()
            .HasMany(a => a.Favorites)
            .WithMany(u => u.FavoriteArticles)
            .UsingEntity<Dictionary<string, object>>(
                "ArticleFavorites",
                j => j.HasOne<User>().WithMany().HasForeignKey("UserName"),
                j => j.HasOne<Article>().WithMany().HasForeignKey("ArticleId")
            );
        
        // Comment -> Author (One - Many)
        modelBuilder.Entity<Comment>()
            .HasOne(c => c.Author)
            .WithMany()
            .HasForeignKey("AuthorUserName")
            .OnDelete(DeleteBehavior.Cascade);

        // User -> Authors (Following) (Many-to-Many)
        modelBuilder.Entity<User>()
            .HasMany(u => u.Following)
            .WithMany(a => a.Followers)
            .UsingEntity<Dictionary<string, object>>(
                "AuthorFollowing",
                j => j.HasOne<Author>().WithMany().HasForeignKey("AuthorUserName"),
                j => j.HasOne<User>().WithMany().HasForeignKey("UserName")
            );
        
        #endregion
        
        modelBuilder.Entity<Author>()
            .HasBaseType<User>();
        
        base.OnModelCreating(modelBuilder);
    }
}
