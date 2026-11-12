namespace CreatingMethods;

/// <summary>
/// Provides methods that demonstrate using the 'ref' parameters.
/// </summary>
public static class MethodsWithRefParameters
{
    /// <summary>
    /// Returns the value of the <paramref name="boolValue"/> parameter and sets it to its default value.
    /// </summary>
    /// <param name="boolValue">The boolean value passed by reference.</param>
    /// <returns>The original value of the <paramref name="boolValue"/> parameter.</returns>
    public static bool ReturnParameterValueAndSetParameterToDefaultValue(ref bool boolValue)
    {
        bool original = boolValue;
        boolValue = default;

        return original;
    }

    /// <summary>
    /// Returns the value of the <paramref name="charValue"/> parameter and sets it to its default value.
    /// </summary>
    /// <param name="charValue">The char value passed by reference.</param>
    /// <returns>The original value of the <paramref name="charValue"/> parameter.</returns>
    public static char ReturnParameterValueAndSetParameterToDefaultValue(ref char charValue)
    {
        char original = charValue;
        charValue = default;

        return original;
    }

    /// <summary>
    /// Returns the value of the <paramref name="floatValue"/> parameter and sets it to its default value.
    /// </summary>
    /// <param name="floatValue">The float value passed by reference.</param>
    /// <returns>The original value of the <paramref name="floatValue"/> parameter.</returns>
    public static float ReturnParameterValueAndSetParameterToDefaultValue(ref float floatValue)
    {
        float original = floatValue;
        floatValue = default;

        return original;
    }

    /// <summary>
    /// Returns the value of the <paramref name="intValue"/> parameter and sets it to its default value.
    /// </summary>
    /// <param name="intValue">The int value passed by reference.</param>
    /// <returns>The original value of the <paramref name="intValue"/> parameter.</returns>
    public static int ReturnParameterValueAndSetParameterToDefaultValue(ref int intValue)
    {
        int original = intValue;
        intValue = default;

        return original;
    }

    /// <summary>
    /// Returns the value of the <paramref name="longValue"/> parameter and sets it to its default value.
    /// </summary>
    /// <param name="longValue">The long value passed by reference.</param>
    /// <returns>The original value of the <paramref name="longValue"/> parameter.</returns>
    public static long ReturnParameterValueAndSetParameterToDefaultValue(ref long longValue)
    {
        long original = longValue;
        longValue = default;

        return original;
    }
}