using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000634")]
	public class DataValidationError
	{
		[Cpp2IlInjected.Token(Token = "0x170012F2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400220B")]
		public string Message
		{
			[Cpp2IlInjected.Token(Token = "0x600499A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170012F3")]
		public object Owner
		{
			[Cpp2IlInjected.Token(Token = "0x600499B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003COwner_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600499C")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			private set
			{
				_003COwner_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012F4")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x400220D")]
		public string FullStackName
		{
			[Cpp2IlInjected.Token(Token = "0x600499D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600499E")]
		[Cpp2IlInjected.Address(RVA = "0x356C7F0", Offset = "0x356B1F0", VA = "0x18356C7F0")]
		public DataValidationError(string message, object owner, DataValidation.Context context)
		{
			Message = message;
			Owner = owner;
			if (context == null || context.FullStackName == null)
			{
			}
			FullStackName = "";
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600499F")]
		[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
		public void OverrideOwner(object newOwner)
		{
			Owner = newOwner;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60049A0")]
		[Cpp2IlInjected.Address(RVA = "0x356C790", Offset = "0x356B190", VA = "0x18356C790", Slot = "3")]
		public override string ToString()
		{
			string text = FullStackName;
			return Message + "\nContext: " + text + "\n\n";
		}
	}
}
