using Cpp2IlInjected;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007B6")]
	public class SavegameManagerConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002BBA")]
		public readonly float AutoSaveEveryXSeconds = 300f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4002BBB")]
		public readonly int SaveOnSuspendDelaySeconds = 120;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002BBC")]
		public readonly bool IsDelayingWrite = true;

		[Cpp2IlInjected.Token(Token = "0x170004C8")]
		public bool IsDisplayingThrobber
		{
			[Cpp2IlInjected.Token(Token = "0x6002247")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002248")]
		[Cpp2IlInjected.Address(RVA = "0xCC7300", Offset = "0xCC5D00", VA = "0x180CC7300")]
		public SavegameManagerConfig()
		{
		}//IL_0015: Expected I4, but got I8

	}
}
