using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Gameloft.Tracking.Device
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class DxInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CVersion_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CVersion_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x402CA40", Offset = "0x402B440", VA = "0x18402CA40")]
		[AsyncStateMachine(typeof(_003CCollectAsync_003Ed__4))]
		public static Task<DxInfo> CollectAsync()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<DxInfo>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public DxInfo()
		{
		}
	}
}
