using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006DC")]
	public class ShopProductGroupBundlePaging : ShopProductGroupDefault
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40026AF")]
		private MenuNavigation _menuNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40026B0")]
		private List<ShopProductModel> _products;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40026B1")]
		private int _currentIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40026B2")]
		private ShopProductItemDefault _currentProductItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40026B4")]
		public GameObject McNavi;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40026B5")]
		public GameObject McIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40026B6")]
		[SerializeField]
		protected GameObject _prefabProductCharacterBundle;

		[Cpp2IlInjected.Token(Token = "0x1700066A")]
		public List<ShopProductItemCustomizedBundleTemplate> Templates
		{
			[Cpp2IlInjected.Token(Token = "0x6002BFB")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CTemplates_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BFC")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			set
			{
				_003CTemplates_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BFD")]
		[Cpp2IlInjected.Address(RVA = "0x142BBA0", Offset = "0x142A5A0", VA = "0x18142BBA0")]
		private void Start()
		{
			MenuNavigation menuNavigation = (_menuNavigation = GetComponentInParent<MenuNavigation>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BFE")]
		[Cpp2IlInjected.Address(RVA = "0x8B48F0", Offset = "0x8B32F0", VA = "0x1808B48F0")]
		private void OnDisable()
		{
			StopAllCoroutines();
		}

		[Cpp2IlInjected.Token(Token = "0x6002BFF")]
		[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10", Slot = "4")]
		public override void RefreshData(List<ShopProductModel> products)
		{
			_products = products;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C00")]
		[Cpp2IlInjected.Address(RVA = "0x142B170", Offset = "0x1429B70", VA = "0x18142B170", Slot = "5")]
		public override void RefreshDisplay()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002C01")]
		[Cpp2IlInjected.Address(RVA = "0x142B100", Offset = "0x1429B00", VA = "0x18142B100")]
		[IteratorStateMachine(typeof(_003COnRepeat_003Ed__15))]
		private IEnumerator OnRepeat()
		{
			int _003C_003E1__state = default(int);
			_003COnRepeat_003Ed__15 _003COnRepeat_003Ed__ = new _003COnRepeat_003Ed__15(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnRepeat_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C02")]
		[Cpp2IlInjected.Address(RVA = "0x142A9C0", Offset = "0x14293C0", VA = "0x18142A9C0")]
		public void OnClicked()
		{
			//Discarded unreachable code: IL_0025
			StopAllCoroutines();
			OnNextPage();
			int _003C_003E1__state = default(int);
			_003COnRepeat_003Ed__15 _003COnRepeat_003Ed__ = new _003COnRepeat_003Ed__15(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnRepeat_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003COnRepeat_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C03")]
		[Cpp2IlInjected.Address(RVA = "0x142AA50", Offset = "0x1429450", VA = "0x18142AA50")]
		public void OnNextPage()
		{
			//Discarded unreachable code: IL_0167, IL_016d, IL_0173, IL_0179, IL_017f, IL_0185, IL_018b, IL_0197, IL_01a3, IL_01a9, IL_01af, IL_01bb
			//IL_00fe: Expected I4, but got I8
			//IL_012e: Expected O, but got I4
			//IL_012e: Expected O, but got I4
			//IL_013c: Expected O, but got I4
			//IL_013c: Expected O, but got I4
			uint num2 = default(uint);
			SpriteAtlasImage component = default(SpriteAtlasImage);
			GameObject gameObject = default(GameObject);
			Transform transform = default(Transform);
			uint num6 = default(uint);
			uint num7 = default(uint);
			GameObject gameObject2 = default(GameObject);
			ulong num9 = default(ulong);
			GameObject gameObject3 = default(GameObject);
			FocusNavigationElement focusNavigationElement = default(FocusNavigationElement);
			while (true)
			{
				int num = 0;
				_currentIndex++;
				List<ShopProductModel> products = _products;
				_currentIndex = num;
				IEnumerator enumerator = McNavi.transform.GetEnumerator();
				if (enumerator != null)
				{
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
					if (enumerator == null)
					{
					}
					int num3 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					if (num == _currentIndex)
					{
						component = gameObject.GetComponent<SpriteAtlasImage>();
						component.ImageAddress = "common_page_indicator_on";
						num++;
					}
					component.gameObject.GetComponent<SpriteAtlasImage>().ImageAddress = "common_page_indicator_off";
					num++;
				}
				int num4 = 0;
				if (num != 0)
				{
					int num5 = 0;
				}
				if (num == 0)
				{
					IEnumerator enumerator2 = transform.GetEnumerator();
					if (num4 < (int)num6)
					{
						num4 += num4;
						num4++;
					}
					if (enumerator2 != null)
					{
						if (num4 < (int)num7)
						{
							num4 += num4;
							num4++;
						}
						if (num4 == 0)
						{
							num4 += 312;
							num4 += 328;
						}
						int num8 = 0;
						if (num4 == 0)
						{
							break;
						}
						gameObject2.SetActive((byte)num9 != 0);
						num4++;
						int active = 0;
						gameObject3.SetActive((byte)active != 0);
						num4++;
					}
					if ((object)gameObject3 != null)
					{
					}
					if (num != 0)
					{
						continue;
					}
					int num10 = 0;
					if (!((UnityEngine.Object)num4 != (UnityEngine.Object)num10))
					{
						return;
					}
					int num11 = 0;
					if ((UnityEngine.Object)num != (UnityEngine.Object)num11)
					{
						int num12 = 0;
						UiRoot instance = UiRoot.Instance;
						int useKeyboardAsController = 0;
						if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && (IntPtr)num == (IntPtr)focusNavigationElement)
						{
							List<FocusDirection> useAnchorWithDirection = focusNavigationElement.UseAnchorWithDirection;
						}
					}
					return;
				}
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C04")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ShopProductGroupBundlePaging()
		{
		}
	}
}
