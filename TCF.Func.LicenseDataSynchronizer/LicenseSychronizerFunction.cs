using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using TCF.Func.LicenseDataSynchronizer.Helpers;

namespace TCF.Func.LicenseDataSynchronizer;

public class LicenseSychronizerFunction
{
    private readonly ILogger _logger;

    public LicenseSychronizerFunction(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<LicenseSychronizerFunction>();
    }

    [Function(nameof(LicenseSychronizerFunction))]
    [FixedDelayRetry(1, "00:00:10")]
    public async Task Run([TimerTrigger("0 */15 * * * *")] TimerInfo myTimer)
    {
        _logger.LogInformation("C# Timer trigger function executed at: {executionTime}", DateTime.Now);

        // Step 1: Retrieve the license data
        var licenseData = LicenseInfoRetriever.GetLicenseData(_logger);
        _logger.LogInformation("Retrieved {licenseCount} license records.", licenseData.Count);

        // Step 2: Create/Update license data in DB
        _logger.LogInformation("Starting data synchronization to the database.");
        await DbPersister.SyncronizeDataAsync(licenseData, _logger);

        if (myTimer.ScheduleStatus is not null)
        {
            _logger.LogInformation("Next timer schedule at: {nextSchedule}", myTimer.ScheduleStatus.Next);
        }
    }
}