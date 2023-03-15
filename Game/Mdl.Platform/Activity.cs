using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002D4")]
	internal class Activity
	{
		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000C7C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C7D")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		public string UdsId
		{
			[Cpp2IlInjected.Token(Token = "0x6000C7E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CUdsId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C7F")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CUdsId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x400159A")]
		public ActivityState State
		{
			[Cpp2IlInjected.Token(Token = "0x6000C80")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000C81")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public List<ActivityTask> Tasks
		{
			[Cpp2IlInjected.Token(Token = "0x6000C82")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CTasks_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C83")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CTasks_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C84")]
		[Cpp2IlInjected.Address(RVA = "0xA3C4D0", Offset = "0xA3AED0", VA = "0x180A3C4D0")]
		public Activity(string id, string udsId)
		{
			//IL_001d: Expected I4, but got I8
			Id = id;
			UdsId = udsId;
			State = ActivityState.NotStarted;
		}
	}
}
