using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200030B")]
	public class CollectionTooltip : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000ED2")]
		public RecycleBin RecycleBin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000ED3")]
		public UnityEvent OnRefresh;

		[Cpp2IlInjected.Token(Token = "0x17000362")]
		public CollectionItem CollectionItem
		{
			[Cpp2IlInjected.Token(Token = "0x60013C0")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CCollectionItem_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60013C1")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CCollectionItem_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000363")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4000ED0")]
		public bool IsOnBottom
		{
			[Cpp2IlInjected.Token(Token = "0x60013C2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60013C3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000364")]
		public CollectionTooltipModel Model
		{
			[Cpp2IlInjected.Token(Token = "0x60013C4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CModel_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60013C5")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CModel_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013C6")]
		[Cpp2IlInjected.Address(RVA = "0x114F360", Offset = "0x114DD60", VA = "0x18114F360")]
		public void RefreshDisplay()
		{
			CollectionTooltipModel collectionTooltipModel = Model;
			if (collectionTooltipModel != null)
			{
				collectionTooltipModel.UpdateDisplay(this);
				OnRefresh?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013C7")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CollectionTooltip()
		{
		}
	}
}
