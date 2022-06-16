using Microsoft.EntityFrameworkCore;
using Tests.Database.Model;

namespace Tests.Database.Context
{
    public partial class UserTestingDbContext : DbContext
    {
        public UserTestingDbContext(DbContextOptions<UserTestingDbContext> options) : base(options)
        {
            // this.ChangeTracker.LazyLoadingEnabled = false;
        }

        partial void OnModelBuilding(ModelBuilder builder);

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserTest>(p =>
            {
                p.HasNoKey();
                p.Property(p => p.UserId).HasMaxLength(100);
                p.Property(p => p.TestId)
                  .HasPrecision(10, 0);
            });

            builder.Entity<Questions>(p =>
            {
                p.HasKey(h => h.IdQuestions);

                p.HasOne(i => i.ListTests)
                 .WithMany(i => i.Questions)
                 .HasForeignKey(i => i.TestsId)
                 .HasPrincipalKey(i => i.IdListTest);

                p.Property(p => p.IdQuestions)
                 .HasPrecision(10, 0);

                p.Property(p => p.TestsId)
                 .HasPrecision(10, 0);

                p.Property(pr => pr.QuestionText)
                 .HasMaxLength(350);
            });

            builder.Entity<AnswerOptions>(p =>
            {
                p.HasOne(i => i.Question)
                .WithMany(i => i.AnswerOptions)
                .HasForeignKey(i => i.QuestionsId)
                .HasPrincipalKey(i => i.IdQuestions);

                p.HasKey(h => h.IdAnswerOptions);

                p.Property(pr => pr.Possiblenswer)
                .HasMaxLength(250);

                p.Property(pr => pr.IdAnswerOptions)
                 .HasPrecision(10, 0);

                p.Property(pr => pr.QuestionsId)
                .HasPrecision(10, 0);
            });

            builder.Entity<Model.ListTests>(p =>
            {
                p.HasKey(h => h.IdListTest);

                p.Property(p => p.IdListTest)
                 .HasPrecision(10, 0);

                p.Property(pr => pr.Name)
                 .HasMaxLength(200);

                p.Property(pr => pr.Note)
                 .HasMaxLength(1000);

                p.Property(pr => pr.Img)
                 .HasMaxLength(250);
            });

            this.OnModelBuilding(builder);
        }

        public DbSet<AnswerOptions> AnswerOptions { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<ListTests> ListTests { get; set; }
        public DbSet<UserTest> UserTests { get; set; }
    }
}
