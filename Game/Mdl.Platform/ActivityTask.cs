using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002D5")]
	internal class ActivityTask
	{
		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000C85")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C86")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public string UdsId
		{
			[Cpp2IlInjected.Token(Token = "0x6000C87")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CUdsId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C88")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CUdsId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x400159E")]
		public ActivityState State
		{
			[Cpp2IlInjected.Token(Token = "0x6000C89")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000C8A")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x24"), Cpp2IlInjected.Token(Token = "0x400159F")]
		public ActivityType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8B")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000C8C")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8D")]
		[Cpp2IlInjected.Address(RVA = "0xA3C460", Offset = "0xA3AE60", VA = "0x180A3C460")]
		public unsafe ActivityTask(string id, string udsId, ActivityType activityType)
		{
			//IL_000d: Expected O, but got I4
			//IL_002b: Expected I4, but got I8
			int num = 0;
			base.FieldGetter((string)num, udsId, ref *(object*)(int)activityType);
			Id = id;
			UdsId = udsId;
			Type = activityType;
			State = ActivityState.NotStarted;
		}
	}
}
