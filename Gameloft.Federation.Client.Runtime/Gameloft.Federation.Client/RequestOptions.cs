using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class RequestOptions
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Dictionary<string, string> PathParameters
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CPathParameters_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CPathParameters_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Multimap<string, string> QueryParameters
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CQueryParameters_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CQueryParameters_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Multimap<string, string> HeaderParameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CHeaderParameters_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CHeaderParameters_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Dictionary<string, string> FormParameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CFormParameters_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CFormParameters_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Dictionary<string, byte[]> BytesFormParameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CBytesFormParameters_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CBytesFormParameters_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Dictionary<string, Stream> FileParameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CFileParameters_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CFileParameters_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public List<Cookie> Cookies
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			set
			{
				_003CCookies_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x400005A")]
		public object Data
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4033D80", Offset = "0x4032780", VA = "0x184033D80")]
		public RequestOptions()
		{
			Dictionary<string, string> dictionary = (PathParameters = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>());
			Multimap<string, string> multimap = (QueryParameters = (Multimap<string, string>)(object)new Multimap<TKey, TValue>());
			Multimap<string, string> multimap2 = (HeaderParameters = (Multimap<string, string>)(object)new Multimap<TKey, TValue>());
			Dictionary<string, string> dictionary2 = (FormParameters = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>());
			Dictionary<string, byte[]> dictionary3 = (BytesFormParameters = (Dictionary<string, byte[]>)(object)new Dictionary<TKey, TValue>());
			Dictionary<string, Stream> dictionary4 = (FileParameters = (Dictionary<string, Stream>)(object)new Dictionary<TKey, TValue>());
			List<Cookie> list = (_003CCookies_003Ek__BackingField = (List<Cookie>)(object)new List<T>());
			/*Error: Unexpected end of block*/;
		}
	}
}
