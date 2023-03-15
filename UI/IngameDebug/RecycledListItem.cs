using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[RequireComponent(typeof(RectTransform))]
	public class RecycledListItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private IListViewAdapter adapter;

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public object Tag
		{
			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CTag_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CTag_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x400041D")]
		public int Position
		{
			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
		internal void SetAdapter(IListViewAdapter adapter)
		{
			this.adapter = adapter;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0xF41AA0", Offset = "0xF404A0", VA = "0x180F41AA0")]
		public void OnClick()
		{
			IListViewAdapter listViewAdapter = adapter;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public RecycledListItem()
		{
		}
	}
}
