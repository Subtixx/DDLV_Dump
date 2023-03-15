using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Mdl.Platform.Xbox
{
	[Cpp2IlInjected.Token(Token = "0x200030D")]
	public class ErrorEventArgs : EventArgs
	{
		[Cpp2IlInjected.Token(Token = "0x17000198")]
		public string ErrorCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000D57")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CErrorCode_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D58")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				_003CErrorCode_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public string ErrorMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000D59")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CErrorMessage_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D5A")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			private set
			{
				_003CErrorMessage_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5B")]
		[Cpp2IlInjected.Address(RVA = "0x1367860", Offset = "0x1366260", VA = "0x181367860")]
		public ErrorEventArgs(string errorCode, string errorMessage)
		{
			ErrorCode = errorCode;
			ErrorMessage = errorMessage;
			/*Error: Unexpected end of block*/;
		}
	}
}
