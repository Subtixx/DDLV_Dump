using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000211")]
	public class CurrencyItemView : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000920")]
		[SerializeField]
		private AsyncAtlassedIcon _mcCurrencyIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000921")]
		[SerializeField]
		private TextBase _tfAmount;

		[Cpp2IlInjected.Token(Token = "0x17000280")]
		public AsyncAtlassedIcon CurrencyAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000D0C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _mcCurrencyIcon;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0D")]
		[Cpp2IlInjected.Address(RVA = "0x111A930", Offset = "0x1119330", VA = "0x18111A930")]
		public void RefreshData(Item currencyItem, int amount, bool forceLayoutUpdate = false)
		{
			//Discarded unreachable code: IL_002c
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			if ((object)_mcCurrencyIcon != null)
			{
			}
			string text = default(string);
			_tfAmount.Text = text;
			if (forceLayoutUpdate)
			{
				LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponent<RectTransform>());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0E")]
		[Cpp2IlInjected.Address(RVA = "0x111AB10", Offset = "0x1119510", VA = "0x18111AB10")]
		public void RefreshData(IItemData currencyItemData, int amount, bool forceLayoutUpdate = false)
		{
			//Discarded unreachable code: IL_0025
			if ((object)_mcCurrencyIcon != null)
			{
			}
			string text = default(string);
			_tfAmount.Text = text;
			if (forceLayoutUpdate)
			{
				LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponent<RectTransform>());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0F")]
		[Cpp2IlInjected.Address(RVA = "0x111AC40", Offset = "0x1119640", VA = "0x18111AC40")]
		public void RefreshData(IItemData currencyItemData, string amount, bool forceLayoutUpdate = false)
		{
			//Discarded unreachable code: IL_0025
			if ((object)_mcCurrencyIcon != null)
			{
			}
			_tfAmount.Text = amount;
			if (forceLayoutUpdate)
			{
				LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponent<RectTransform>());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D10")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CurrencyItemView()
		{
		}
	}
}
