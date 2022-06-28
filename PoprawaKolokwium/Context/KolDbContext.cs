using Microsoft.EntityFrameworkCore;
using PoprawaKolokwium.Models;

namespace PoprawaKolokwium.Context
{
    public class KolDbContext : DbContext
    {
        public DbSet<Organization> Organization { get; set; }
        public DbSet<File> File { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Membership> Membership { get; set; }

        public KolDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organization>(e =>
            {
                e.HasData(new Organization
                {
                    OrganizationId = 1,
                    OrganizationName = "TestOrganization",
                    OrganizationDomain = "Gry"
                });
            });

            modelBuilder.Entity<File>(e =>
            {
                e.HasKey(e1 => new
                {
                    e1.FileID,
                    e1.TeamId
                });

                e.HasData(new File
                {
                    FileID = 1,
                    TeamId = 1,
                    FileName = "Plik",
                    FileExtensions = "pdf",
                    FileSize = 50
                });
            });

            modelBuilder.Entity<Team>(e =>
            {
                e.HasData(new Team
                {
                    TeamId = 1,
                    OrganizationId = 1,
                    TeamName = "Druzyna",
                    TeamDescription = "Opis druzyny"
                });

                
            });

            modelBuilder.Entity<Member>(e =>
            {
                e.HasData(new Member
                {
                    MemberId = 1,
                    OrganizationId = 1,
                    MemberName = "Jakub",
                    MemberSurname = "Slusarski",
                    MemberNickName = "Slusarz"
                });
            });

            modelBuilder.Entity<Membership>(e =>
            {
                e.HasKey(e1 => new
                {
                    e1.MemberId,
                    e1.TeamId
                });
                e.HasData(new Membership
                {
                    MemberId = 1,
                    TeamId = 1,
                    MembershipDate = System.DateTime.Now
                });
            });
        }
    }
}
