using System.IO;

namespace DasBlog.Tests.UnitTests
{
	public class UnitTestsConstants
	{
		private static readonly string root = Path.GetFullPath(Path.GetDirectoryName(typeof(UnitTestsConstants).Assembly.Location));

		public static string TestContentLocation => Path.Combine(root, "TestContent");

		public static string TestLoggingLocation => Path.Combine(root, "logs");
	}
}
