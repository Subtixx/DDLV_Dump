using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab.ProfilesModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public class EntityPlayStreamFunctionExecutionContext<TPayload, TArg>
	{
		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public EntityProfileBody CallerEntityProfile
		{
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return ((EntityPlayStreamFunctionExecutionContext<, >)(object)this)._003CCallerEntityProfile_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				((EntityPlayStreamFunctionExecutionContext<, >)(object)this)._003CCallerEntityProfile_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		public EntityPlayStreamEvent<TPayload> PlayStreamEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return ((EntityPlayStreamFunctionExecutionContext<, >)(object)this)._003CPlayStreamEvent_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				((EntityPlayStreamFunctionExecutionContext<, >)(object)this)._003CPlayStreamEvent_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		public TitleAuthenticationContext TitleAuthenticationContext
		{
			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return ((EntityPlayStreamFunctionExecutionContext<, >)(object)this)._003CTitleAuthenticationContext_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				((EntityPlayStreamFunctionExecutionContext<, >)(object)this)._003CTitleAuthenticationContext_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x40002F6")]
		public bool? GeneratePlayStreamEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x91C2B0", Offset = "0x91ACB0", VA = "0x18091C2B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x91C2C0", Offset = "0x91ACC0", VA = "0x18091C2C0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public TArg FunctionArgument
		{
			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x911AA0", VA = "0x1809130A0")]
		public EntityPlayStreamFunctionExecutionContext()
		{
		}//Discarded unreachable code: IL_0007

	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public class EntityPlayStreamFunctionExecutionContext : EntityPlayStreamFunctionExecutionContext<object, object>
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x102E260", Offset = "0x102CC60", VA = "0x18102E260")]
		public EntityPlayStreamFunctionExecutionContext()
		{
			((EntityPlayStreamFunctionExecutionContext<TPayload, TArg>)(object)this)._002Ector();
		}
	}
}
