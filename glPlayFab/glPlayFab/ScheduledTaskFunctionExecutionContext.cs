using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab.CloudScriptModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public class ScheduledTaskFunctionExecutionContext<T>
	{
		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public NameIdentifier ScheduledTaskNameId
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return ((ScheduledTaskFunctionExecutionContext<>)(object)this)._003CScheduledTaskNameId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				((ScheduledTaskFunctionExecutionContext<>)(object)this)._003CScheduledTaskNameId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public Stack<PlayStreamEventHistory> EventHistory
		{
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return ((ScheduledTaskFunctionExecutionContext<>)(object)this)._003CEventHistory_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				((ScheduledTaskFunctionExecutionContext<>)(object)this)._003CEventHistory_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public TitleAuthenticationContext TitleAuthenticationContext
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return ((ScheduledTaskFunctionExecutionContext<>)(object)this)._003CTitleAuthenticationContext_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				((ScheduledTaskFunctionExecutionContext<>)(object)this)._003CTitleAuthenticationContext_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x40002E4")]
		public bool? GeneratePlayStreamEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x91C2B0", Offset = "0x91ACB0", VA = "0x18091C2B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x91C2C0", Offset = "0x91ACC0", VA = "0x18091C2C0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public T FunctionArgument
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x911AA0", VA = "0x1809130A0")]
		public ScheduledTaskFunctionExecutionContext()
		{
		}//Discarded unreachable code: IL_0007

	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public class ScheduledTaskFunctionExecutionContext : ScheduledTaskFunctionExecutionContext<object>
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x14F5350", Offset = "0x14F3D50", VA = "0x1814F5350")]
		public ScheduledTaskFunctionExecutionContext()
		{
			((ScheduledTaskFunctionExecutionContext<T>)(object)this)._002Ector();
		}
	}
}
