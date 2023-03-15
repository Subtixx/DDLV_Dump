using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006F6")]
	public abstract class ShopProductItemDefault : FocusNavigationElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400277D")]
		[SerializeField]
		private List<BaseButton> _actionButtons = (List<BaseButton>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x17000671")]
		public ShopProductModel Model
		{
			[Cpp2IlInjected.Token(Token = "0x6002C6A")]
			[Cpp2IlInjected.Address(RVA = "0x738E80", Offset = "0x737880", VA = "0x180738E80")]
			[CompilerGenerated]
			get
			{
				return _003CModel_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C6B")]
			[Cpp2IlInjected.Address(RVA = "0x739E90", Offset = "0x738890", VA = "0x180739E90")]
			[CompilerGenerated]
			set
			{
				_003CModel_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C6C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		public abstract void RefreshData(ShopProductModel model);

		[Cpp2IlInjected.Token(Token = "0x6002C6D")]
		[Cpp2IlInjected.Address(Slot = "26")]
		public abstract void RefreshDisplay();

		[Cpp2IlInjected.Token(Token = "0x6002C6E")]
		[Cpp2IlInjected.Address(RVA = "0x14339E0", Offset = "0x14323E0", VA = "0x1814339E0")]
		private new void Start()
		{
			ScrollRect scrollRect = (ScrollRect = GetComponentInParent<ScrollRect>());
			Transform transform = (FreeContainer = ScrollRect.GetComponentInChildren<LayoutGroup>().transform);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C6F")]
		[Cpp2IlInjected.Address(RVA = "0x1433790", Offset = "0x1432190", VA = "0x181433790")]
		public void OnInfoClicked()
		{
			ShopProductModel model = Model;
			ShowProductInfo(model);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C70")]
		[Cpp2IlInjected.Address(RVA = "0x14337A0", Offset = "0x14321A0", VA = "0x1814337A0")]
		public void ShowProductInfo(ShopProductModel model)
		{
			//Discarded unreachable code: IL_007f
			//IL_0020: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			string _003CTitleStrID_003Ek__BackingField = default(string);
			int num3 = default(int);
			int isDefaultGamepadFocus = default(int);
			while (model != null)
			{
				int num = 0;
				if (model != null)
				{
					PopUpArgs popUpArgs = new PopUpArgs();
					int num2 = 0;
					if (num2 == 0)
					{
					}
					popUpArgs.MessageStrID = (string)num2;
					popUpArgs.TitleStrID = _003CTitleStrID_003Ek__BackingField;
					popUpArgs.ShowCloseButton = false;
					popUpArgs.BlurBackground = false;
					AlertButton[] array = new AlertButton[1];
					AlertButton alertButton = new AlertButton(AlertButtonStyle.Confirm, (string)num3, (byte)isDefaultGamepadFocus != 0);
					isDefaultGamepadFocus = 0;
					num3 = 0;
					if (alertButton == null || alertButton != null)
					{
						array[0] = alertButton;
						popUpArgs.ButtonsList = array;
						int num4 = 0;
						UiRoot.Instance._genericAlert.Alert(popUpArgs);
						break;
					}
					continue;
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C71")]
		[Cpp2IlInjected.Address(RVA = "0x1433370", Offset = "0x1431D70", VA = "0x181433370", Slot = "16")]
		public override ISupportsFocusNavigation FindNext(FocusDirection direction, int input)
		{
			//IL_0014: Expected O, but got I4
			//IL_009a: Expected O, but got I4
			//IL_00a6: Invalid comparison between I4 and F4
			int num = 0;
			Transform freeContainer = FreeContainer;
			int num2 = 0;
			if (freeContainer != (UnityEngine.Object)num2)
			{
				int num3 = 0;
				if (direction != 0 && direction != 0)
				{
					switch (direction)
					{
					}
				}
				ShopProductItemDefault[] componentsInChildren = FreeContainer.GetComponentsInChildren<ShopProductItemDefault>();
				Transform transform = base.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				int num4 = 0;
				int length = componentsInChildren.Length;
				if (num < length)
				{
					ShopProductItemDefault shopProductItemDefault = componentsInChildren[num];
					if (!(shopProductItemDefault == this) && shopProductItemDefault.gameObject.activeSelf)
					{
						Transform transform2 = shopProductItemDefault.transform;
						Vector3 vector2 = default(Vector3);
						float z2 = vector2.z;
						Vector2 b = default(Vector2);
						float num5 = Vector2.Distance((Vector2)0, b) * 57.29578f;
						if ((float)num3 <= num5)
						{
						}
					}
					num++;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C72")]
		[Cpp2IlInjected.Address(RVA = "0x1433360", Offset = "0x1431D60", VA = "0x181433360", Slot = "21")]
		public override void Click(ShortcutDefinition shortcut)
		{
			base.Click(shortcut);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C73")]
		[Cpp2IlInjected.Address(RVA = "0x1433A80", Offset = "0x1432480", VA = "0x181433A80")]
		protected ShopProductItemDefault()
		{
		}
	}
}
