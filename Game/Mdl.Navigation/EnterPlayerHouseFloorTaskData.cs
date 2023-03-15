using Cpp2IlInjected;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BBF")]
	internal class EnterPlayerHouseFloorTaskData : IPlayerTaskData
	{
		[Cpp2IlInjected.Token(Token = "0x1700074A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400418C")]
		public int FloorIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6003616")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003617")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6003618")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public EnterPlayerHouseFloorTaskData()
		{
		}
	}
}
