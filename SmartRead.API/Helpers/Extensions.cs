namespace SmartRead.API.Helpers
{
    public static class Extensions
    {
        public static T First<T>(this T[] array)
        {
            return array[0];
        }

        public static T Second<T>(this T[] array)
        {
            return array[1];
        }
    }
}
