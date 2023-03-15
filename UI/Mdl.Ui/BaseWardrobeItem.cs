using System.Collections.Generic;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200074E")]
	public class BaseWardrobeItem : MonoBehaviour, IPoolObjectEventHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002A9D")]
		[SerializeField]
		private GameObject _vitiligoIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002A9E")]
		[SerializeField]
		internal Transform AnimatedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002A9F")]
		[SerializeField]
		protected GameObject Decoration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002AA0")]
		[SerializeField]
		protected GameObject SelectedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002AA1")]
		[SerializeField]
		protected GameObject HighlightBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002AA2")]
		[SerializeField]
		protected GameObject SelectedHighlightBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002AA3")]
		[SerializeField]
		protected AsyncAtlassedIcon _mcIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002AA4")]
		[SerializeField]
		protected GameObject FullBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002AA5")]
		protected bool _isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4002AA6")]
		protected float _oY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002AA7")]
		private bool _init;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4002AA8")]
		public bool ShowSelected = true;

		[Cpp2IlInjected.Token(Token = "0x170006AD")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6002EAA")]
			[Cpp2IlInjected.Address(RVA = "0xA5F820", Offset = "0xA5E220", VA = "0x180A5F820")]
			get
			{
				return _isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EAB")]
			[Cpp2IlInjected.Address(RVA = "0xA5F760", Offset = "0xA5E160", VA = "0x180A5F760")]
			set
			{
				_isSelected = value;
				IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EAC")]
		[Cpp2IlInjected.Address(RVA = "0xA5F760", Offset = "0xA5E160", VA = "0x180A5F760")]
		public void SetSelected(bool isSelected)
		{
			_isSelected = isSelected;
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EAD")]
		[Cpp2IlInjected.Address(RVA = "0xA5F1E0", Offset = "0xA5DBE0", VA = "0x180A5F1E0")]
		public void OnEnable()
		{
			//Discarded unreachable code: IL_003b
			//IL_0019: Expected O, but got I4
			if (!_init)
			{
				Transform animatedContent = AnimatedContent;
				int num = 0;
				if (animatedContent != (Object)num)
				{
					Transform animatedContent2 = AnimatedContent;
					_init = true;
					Vector3 vector = default(Vector3);
					float num2 = (_oY = vector.y);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EAE")]
		[Cpp2IlInjected.Address(RVA = "0xA5F1D0", Offset = "0xA5DBD0", VA = "0x180A5F1D0")]
		public void ForceRefreshYPos(float y = -128f)
		{
			_oY = y;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EAF")]
		[Cpp2IlInjected.Address(RVA = "0xA5F2C0", Offset = "0xA5DCC0", VA = "0x180A5F2C0", Slot = "5")]
		public virtual void RefreshSelected()
		{
			//Discarded unreachable code: IL_00e3
			//IL_0010: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			//IL_00ba: Expected O, but got I4
			int num2;
			while (true)
			{
				GameObject selectedBg = SelectedBg;
				int num = 0;
				bool flag = selectedBg != (Object)num;
				num2 = 0;
				if (flag)
				{
					GameObject selectedBg2 = SelectedBg;
					if ((_isSelected ? 1 : 0) != num2)
					{
					}
					bool active = num2 != 0;
					selectedBg2.SetActive(active);
				}
				GameObject selectedHighlightBg = SelectedHighlightBg;
				int num3 = 0;
				if (!(selectedHighlightBg != (Object)num3))
				{
					break;
				}
				GameObject decoration = Decoration;
				int num4 = 0;
				if (!(decoration != (Object)num4) || !Decoration.gameObject.activeInHierarchy)
				{
					break;
				}
				GameObject selectedHighlightBg2 = SelectedHighlightBg;
				if ((_isSelected ? 1 : 0) != num2)
				{
					bool active2 = ShowSelected;
					selectedHighlightBg2.SetActive(active2);
					break;
				}
			}
			GameObject fullBg = FullBg;
			int num5 = 0;
			if (fullBg != (Object)num5)
			{
				GameObject fullBg2 = FullBg;
				if ((ShowSelected ? 1 : 0) == num2)
				{
				}
				bool active3 = _isSelected;
				fullBg2.SetActive(active3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EB0")]
		[Cpp2IlInjected.Address(RVA = "0xA5EFF0", Offset = "0xA5D9F0", VA = "0x180A5EFF0", Slot = "6")]
		public virtual void AddHighlight()
		{
			//Discarded unreachable code: IL_00d9
			//IL_0010: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			//IL_00ae: Expected O, but got I4
			Transform animatedContent = AnimatedContent;
			int num = 0;
			if (animatedContent != (Object)num)
			{
				Transform animatedContent2 = AnimatedContent;
				int complete = 0;
				int num2 = DOTween.Kill(animatedContent2, (byte)complete != 0);
				float oY = _oY;
				int num3 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY(AnimatedContent, oY, 0.2f, (byte)num3 != 0)).Play();
			}
			GameObject highlightBg = HighlightBg;
			int num4 = 0;
			if (highlightBg != (Object)num4)
			{
				HighlightBg.SetActive(value: true);
			}
			GameObject decoration = Decoration;
			int num5 = 0;
			if (decoration != (Object)num5)
			{
				Decoration.SetActive(value: true);
			}
			if (_isSelected)
			{
				GameObject selectedHighlightBg = SelectedHighlightBg;
				int num6 = 0;
				if (selectedHighlightBg != (Object)num6 && !SelectedHighlightBg.activeInHierarchy)
				{
					GameObject selectedHighlightBg2 = SelectedHighlightBg;
					bool showSelected = ShowSelected;
					selectedHighlightBg2.SetActive(showSelected);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EB1")]
		[Cpp2IlInjected.Address(RVA = "0xA5F5A0", Offset = "0xA5DFA0", VA = "0x180A5F5A0", Slot = "7")]
		public virtual void RemoveHighlight()
		{
			//Discarded unreachable code: IL_00c9
			//IL_0040: Expected F4, but got I4
			//IL_005b: Expected O, but got I4
			//IL_0086: Expected O, but got I4
			//IL_00b1: Expected O, but got I4
			if ((bool)AnimatedContent)
			{
				Transform animatedContent = AnimatedContent;
				int complete = 0;
				int num = DOTween.Kill(animatedContent, (byte)complete != 0);
				float oY = _oY;
				int num2 = 0;
				Transform animatedContent2 = AnimatedContent;
				int num3 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY(animatedContent2, oY, (float)num3, (byte)num2 != 0)).Play();
			}
			GameObject highlightBg = HighlightBg;
			int num4 = 0;
			if (highlightBg != (Object)num4)
			{
				GameObject highlightBg2 = HighlightBg;
				int active = 0;
				highlightBg2.SetActive((byte)active != 0);
			}
			GameObject decoration = Decoration;
			int num5 = 0;
			if (decoration != (Object)num5)
			{
				GameObject decoration2 = Decoration;
				int active2 = 0;
				decoration2.SetActive((byte)active2 != 0);
			}
			GameObject selectedHighlightBg = SelectedHighlightBg;
			int num6 = 0;
			if (selectedHighlightBg != (Object)num6)
			{
				GameObject selectedHighlightBg2 = SelectedHighlightBg;
				int active3 = 0;
				selectedHighlightBg2.SetActive((byte)active3 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EB2")]
		[Cpp2IlInjected.Address(RVA = "0xA5F470", Offset = "0xA5DE70", VA = "0x180A5F470", Slot = "8")]
		public virtual void RemoveDecoration()
		{
			//Discarded unreachable code: IL_0073
			//IL_0040: Expected F4, but got I4
			//IL_005b: Expected O, but got I4
			if ((bool)AnimatedContent)
			{
				Transform animatedContent = AnimatedContent;
				int complete = 0;
				int num = DOTween.Kill(animatedContent, (byte)complete != 0);
				float oY = _oY;
				int num2 = 0;
				Transform animatedContent2 = AnimatedContent;
				int num3 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY(animatedContent2, oY, (float)num3, (byte)num2 != 0)).Play();
			}
			GameObject decoration = Decoration;
			int num4 = 0;
			if (decoration != (Object)num4)
			{
				GameObject decoration2 = Decoration;
				int active = 0;
				decoration2.SetActive((byte)active != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EB3")]
		[Cpp2IlInjected.Address(RVA = "0xA5F280", Offset = "0xA5DC80", VA = "0x180A5F280", Slot = "4")]
		public void OnObjectRecycled()
		{
			_mcIcon?.Release();
			_isSelected = false;
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EB4")]
		[Cpp2IlInjected.Address(RVA = "0xA5F780", Offset = "0xA5E180", VA = "0x180A5F780")]
		public void ShowVitiligo(bool value)
		{
			//Discarded unreachable code: IL_0020
			//IL_0010: Expected O, but got I4
			GameObject vitiligoIcon = _vitiligoIcon;
			int num = 0;
			if (vitiligoIcon != (Object)num)
			{
				_vitiligoIcon.SetActive(value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EB5")]
		[Cpp2IlInjected.Address(RVA = "0xA5F810", Offset = "0xA5E210", VA = "0x180A5F810")]
		public BaseWardrobeItem()
		{
		}
	}
}
