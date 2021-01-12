using System.Windows.Forms;

namespace SmartRead.WinUI.Helpers
{
    public static class Extensions
    {
        public static void startLoading(this Cursor cursor)
        {
            cursor = Cursors.WaitCursor;
        }

        public static void stopLoading(this Cursor cursor)
        {
            cursor = Cursors.Default;
        }

        public static bool isEmpty(this string str)
        {
            return str.Length == 0;
        }
        public static bool isNotEmpty(this string str)
        {
            return str.Length != 0;
        }
    }
}
