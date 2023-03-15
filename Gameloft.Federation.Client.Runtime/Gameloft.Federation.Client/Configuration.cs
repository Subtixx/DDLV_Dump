using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class Configuration : IReadableConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string basePath;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public virtual string BasePath
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "6")]
			get
			{
				return basePath;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500", Slot = "7")]
			set
			{
				basePath = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public virtual string UserAgent
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510", Slot = "8")]
			[CompilerGenerated]
			set
			{
				_003CUserAgent_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IRequestSender RequestSender
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return _003CRequestSender_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CRequestSender_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = DefaultRequestSender.Instance;


		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4032DE0", Offset = "0x40317E0", VA = "0x184032DE0")]
		public Configuration()
		{
			UserAgent = "FederationApiNet/1.0.0";
		}
	}
}
