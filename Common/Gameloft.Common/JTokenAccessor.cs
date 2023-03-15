using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Linq;

namespace Gameloft.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class JTokenAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public JToken Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1CB5F00", Offset = "0x1CB4900", VA = "0x181CB5F00", Slot = "3")]
		public override string ToString()
		{
			JToken jToken = Data.CloneToken();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public JTokenAccessor(JToken data)
		{
			Data = data;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public JTokenAccessor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x19B1210", Offset = "0x19AFC10", VA = "0x1819B1210")]
		public T GetAs<T>(string key)
		{
			JToken jToken = Data.CloneToken();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x19B11E0", Offset = "0x19AFBE0", VA = "0x1819B11E0")]
		public T GetAsOrDefault<T>(string key, [Optional] T defaultValue)
		{
			JToken jToken = Data.CloneToken();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x19B1150", Offset = "0x19AFB50", VA = "0x1819B1150")]
		public T GetAccessor<T>(string key) where T : JTokenAccessor, new()
		{
			JToken jToken = Data;
			int num = 0;
			JToken jToken2 = jToken.CloneToken();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x19B1100", Offset = "0x19AFB00", VA = "0x1819B1100")]
		public static T CreateAccessor<T>(JToken token) where T : JTokenAccessor, new()
		{
			throw new NullReferenceException();
		}
	}
}
