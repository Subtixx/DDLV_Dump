using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace PlayFab.Plugins.CloudScript
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class FunctionTaskContext<TFunctionArgument>
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public class FunctionTaskContextInternal
		{
			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public NameIdentifier ScheduledTaskNameId
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return ((FunctionTaskContext<>.FunctionTaskContextInternal)(object)this)._003CScheduledTaskNameId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					((FunctionTaskContext<>.FunctionTaskContextInternal)(object)this)._003CScheduledTaskNameId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public Stack<PlayStreamEventHistory> EventHistory
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return ((FunctionTaskContext<>.FunctionTaskContextInternal)(object)this)._003CEventHistory_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					((FunctionTaskContext<>.FunctionTaskContextInternal)(object)this)._003CEventHistory_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public TitleAuthenticationContext TitleAuthenticationContext
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return ((FunctionTaskContext<>.FunctionTaskContextInternal)(object)this)._003CTitleAuthenticationContext_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					((FunctionTaskContext<>.FunctionTaskContextInternal)(object)this)._003CTitleAuthenticationContext_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public TFunctionArgument FunctionArgument
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return ((FunctionTaskContext<>.FunctionTaskContextInternal)(object)this)._003CFunctionArgument_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				set
				{
					((FunctionTaskContext<>.FunctionTaskContextInternal)(object)this)._003CFunctionArgument_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x911AA0", VA = "0x1809130A0")]
			public FunctionTaskContextInternal()
			{
			}//Discarded unreachable code: IL_0007

		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public PlayFabApiSettings ApiSettings
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return ((FunctionTaskContext<>)(object)this)._003CApiSettings_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				((FunctionTaskContext<>)(object)this)._003CApiSettings_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PlayFabAuthenticationContext AuthenticationContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return ((FunctionTaskContext<>)(object)this)._003CAuthenticationContext_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				((FunctionTaskContext<>)(object)this)._003CAuthenticationContext_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public NameIdentifier ScheduledTaskNameId
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return ((FunctionTaskContext<>)(object)this)._003CScheduledTaskNameId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				((FunctionTaskContext<>)(object)this)._003CScheduledTaskNameId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Stack<PlayStreamEventHistory> EventHistory
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return ((FunctionTaskContext<>)(object)this)._003CEventHistory_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				((FunctionTaskContext<>)(object)this)._003CEventHistory_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TFunctionArgument FunctionArgument
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return ((FunctionTaskContext<>)(object)this)._003CFunctionArgument_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				((FunctionTaskContext<>)(object)this)._003CFunctionArgument_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x911AA0", VA = "0x1809130A0")]
		protected FunctionTaskContext()
		{
		}//Discarded unreachable code: IL_0007


		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2693220", Offset = "0x2691C20", VA = "0x182693220")]
		[AsyncStateMachine(typeof(FunctionTaskContext<>._003CCreate_003Ed__21))]
		public static Task<FunctionTaskContext<TFunctionArgument>> Create(HttpRequestMessage request)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<FunctionTaskContext<TFunctionArgument>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2693410", Offset = "0x2691E10", VA = "0x182693410")]
		public static FunctionTaskContext<TFunctionArgument> Create(string body)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2693040", Offset = "0x2691A40", VA = "0x182693040")]
		public static FunctionTaskContextInternal CreateContext(NameIdentifier nameId, TitleAuthenticationContext authContext, TFunctionArgument arg)
		{
			//Discarded unreachable code: IL_001d
			FunctionTaskContext<>.FunctionTaskContextInternal functionTaskContextInternal = (FunctionTaskContext<>.FunctionTaskContextInternal)(object)new FunctionTaskContextInternal();
			((FunctionTaskContextInternal)(object)functionTaskContextInternal).ScheduledTaskNameId = nameId;
			((FunctionTaskContextInternal)(object)functionTaskContextInternal).TitleAuthenticationContext = authContext;
			((FunctionTaskContextInternal)(object)functionTaskContextInternal).FunctionArgument = arg;
			return (FunctionTaskContextInternal)(object)functionTaskContextInternal;
		}
	}
}
