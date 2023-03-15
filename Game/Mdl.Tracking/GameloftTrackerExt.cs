using System.IO;
using Cpp2IlInjected;
using Gameloft.Tracking.Storage.Slots;

namespace Mdl.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x20002A5")]
	public static class GameloftTrackerExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000B9F")]
		[Cpp2IlInjected.Address(RVA = "0x8C1350", Offset = "0x8BFD50", VA = "0x1808C1350")]
		public static FileMode ToFileMode(this AccessMode accessMode)
		{
			if (accessMode != 0)
			{
			}
			return FileMode.Open;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA0")]
		[Cpp2IlInjected.Address(RVA = "0x8C1340", Offset = "0x8BFD40", VA = "0x1808C1340")]
		public static FileAccess ToFileAccess(this AccessMode accessMode)
		{
			if (accessMode != 0)
			{
			}
			return FileAccess.Read;
		}
	}
}
