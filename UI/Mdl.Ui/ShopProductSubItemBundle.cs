using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000706")]
	public class ShopProductSubItemBundle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002857")]
		[SerializeField]
		private AsyncAtlassedIcon _mcImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002858")]
		[SerializeField]
		private TextBase _tfAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002859")]
		[SerializeField]
		private GameObject _mcRarity;

		[Cpp2IlInjected.Token(Token = "0x17000676")]
		public RawImage RawImage
		{
			[Cpp2IlInjected.Token(Token = "0x6002CC1")]
			[Cpp2IlInjected.Address(RVA = "0x143BE30", Offset = "0x143A830", VA = "0x18143BE30")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _mcImage.RawImage;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000677")]
		public ItemReward ItemReward
		{
			[Cpp2IlInjected.Token(Token = "0x6002CC2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CItemReward_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CC3")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CItemReward_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CC4")]
		[Cpp2IlInjected.Address(RVA = "0x143B7E0", Offset = "0x143A1E0", VA = "0x18143B7E0")]
		public void RefreshDisplay(ItemReward reward)
		{
			//Discarded unreachable code: IL_0110, IL_0116, IL_011c, IL_0122, IL_0134
			//IL_0051: Expected O, but got I4
			//IL_009d: Expected I4, but got I8
			int num = 0;
			ItemReward = reward;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = reward.Item;
			AsyncAtlassedIcon mcImage = _mcImage;
			TextBase tfAmount = _tfAmount;
			string text = default(string);
			string text3 = (tfAmount.Text = "x" + text);
			if ((object)_tfAmount.transform != null)
			{
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)num);
			if ((object)_tfAmount.transform.parent != null)
			{
			}
			Item item2 = reward.Item;
			ItemType itemType = default(ItemType);
			if (itemType != ItemType.Furniture)
			{
				Item item3 = reward.Item;
				ItemType itemType2 = default(ItemType);
				if (itemType2 != ItemType.Clothing)
				{
					goto IL_010c;
				}
			}
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			Item item4 = reward.Item;
			ulong num2 = default(ulong);
			_mcRarity.SetActive((byte)num2 != 0);
			IEnumerator enumerator = _mcRarity.transform.GetEnumerator();
			if (enumerator != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				int num4 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num5 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				uint num6 = default(uint);
				if (num < (int)num6)
				{
					num += num;
					num++;
				}
				bool flag = num < num;
				GameObject gameObject = default(GameObject);
				gameObject.SetActive(flag);
				num++;
				flag = (byte)((flag ? 1u : 0u) + (flag ? 1u : 0u)) != 0;
				num += 312;
			}
			num++;
			if (num != 0)
			{
			}
			if (num == 0)
			{
			}
			goto IL_010c;
			IL_010c:
			int num7 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CC5")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ShopProductSubItemBundle()
		{
		}
	}
}
