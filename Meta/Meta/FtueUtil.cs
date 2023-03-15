using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A4E")]
	public static class FtueUtil
	{
		[Cpp2IlInjected.Token(Token = "0x60058E6")]
		[Cpp2IlInjected.Address(RVA = "0x1809AB0", Offset = "0x18084B0", VA = "0x181809AB0")]
		public static bool IsWithinTutorial(ITutorializable tutorializable, Profile profile)
		{
			//Discarded unreachable code: IL_001d
			//IL_000e: Expected I4, but got O
			if ((object)typeof(ITutorializable).TypeHandle == null)
			{
				return (byte)(int)typeof(ITutorializable).TypeHandle != 0;
			}
			int num = default(int);
			if (num == 0)
			{
				return true;
			}
			ProfilePlayer player_ = profile.player_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60058E7")]
		[Cpp2IlInjected.Address(RVA = "0x1809A40", Offset = "0x1808440", VA = "0x181809A40")]
		public static bool FtueEventComplete(int eventID, Profile profile)
		{
			//Discarded unreachable code: IL_0012
			//IL_0011: Expected O, but got I4
			return ((RepeatedField<T>)(object)profile.player_.completedFtueEvents_).Contains((T)eventID);
		}
	}
}
