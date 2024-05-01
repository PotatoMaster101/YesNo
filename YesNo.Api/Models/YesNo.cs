using System.Text.Json.Serialization;

namespace YesNo.Api.Models;

/// <summary>
/// Represents a yes or no response.
/// </summary>
public class YesNo
{
    private const string NoAnswer = "no";
    private const string YesAnswer = "yes";

    /// <summary>
    /// Gets the yes or no answer.
    /// </summary>
    [JsonPropertyName("answer")]
    public string Answer { get; }

    /// <summary>
    /// Gets whether the answer is forced.
    /// </summary>
    [JsonPropertyName("forced")]
    public bool Forced { get; }

    /// <summary>
    /// Gets the answer image URL.
    /// </summary>
    [JsonPropertyName("image")]
    public string Image { get; }

    /// <summary>
    /// Gets whether the answer is a yes.
    /// </summary>
    [JsonIgnore]
    public bool IsYes => Answer == YesAnswer;

    /// <summary>
    /// Constructs a new instance of <see cref="YesNo"/>.
    /// </summary>
    /// <param name="answer">The yes/no answer value.</param>
    /// <param name="forced">Whether the answer is forced.</param>
    /// <param name="image">The answer image URL.</param>
    public YesNo(bool answer, bool forced, string image)
    {
        Answer = answer ? YesAnswer : NoAnswer;
        Forced = forced;
        Image = image;
    }
}
