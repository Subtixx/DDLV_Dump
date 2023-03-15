using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	public class DeserializerDataReport : BaseDataReport
	{
		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public override string UniqueKey
		{
			[Cpp2IlInjected.Token(Token = "0x60006DC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return _003CUniqueKey_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60006DD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0", Slot = "12")]
			[CompilerGenerated]
			set
			{
				_003CUniqueKey_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		public override void Build(Context ctx)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x1024120", Offset = "0x1022B20", VA = "0x181024120")]
		public DeserializerDataReport()
		{
			//IL_0016: Expected O, but got I4
			Dictionary<string, object> dictionary = (base.Data = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>());
			int num = 0;
			Build((Context)num);
		}
	}
}
