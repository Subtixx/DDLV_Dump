using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using PlayFab.ProfilesModels;

namespace PlayFab.Plugins.CloudScript
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class FunctionContext<TFunctionArgument>
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class FunctionContextInternal
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public TitleAuthenticationContext TitleAuthenticationContext
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return ((FunctionContext<>.FunctionContextInternal)(object)this)._003CTitleAuthenticationContext_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					((FunctionContext<>.FunctionContextInternal)(object)this)._003CTitleAuthenticationContext_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public EntityProfileBody CallerEntityProfile
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return ((FunctionContext<>.FunctionContextInternal)(object)this)._003CCallerEntityProfile_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					((FunctionContext<>.FunctionContextInternal)(object)this)._003CCallerEntityProfile_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public TFunctionArgument FunctionArgument
			{
				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return ((FunctionContext<>.FunctionContextInternal)(object)this)._003CFunctionArgument_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					((FunctionContext<>.FunctionContextInternal)(object)this)._003CFunctionArgument_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x911AA0", VA = "0x1809130A0")]
			public FunctionContextInternal()
			{
			}//Discarded unreachable code: IL_0007

		}

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public PlayFabApiSettings ApiSettings
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return ((FunctionContext<>)(object)this)._003CApiSettings_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				((FunctionContext<>)(object)this)._003CApiSettings_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public PlayFabAuthenticationContext AuthenticationContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return ((FunctionContext<>)(object)this)._003CAuthenticationContext_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				((FunctionContext<>)(object)this)._003CAuthenticationContext_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EntityProfileBody CallerEntityProfile
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return ((FunctionContext<>)(object)this)._003CCallerEntityProfile_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				((FunctionContext<>)(object)this)._003CCallerEntityProfile_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public TFunctionArgument FunctionArgument
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return ((FunctionContext<>)(object)this)._003CFunctionArgument_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				((FunctionContext<>)(object)this)._003CFunctionArgument_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CurrentPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return ((FunctionContext<>)(object)this)._003CCurrentPlayerId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				((FunctionContext<>)(object)this)._003CCurrentPlayerId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x911AA0", VA = "0x1809130A0")]
		protected FunctionContext()
		{
		}//Discarded unreachable code: IL_0007


		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2692BA0", Offset = "0x26915A0", VA = "0x182692BA0")]
		[AsyncStateMachine(typeof(FunctionContext<>._003CCreate_003Ed__21))]
		public static Task<FunctionContext<TFunctionArgument>> Create(HttpRequestMessage request)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<FunctionContext<TFunctionArgument>>)(object)result;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class FunctionContext : FunctionContext<object>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x102EAD0", Offset = "0x102D4D0", VA = "0x18102EAD0")]
		public FunctionContext()
		{
			((FunctionContext<TFunctionArgument>)(object)this)._002Ector();
		}
	}
}
