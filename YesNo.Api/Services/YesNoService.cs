namespace YesNo.Api.Services;

/// <summary>
/// Represents an implementation of <see cref="IYesNoService"/>.
/// </summary>
public class YesNoService : IYesNoService
{
    private static readonly Random Random = new();
    private static readonly string[] NoImages =
    [
        "https://i.giphy.com/q49YSnLzrvghiyKBAR.webp",
        "https://i.giphy.com/d1E1msx7Yw5Ne1Fe.webp",
        "https://i.giphy.com/3o7TKwmnDgQb5jemjK.webp"
    ];
    private static readonly string[] YesImages =
    [
        "https://i.giphy.com/3WCNY2RhcmnwGbKbCi.webp",
        "https://i.giphy.com/MNmyTin5qt5LSXirxd.webp",
        "https://i.giphy.com/2RGhmKXcl0ViM.webp"
    ];

    /// <inheritdoc />
    public Models.YesNo GetForced(bool answer)
    {
        return new Models.YesNo(answer, true, GetRandomImage(answer));
    }

    /// <inheritdoc />
    public Models.YesNo GetRandom()
    {
        return Random.Next(100) < 50 ?
            new Models.YesNo(true, false, GetRandomImage(true)) :
            new Models.YesNo(false, false, GetRandomImage(false));
    }

    /// <summary>
    /// Returns a random image URL.
    /// </summary>
    /// <param name="yes">Whether the image says yes.</param>
    /// <returns>The image URL.</returns>
    private string GetRandomImage(bool yes)
    {
        return yes ? YesImages[Random.Next(YesImages.Length)] : NoImages[Random.Next(NoImages.Length)];
    }
}
