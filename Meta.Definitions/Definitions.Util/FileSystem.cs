using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Gameloft.FileSystem.Abstraction;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public static class FileSystem
	{
		[Cpp2IlInjected.Token(Token = "0x17000320")]
		public static IFileSystem Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000CFB")]
			[Cpp2IlInjected.Address(RVA = "0x35746D0", Offset = "0x35730D0", VA = "0x1835746D0")]
			[CompilerGenerated]
			get
			{
				return _003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CFC")]
			[Cpp2IlInjected.Address(RVA = "0x35747D0", Offset = "0x35731D0", VA = "0x1835747D0")]
			[CompilerGenerated]
			set
			{
				_003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000321")]
		public static IFileSystem Save
		{
			[Cpp2IlInjected.Token(Token = "0x6000CFD")]
			[Cpp2IlInjected.Address(RVA = "0x3574750", Offset = "0x3573150", VA = "0x183574750")]
			[CompilerGenerated]
			get
			{
				return _003CSave_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CFE")]
			[Cpp2IlInjected.Address(RVA = "0x3574870", Offset = "0x3573270", VA = "0x183574870")]
			[CompilerGenerated]
			set
			{
				Data = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000322")]
		public static IFileSystem SaveGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x6000CFF")]
			[Cpp2IlInjected.Address(RVA = "0x3574710", Offset = "0x3573110", VA = "0x183574710")]
			[CompilerGenerated]
			get
			{
				return _003CSaveGlobal_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D00")]
			[Cpp2IlInjected.Address(RVA = "0x3574820", Offset = "0x3573220", VA = "0x183574820")]
			[CompilerGenerated]
			set
			{
				Data = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000323")]
		public static IFileSystem Temp
		{
			[Cpp2IlInjected.Token(Token = "0x6000D01")]
			[Cpp2IlInjected.Address(RVA = "0x3574790", Offset = "0x3573190", VA = "0x183574790")]
			[CompilerGenerated]
			get
			{
				return _003CTemp_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D02")]
			[Cpp2IlInjected.Address(RVA = "0x35748C0", Offset = "0x35732C0", VA = "0x1835748C0")]
			[CompilerGenerated]
			set
			{
				Data = value;
				/*Error: Unexpected end of block*/;
			}
		}
	}
}
