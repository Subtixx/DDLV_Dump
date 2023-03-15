using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using PlayFab.ServerModels;

namespace PlayFab.Plugins.CloudScript
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class FunctionPlayerPlayStreamContext<TFunctionArgument>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class FunctionPlayerPlayStreamContextInternal
		{
			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public TFunctionArgument FunctionArgument
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return ((FunctionPlayerPlayStreamContext<>.FunctionPlayerPlayStreamContextInternal)(object)this)._003CFunctionArgument_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					((FunctionPlayerPlayStreamContext<>.FunctionPlayerPlayStreamContextInternal)(object)this)._003CFunctionArgument_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public PlayStreamEventEnvelope PlayStreamEventEnvelope
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return ((FunctionPlayerPlayStreamContext<>.FunctionPlayerPlayStreamContextInternal)(object)this)._003CPlayStreamEventEnvelope_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					((FunctionPlayerPlayStreamContext<>.FunctionPlayerPlayStreamContextInternal)(object)this)._003CPlayStreamEventEnvelope_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public PlayerProfile PlayerProfile
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return ((FunctionPlayerPlayStreamContext<>.FunctionPlayerPlayStreamContextInternal)(object)this)._003CPlayerProfile_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					((FunctionPlayerPlayStreamContext<>.FunctionPlayerPlayStreamContextInternal)(object)this)._003CPlayerProfile_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public TitleAuthenticationContext TitleAuthenticationContext
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return ((FunctionPlayerPlayStreamContext<>.FunctionPlayerPlayStreamContextInternal)(object)this)._003CTitleAuthenticationContext_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				set
				{
					((FunctionPlayerPlayStreamContext<>.FunctionPlayerPlayStreamContextInternal)(object)this)._003CTitleAuthenticationContext_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x911AA0", VA = "0x1809130A0")]
			public FunctionPlayerPlayStreamContextInternal()
			{
			}//Discarded unreachable code: IL_0007

		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public PlayFabApiSettings ApiSettings
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return ((FunctionPlayerPlayStreamContext<>)(object)this)._003CApiSettings_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				((FunctionPlayerPlayStreamContext<>)(object)this)._003CApiSettings_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public PlayFabAuthenticationContext AuthenticationContext
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return ((FunctionPlayerPlayStreamContext<>)(object)this)._003CAuthenticationContext_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				((FunctionPlayerPlayStreamContext<>)(object)this)._003CAuthenticationContext_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public PlayStreamEventEnvelope PlayStreamEventEnvelope
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return ((FunctionPlayerPlayStreamContext<>)(object)this)._003CPlayStreamEventEnvelope_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				((FunctionPlayerPlayStreamContext<>)(object)this)._003CPlayStreamEventEnvelope_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public PlayerProfile PlayerProfile
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return ((FunctionPlayerPlayStreamContext<>)(object)this)._003CPlayerProfile_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				((FunctionPlayerPlayStreamContext<>)(object)this)._003CPlayerProfile_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public TFunctionArgument FunctionArgument
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return ((FunctionPlayerPlayStreamContext<>)(object)this)._003CFunctionArgument_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				((FunctionPlayerPlayStreamContext<>)(object)this)._003CFunctionArgument_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string CurrentPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return ((FunctionPlayerPlayStreamContext<>)(object)this)._003CCurrentPlayerId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				((FunctionPlayerPlayStreamContext<>)(object)this)._003CCurrentPlayerId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x911AA0", VA = "0x1809130A0")]
		protected FunctionPlayerPlayStreamContext()
		{
		}//Discarded unreachable code: IL_0007


		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2692D90", Offset = "0x2691790", VA = "0x182692D90")]
		[AsyncStateMachine(typeof(FunctionPlayerPlayStreamContext<>._003CCreate_003Ed__25))]
		public static Task<FunctionPlayerPlayStreamContext<TFunctionArgument>> Create(HttpRequestMessage request)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<FunctionPlayerPlayStreamContext<TFunctionArgument>>)(object)result;
		}
	}
}
