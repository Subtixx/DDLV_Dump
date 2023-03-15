using Cpp2IlInjected;
using Definitions.Util;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000655")]
	public static class IGridEditRestrictionExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6004A44")]
		[Cpp2IlInjected.Address(RVA = "0x27B2320", Offset = "0x27B0D20", VA = "0x1827B2320")]
		public static bool CanMove(this IGridEditRestriction gridEditRestriction, IProfile profile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0012
			if (gridEditRestriction != null && (object)typeof(IGridEditRestriction).TypeHandle != null)
			{
				int num = 0;
				bool result = default(bool);
				return result;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A45")]
		[Cpp2IlInjected.Address(RVA = "0x27B23D0", Offset = "0x27B0DD0", VA = "0x1827B23D0")]
		public static bool CanRotate(this IGridEditRestriction gridEditRestriction, IProfile profile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0012
			if (gridEditRestriction != null && (object)typeof(IGridEditRestriction).TypeHandle != null)
			{
				int num = 0;
				bool result = default(bool);
				return result;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A46")]
		[Cpp2IlInjected.Address(RVA = "0x27B21C0", Offset = "0x27B0BC0", VA = "0x1827B21C0")]
		public static bool CanBeRemoved(this IGridEditRestriction gridEditRestriction, IProfile profile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0012
			if (gridEditRestriction != null && (object)typeof(IGridEditRestriction).TypeHandle != null)
			{
				int num = 0;
				bool result = default(bool);
				return result;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A47")]
		[Cpp2IlInjected.Address(RVA = "0x27B2150", Offset = "0x27B0B50", VA = "0x1827B2150")]
		public static bool CanBeCleared(this IGridEditRestriction gridEditRestriction)
		{
			//Discarded unreachable code: IL_0014
			//IL_0012: Expected I4, but got O
			if (gridEditRestriction != null && (object)typeof(IGridEditRestriction).TypeHandle != null)
			{
				return (byte)(int)typeof(IGridEditRestriction).TypeHandle != 0;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A48")]
		[Cpp2IlInjected.Address(RVA = "0x27B2270", Offset = "0x27B0C70", VA = "0x1827B2270")]
		public static bool CanBeSelected(this IGridEditRestriction gridEditRestriction, IProfile profile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0012
			if (gridEditRestriction != null && (object)typeof(IGridEditRestriction).TypeHandle != null)
			{
				int num = 0;
				bool result = default(bool);
				return result;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A49")]
		[Cpp2IlInjected.Address(RVA = "0x27B2480", Offset = "0x27B0E80", VA = "0x1827B2480")]
		public static bool CanSwitchGrid(this IGridEditRestriction gridEditRestriction, IProfile profile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0012
			if (gridEditRestriction != null && (object)typeof(IGridEditRestriction).TypeHandle != null)
			{
				int num = 0;
				bool result = default(bool);
				return result;
			}
			return true;
		}
	}
}
