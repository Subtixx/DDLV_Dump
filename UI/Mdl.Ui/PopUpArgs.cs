using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000218")]
	public class PopUpArgs
	{
		[Cpp2IlInjected.Token(Token = "0x17000286")]
		public string MessageStrID
		{
			[Cpp2IlInjected.Token(Token = "0x6000D2F")]
			[Cpp2IlInjected.Address(RVA = "0xE143F0", Offset = "0xE12DF0", VA = "0x180E143F0")]
			get
			{
				IEnumerable<string> enumerable = MessageStrIDs;
				if (enumerable == null || Enumerable.First<string>((IEnumerable<>)enumerable) == null)
				{
				}
				return "";
			}
			[Cpp2IlInjected.Token(Token = "0x6000D30")]
			[Cpp2IlInjected.Address(RVA = "0xE14450", Offset = "0xE12E50", VA = "0x180E14450")]
			set
			{
				string[] array;
				do
				{
					array = new string[1];
				}
				while (value != null && array == null);
				array[0] = value;
				MessageStrIDs = array;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000287")]
		public IEnumerable<string> MessageStrIDs
		{
			[Cpp2IlInjected.Token(Token = "0x6000D31")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CMessageStrIDs_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D32")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CMessageStrIDs_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000288")]
		public string DevNote
		{
			[Cpp2IlInjected.Token(Token = "0x6000D33")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CDevNote_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D34")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CDevNote_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000289")]
		public string TitleStrID
		{
			[Cpp2IlInjected.Token(Token = "0x6000D35")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CTitleStrID_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D36")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CTitleStrID_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4000941")]
		public bool ShowCloseButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000D37")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000D38")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700028B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x29"), Cpp2IlInjected.Token(Token = "0x4000942")]
		public bool SkipLocManager
		{
			[Cpp2IlInjected.Token(Token = "0x6000D39")]
			[Cpp2IlInjected.Address(RVA = "0xA44560", Offset = "0xA42F60", VA = "0x180A44560")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000D3A")]
			[Cpp2IlInjected.Address(RVA = "0xDC79B0", Offset = "0xDC63B0", VA = "0x180DC79B0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700028C")]
		public PopUpAnswerHandler Callback
		{
			[Cpp2IlInjected.Token(Token = "0x6000D3B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CCallback_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D3C")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CCallback_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028D")]
		public object CallbackParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000D3D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CCallbackParams_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D3E")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CCallbackParams_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x4000945")]
		public bool BlurBackground
		{
			[Cpp2IlInjected.Token(Token = "0x6000D3F")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000D40")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700028F")]
		public IEnumerable<AlertButton> ButtonsList
		{
			[Cpp2IlInjected.Token(Token = "0x6000D41")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CButtonsList_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D42")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			set
			{
				_003CButtonsList_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000290")]
		public Event ConfirmSFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000D43")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CConfirmSFX_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D44")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			set
			{
				_003CConfirmSFX_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000291")]
		public Event CancelSFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000D45")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003CCancelSFX_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D46")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			set
			{
				_003CCancelSFX_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000292")]
		public string PopupSFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000D47")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			[CompilerGenerated]
			get
			{
				return _003CPopupSFX_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D48")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			[CompilerGenerated]
			set
			{
				_003CPopupSFX_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D49")]
		[Cpp2IlInjected.Address(RVA = "0xE142E0", Offset = "0xE12CE0", VA = "0x180E142E0")]
		public PopUpArgs()
		{
			//IL_004d: Expected O, but got I4
			//IL_0054: Expected O, but got I4
			//IL_005b: Expected O, but got I4
			//IL_0062: Expected O, but got I4
			string[] array = (string[])(MessageStrIDs = Array.Empty<string>());
			DevNote = "";
			TitleStrID = "";
			ShowCloseButton = false;
			BlurBackground = true;
			AlertButton[] array2 = (AlertButton[])(ButtonsList = Array.Empty<AlertButton>());
			int num = 0;
			Callback = (PopUpAnswerHandler)num;
			CallbackParams = num;
			ConfirmSFX = (Event)num;
			CancelSFX = (Event)num;
			PopupSFX = "";
			/*Error: Unexpected end of block*/;
		}
	}
}
