namespace YesNo.Api.Services;

/// <summary>
/// Represents a service that generates yes/no response.
/// </summary>
public interface IYesNoService
{
    /// <summary>
    /// Gets a forced yes/no response.
    /// </summary>
    /// <param name="answer">The yes/no value.</param>
    /// <returns>The forced yes/no response.</returns>
    Models.YesNo GetForced(bool answer);

    /// <summary>
    /// Gets a random yes/no response.
    /// </summary>
    /// <returns>The randomly generated yes/no response.</returns>
    Models.YesNo GetRandom();
}
