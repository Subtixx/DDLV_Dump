using System;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class RpcException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x88"), Cpp2IlInjected.Token(Token = "0x4000033")]
		public StatusCode StatusCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x63F8C0", Offset = "0x63E2C0", VA = "0x18063F8C0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x90"), Cpp2IlInjected.Token(Token = "0x4000034")]
		private string RemoteStackTrace
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x38E2900", Offset = "0x38E1300", VA = "0x1838E2900")]
		private RpcException(StatusCode statusCode, string message, Exception innerException, string remoteStackTrace)
		{
			//IL_000b: Expected I4, but got I8
			//IL_001a: Expected O, but got I4
			StatusCode = StatusCode.Unknown;
			base._002Ector(message, innerException);
			RemoteStackTrace = (string)0;
			StatusCode = statusCode;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x38E2A20", Offset = "0x38E1420", VA = "0x1838E2A20")]
		public RpcException(StatusCode statusCode, string message, Exception innerException)
		{
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x38E28E0", Offset = "0x38E12E0", VA = "0x1838E28E0")]
		public RpcException(StatusCode statusCode, string message)
		{
			int num = 0;
			int num2 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x38E2A40", Offset = "0x38E1440", VA = "0x1838E2A40")]
		public RpcException(StatusCode statusCode, Exception innerException)
		{
			//Discarded unreachable code: IL_000e
			if (innerException != null)
			{
				string message = innerException.Message;
			}
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x38E2AF0", Offset = "0x38E14F0", VA = "0x1838E2AF0")]
		private RpcException()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x38E2B20", Offset = "0x38E1520", VA = "0x1838E2B20")]
		public RpcException(string message)
		{
			int num = 0;
			int num2 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x38E2B50", Offset = "0x38E1550", VA = "0x1838E2B50")]
		private RpcException(string message, Exception innerException)
		{
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x38E29B0", Offset = "0x38E13B0", VA = "0x1838E29B0")]
		public RpcException(ErrorInfo errorInfo)
		{
			//Discarded unreachable code: IL_0016
			StatusCode statusCode_ = errorInfo.statusCode_;
			Exception unknownErrorException = GetUnknownErrorException(errorInfo);
			string stackTrace_ = errorInfo.stackTrace_;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x38E2460", Offset = "0x38E0E60", VA = "0x1838E2460", Slot = "3")]
		public override string ToString()
		{
			while (true)
			{
				Exception innerException = base._innerException;
				if (innerException != null)
				{
					string fullName = innerException.GetType().FullName;
					string message = base._innerException.Message;
					string text = " ---> " + fullName + ": " + message;
				}
				if ((long)RemoteStackTrace == 0)
				{
					break;
				}
				string[] array = new string[8];
				string fullName2 = GetType().FullName;
				if (fullName2 != null && fullName2 == null)
				{
					continue;
				}
				array[0] = fullName2;
				if (": " != null && ": " == null)
				{
					continue;
				}
				array[1] = ": ";
				string message2 = Message;
				if (message2 != null && message2 == null)
				{
					continue;
				}
				array[2] = message2;
				if ("" != null && message2 == null)
				{
					continue;
				}
				array[3] = "";
				if ("\n--- Remote stack trace---\n" != null && "\n--- Remote stack trace---\n" == null)
				{
					continue;
				}
				array[4] = "\n--- Remote stack trace---\n";
				string text2 = RemoteStackTrace;
				if (text2 != null && "\n--- Remote stack trace---\n" == null)
				{
					continue;
				}
				array[5] = text2;
				if ("\n--- Local stack trace ---\n" == null || "\n--- Local stack trace ---\n" != null)
				{
					array[6] = "\n--- Local stack trace ---\n";
					string stackTrace = StackTrace;
					if (stackTrace == null || stackTrace != null)
					{
						array[7] = stackTrace;
						string text3 = string.Concat(array);
						break;
					}
				}
			}
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x38E21A0", Offset = "0x38E0BA0", VA = "0x1838E21A0")]
		private static Exception GetUnknownErrorException(ErrorInfo errorInfo)
		{
			//Discarded unreachable code: IL_0066, IL_006c, IL_0072, IL_0078, IL_007e
			Any unknownError_ = errorInfo.unknownError_;
			if (unknownError_ != null)
			{
				string text = unknownError_.TypeUrl.Substring(1);
				ByteString value = errorInfo.unknownError_.Value;
				System.Type typeFromHandle = typeof(UnknownException);
				if (((object)text).Equals((object)typeFromHandle))
				{
					int num = 0;
					object[] array = new object[1];
					object obj = default(object);
					if (obj == null || array != null)
					{
						array[0] = obj;
						object obj2 = default(object);
						if (obj2 != null)
						{
							int num2 = 0;
						}
					}
				}
			}
			throw new IndexOutOfRangeException();
		}
	}
}
