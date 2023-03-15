using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2IlInjected;
using Rewired.UI;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class PlayerPointerEventData : PointerEventData
	{
		[Cpp2IlInjected.Token(Token = "0x1700022D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x138"), Cpp2IlInjected.Token(Token = "0x4000220")]
		public int playerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x18D7A70", Offset = "0x18D6470", VA = "0x1818D7A70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x18D8120", Offset = "0x18D6B20", VA = "0x1818D8120")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x13C"), Cpp2IlInjected.Token(Token = "0x4000221")]
		public int inputSourceIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x1E96EE0", Offset = "0x1E958E0", VA = "0x181E96EE0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x1E96F00", Offset = "0x1E95900", VA = "0x181E96F00")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		public IMouseInputSource mouseSource
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x975DE0", Offset = "0x9747E0", VA = "0x180975DE0")]
			[CompilerGenerated]
			get
			{
				return _003CmouseSource_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x9765B0", Offset = "0x974FB0", VA = "0x1809765B0")]
			[CompilerGenerated]
			set
			{
				_003CmouseSource_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000230")]
		public ITouchInputSource touchSource
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x738F60", Offset = "0x737960", VA = "0x180738F60")]
			[CompilerGenerated]
			get
			{
				return _003CtouchSource_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x9765D0", Offset = "0x974FD0", VA = "0x1809765D0")]
			[CompilerGenerated]
			set
			{
				_003CtouchSource_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000231")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x150"), Cpp2IlInjected.Token(Token = "0x4000224")]
		public PointerEventType sourceType
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0xA5C3E0", Offset = "0xA5ADE0", VA = "0x180A5C3E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x1E96F10", Offset = "0x1E95910", VA = "0x181E96F10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000232")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x154"), Cpp2IlInjected.Token(Token = "0x4000225")]
		public int buttonIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x1E96ED0", Offset = "0x1E958D0", VA = "0x181E96ED0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x1E96EF0", Offset = "0x1E958F0", VA = "0x181E96EF0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x1E96EA0", Offset = "0x1E958A0", VA = "0x181E96EA0")]
		public PlayerPointerEventData(EventSystem eventSystem)
			: base(eventSystem)
		{
			//IL_0010: Expected I4, but got I8
			//IL_0020: Expected I4, but got I8
			playerId = -1;
			buttonIndex = -1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x1E96C10", Offset = "0x1E95610", VA = "0x181E96C10", Slot = "3")]
		public override string ToString()
		{
			//Discarded unreachable code: IL_00e3
			//IL_003e: Expected O, but got I4
			//IL_008c: Expected O, but got I4
			StringBuilder stringBuilder = new StringBuilder();
			int num = playerId;
			string text = default(string);
			string value = "<b>Player Id</b>: " + text;
			StringBuilder stringBuilder2 = stringBuilder.AppendLine(value);
			IMouseInputSource mouseInputSource = mouseSource;
			int num2 = 0;
			if (mouseInputSource != null)
			{
			}
			string value2 = "<b>Mouse Source</b>: " + (string)num2;
			StringBuilder stringBuilder3 = stringBuilder.AppendLine(value2);
			int num3 = inputSourceIndex;
			string text2 = default(string);
			string value3 = "<b>Input Source Index</b>: " + text2;
			StringBuilder stringBuilder4 = stringBuilder.AppendLine(value3);
			if (touchSource != null)
			{
			}
			string value4 = default(string);
			StringBuilder stringBuilder5 = stringBuilder.AppendLine(value4);
			PointerEventType pointerEventType = sourceType;
			string text3 = ((Enum)pointerEventType).ToString();
			PointerEventType pointerEventType2 = pointerEventType;
			string value5 = "<b>Source Type</b>: " + text3;
			StringBuilder stringBuilder6 = stringBuilder.AppendLine(value5);
			int num4 = buttonIndex;
			string text4 = default(string);
			string value6 = "<b>Button Index</b>: " + text4;
			StringBuilder stringBuilder7 = stringBuilder.AppendLine(value6);
			string value7 = base.ToString();
			StringBuilder stringBuilder8 = stringBuilder.Append(value7);
			return stringBuilder.ToString();
		}
	}
}
