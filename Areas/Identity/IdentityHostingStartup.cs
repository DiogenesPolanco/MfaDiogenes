﻿[assembly: HostingStartup(typeof(MfaDiogenes.Areas.Identity.IdentityHostingStartup))]
namespace MfaDiogenes.Areas.Identity;

public class IdentityHostingStartup : IHostingStartup
{
    public void Configure(IWebHostBuilder builder)
    {
        builder.ConfigureServices((context, services) =>
        {
        });
    }
}