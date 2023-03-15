using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab.ProfilesModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public class FunctionExecutionContext<T>
	{
		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public EntityProfileBody CallerEntityProfile
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return ((FunctionExecutionContext<>)(object)this)._003CCallerEntityProfile_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				((FunctionExecutionContext<>)(object)this)._003CCallerEntityProfile_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public TitleAuthenticationContext TitleAuthenticationContext
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return ((FunctionExecutionContext<>)(object)this)._003CTitleAuthenticationContext_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				((FunctionExecutionContext<>)(object)this)._003CTitleAuthenticationContext_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x40002D6")]
		public bool? GeneratePlayStreamEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x20B19F0", Offset = "0x20B03F0", VA = "0x1820B19F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x20B1C30", Offset = "0x20B0630", VA = "0x1820B1C30")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public T FunctionArgument
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x911AA0", VA = "0x1809130A0")]
		public FunctionExecutionContext()
		{
		}//Discarded unreachable code: IL_0007

	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public class FunctionExecutionContext : FunctionExecutionContext<object>
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x102EB10", Offset = "0x102D510", VA = "0x18102EB10")]
		public FunctionExecutionContext()
		{
			((FunctionExecutionContext<T>)(object)this)._002Ector();
		}
	}
}
