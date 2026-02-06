using Microsoft.EntityFrameworkCore;

namespace TCF.API.LicenseManager.Model;

public class LicenseInfoContext : DbContext
{
    private readonly IConfiguration _configuration;

    public LicenseInfoContext(DbContextOptions<LicenseInfoContext> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LicenseInfo>()
            .ToContainer(_configuration["CosmosDb:ContainerName"] ?? "license-info-container")
            .HasPartitionKey(licenseInfo => licenseInfo.country)
            .HasNoDiscriminator();
    }

    public DbSet<LicenseInfo> LicenseInfos { get; set; }
}