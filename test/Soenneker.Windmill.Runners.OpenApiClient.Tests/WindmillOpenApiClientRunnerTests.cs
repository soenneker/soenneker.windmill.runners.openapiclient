using Soenneker.Tests.HostedUnit;

namespace Soenneker.Windmill.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class WindmillOpenApiClientRunnerTests : HostedUnitTest
{
    public WindmillOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
