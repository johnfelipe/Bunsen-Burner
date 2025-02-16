namespace BunsenBurner.Verify.Xunit.Tests;
using static BunsenBurner.Bdd;

[UsesVerify]
public static class BddTests
{
    [Fact(DisplayName = "Assertion with scrubbing and projection works")]
    public static async Task Case1() =>
        await Given(
                () =>
                    new
                    {
                        A = 1,
                        B = "2",
                        C = DateTimeOffset.Now
                    }
            )
            .When(_ => _)
            .ThenResultIsUnchanged(x => new { x.A, x.C }, scrubResults: true);

    [Fact(DisplayName = "Named scenario assertion with scrubbing and projection works")]
    public static async Task Case2() =>
        await "Some description"
            .Given(
                () =>
                    new
                    {
                        A = 1,
                        B = "2",
                        C = DateTimeOffset.Now
                    }
            )
            .When(_ => _)
            .ThenResultIsUnchanged(x => new { x.A, x.C }, scrubResults: true);

    [Fact(DisplayName = "Assertion without scrubbing works")]
    public static async Task Case3() =>
        await Given(() => new { A = 1, B = "2" }).When(_ => _).ThenResultIsUnchanged();

    [Fact(DisplayName = "Named scenario assertion without scrubbing works")]
    public static async Task Case4() =>
        await "Some description"
            .Given(() => new { A = 1, B = "2" })
            .When(_ => _)
            .ThenResultIsUnchanged();
}
