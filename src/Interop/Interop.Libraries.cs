internal static partial class Interop
{
    private static class Libraries
    {
        // This is the change that allows the library to load properly on iOS.
        internal const string Libsodium = "__Internal";
    }
}
