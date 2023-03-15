using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20009A7")]
	public class AddDetail
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40027E8")]
		public readonly bool? inVillage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40027E9")]
		public readonly string missionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40027EA")]
		public readonly Item? characterItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40027EB")]
		public readonly InvActionType reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40027EC")]
		public readonly string source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40027ED")]
		public readonly string transactionNameOverride;

		[Cpp2IlInjected.Token(Token = "0x6005469")]
		[Cpp2IlInjected.Address(RVA = "0x18E5100", Offset = "0x18E3B00", VA = "0x1818E5100")]
		public unsafe AddDetail([Optional] bool? inVillage, [Optional] string missionName, [Optional] Item? characterItem, InvActionType reason = InvActionType.None, [Optional] string source, [Optional] string transactionNameOverride)
		{
			//IL_000b: Expected O, but got I4
			//IL_0020: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			int num = 0;
			base.FieldGetter((string)num, missionName, ref *(object*)characterItem);
			this.missionName = missionName;
			this.inVillage = inVillage;
			this.source = (string)0;
			this.characterItem = characterItem;
			this.reason = InvActionType.Cooking;
			this.transactionNameOverride = (string)0;
			/*Error: Unexpected end of block*/;
		}
	}
}
