using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Windmill.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class WindmillOpenApiClientRunnerTests : FixturedUnitTest
{
    public WindmillOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
