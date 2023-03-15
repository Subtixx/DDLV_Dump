using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003F6")]
	[RequiredAllNotNull]
	public class DecalBaseItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400136C")]
		[SerializeField]
		protected AsyncAtlassedIcon _decal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400136D")]
		[SerializeField]
		private GameObject _selectedHighlightBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400136E")]
		[SerializeField]
		private GameObject _selectedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400136F")]
		[SerializeField]
		private GameObject _highlightBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001370")]
		[SerializeField]
		private GameObject _normalBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001371")]
		[SerializeField]
		private GameObject _deco;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001372")]
		[SerializeField]
		private RectTransform _animatedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001373")]
		[SerializeField]
		private bool _animateHorizontally;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4001377")]
		private float _oX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001378")]
		private float _oY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4001379")]
		private bool _initialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7D")]
		[Cpp2IlInjected.Token(Token = "0x400137A")]
		private bool _isHighlighted;

		[Cpp2IlInjected.Token(Token = "0x17000429")]
		public DecalItemData DecalData
		{
			[Cpp2IlInjected.Token(Token = "0x6001924")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003CDecalData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001925")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			private set
			{
				_003CDecalData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042A")]
		public RectTransform AnimatedContent
		{
			[Cpp2IlInjected.Token(Token = "0x6001926")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return _animatedContent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042B")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6001927")]
			[Cpp2IlInjected.Address(RVA = "0xCC66A0", Offset = "0xCC50A0", VA = "0x180CC66A0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6001928")]
			[Cpp2IlInjected.Address(RVA = "0x15579D0", Offset = "0x15563D0", VA = "0x1815579D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x70"), Cpp2IlInjected.Token(Token = "0x4001376")]
		public int Layer
		{
			[Cpp2IlInjected.Token(Token = "0x6001929")]
			[Cpp2IlInjected.Address(RVA = "0xDD7050", Offset = "0xDD5A50", VA = "0x180DD7050")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600192A")]
			[Cpp2IlInjected.Address(RVA = "0xDD7110", Offset = "0xDD5B10", VA = "0x180DD7110")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700042D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x7E"), Cpp2IlInjected.Token(Token = "0x400137B")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x600192B")]
			[Cpp2IlInjected.Address(RVA = "0x15579C0", Offset = "0x15563C0", VA = "0x1815579C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600192C")]
			[Cpp2IlInjected.Address(RVA = "0x15579E0", Offset = "0x15563E0", VA = "0x1815579E0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x600192D")]
		[Cpp2IlInjected.Address(RVA = "0x1557590", Offset = "0x1555F90", VA = "0x181557590")]
		public void OnEnable()
		{
			//Discarded unreachable code: IL_0044
			//IL_0019: Expected O, but got I4
			if (!_initialized)
			{
				RectTransform animatedContent = _animatedContent;
				int num = 0;
				if (animatedContent != (Object)num)
				{
					RectTransform animatedContent2 = _animatedContent;
					RectTransform animatedContent3 = _animatedContent;
					Vector3 vector = default(Vector3);
					float num2 = (_oY = vector.y);
					_initialized = true;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600192E")]
		[Cpp2IlInjected.Address(RVA = "0x15573D0", Offset = "0x1555DD0", VA = "0x1815573D0")]
		public void ForceRefreshYPos(float y = -128f)
		{
			_oY = y;
		}

		[Cpp2IlInjected.Token(Token = "0x600192F")]
		[Cpp2IlInjected.Address(RVA = "0x15573E0", Offset = "0x1555DE0", VA = "0x1815573E0", Slot = "4")]
		public virtual void Init(DecalItemData decalData, Color color, int layer)
		{
			//Discarded unreachable code: IL_009d
			DecalData = decalData;
			AsyncAtlassedIcon decal = _decal;
			Layer = layer;
			AsyncAtlassedIcon.ImageLoaded value = UpdateColor;
			decal.OnImageLoaded += value;
			DecalItemData decalItemData = DecalData;
			if (decalItemData != null)
			{
				AsyncAtlassedIcon decal2 = _decal;
				string iconAddress_ = decalItemData.iconAddress_;
				if (decal2.SetIcon(iconAddress_))
				{
					AsyncAtlassedIcon decal3 = _decal;
					AsyncAtlassedIcon decal4 = _decal;
					AsyncAtlassedIcon.ImageLoaded value2 = UpdateColor;
					decal4.OnImageLoaded -= value2;
					RawImage rawImage = decal3.RawImage;
					Color color3 = (rawImage.color = Color);
				}
			}
			IsSelected = false;
			RefreshBackground();
		}

		[Cpp2IlInjected.Token(Token = "0x6001930")]
		[Cpp2IlInjected.Address(RVA = "0x15578C0", Offset = "0x15562C0", VA = "0x1815578C0")]
		private void UpdateColor(AsyncAtlassedIcon icon)
		{
			//Discarded unreachable code: IL_0031
			AsyncAtlassedIcon decal = _decal;
			AsyncAtlassedIcon.ImageLoaded value = UpdateColor;
			decal.OnImageLoaded -= value;
			RawImage rawImage = icon.RawImage;
			Color color2 = (rawImage.color = Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6001931")]
		[Cpp2IlInjected.Address(RVA = "0x1557850", Offset = "0x1556250", VA = "0x181557850")]
		internal void SetColor(Color color)
		{
			//Discarded unreachable code: IL_000d
			RawImage rawImage = _decal.RawImage;
		}

		[Cpp2IlInjected.Token(Token = "0x6001932")]
		[Cpp2IlInjected.Address(RVA = "0x15578B0", Offset = "0x15562B0", VA = "0x1815578B0")]
		internal void SetSelected(bool selected)
		{
			IsSelected = selected;
			RefreshBackground();
		}

		[Cpp2IlInjected.Token(Token = "0x6001933")]
		[Cpp2IlInjected.Address(RVA = "0x1557140", Offset = "0x1555B40", VA = "0x181557140", Slot = "5")]
		public virtual void AddHighlight()
		{
			//IL_0017: Expected O, but got I4
			RectTransform animatedContent = _animatedContent;
			_isHighlighted = true;
			int num = 0;
			if (animatedContent != (Object)num)
			{
				RectTransform animatedContent2 = _animatedContent;
				int complete = 0;
				int num2 = DOTween.Kill(animatedContent2, (byte)complete != 0);
				RectTransform animatedContent3 = _animatedContent;
				int num3 = 0;
				if ((_animateHorizontally ? 1 : 0) == num3)
				{
					float oY = _oY;
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = (TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)animatedContent3, oY, 0.2f, (byte)num3 != 0);
				}
				float oX = _oX;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX((Transform)animatedContent3, oX, 0.2f, (byte)num3 != 0)).Play();
			}
			_deco?.SetActive(value: true);
			RefreshBackground();
		}

		[Cpp2IlInjected.Token(Token = "0x6001934")]
		[Cpp2IlInjected.Address(RVA = "0x1557720", Offset = "0x1556120", VA = "0x181557720", Slot = "6")]
		public virtual void RemoveHighlight()
		{
			//Discarded unreachable code: IL_00a0
			//IL_0017: Expected O, but got I4
			//IL_0059: Expected F4, but got I4
			//IL_0070: Expected F4, but got I4
			RectTransform animatedContent = _animatedContent;
			_isHighlighted = false;
			int num = 0;
			if (animatedContent != (Object)num)
			{
				RectTransform animatedContent2 = _animatedContent;
				int complete = 0;
				int num2 = DOTween.Kill(animatedContent2, (byte)complete != 0);
				RectTransform animatedContent3 = _animatedContent;
				int num3 = 0;
				int num4 = 0;
				if ((_animateHorizontally ? 1 : 0) == num3)
				{
					float oY = _oY;
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = (TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)animatedContent3, oY, (float)num4, (byte)num3 != 0);
				}
				float oX = _oX;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX((Transform)animatedContent3, oX, (float)num4, (byte)num3 != 0)).Play();
			}
			GameObject deco = _deco;
			if ((object)deco != null)
			{
				GameObject gameObject = deco.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			RefreshBackground();
		}

		[Cpp2IlInjected.Token(Token = "0x6001935")]
		[Cpp2IlInjected.Address(RVA = "0x1557650", Offset = "0x1556050", VA = "0x181557650")]
		private void RefreshBackground()
		{
			//Discarded unreachable code: IL_00ac
			int num;
			bool active2 = default(bool);
			while (true)
			{
				num = 0;
				GameObject selectedHighlightBg = _selectedHighlightBg;
				if ((object)selectedHighlightBg != null)
				{
					GameObject gameObject = selectedHighlightBg.gameObject;
					if ((IsSelected ? 1 : 0) != num)
					{
					}
					bool active = num != 0;
					gameObject.SetActive(active);
				}
				GameObject highlightBg = _highlightBg;
				if ((object)highlightBg == null)
				{
					break;
				}
				GameObject gameObject2 = highlightBg.gameObject;
				if ((IsSelected ? 1 : 0) == num)
				{
					active2 = _isHighlighted;
					gameObject2.SetActive(active2);
					break;
				}
			}
			GameObject selectedBg = _selectedBg;
			if ((object)selectedBg != null)
			{
				if ((IsSelected ? 1 : 0) == num)
				{
				}
				active2 = (_isHighlighted ? 1 : 0) == num;
				selectedBg.SetActive(active2);
			}
			GameObject normalBg = _normalBg;
			if ((object)normalBg != null)
			{
				if ((IsSelected ? 1 : 0) == num)
				{
				}
				normalBg.SetActive(active2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001936")]
		[Cpp2IlInjected.Address(RVA = "0x1557270", Offset = "0x1555C70", VA = "0x181557270")]
		public void DisableSelection()
		{
			//Discarded unreachable code: IL_005c
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_004c: Expected O, but got I4
			FocusNavigationElement component = GetComponent<FocusNavigationElement>();
			int num = 0;
			if (component != (Object)num)
			{
				component.IgnoreThis = true;
			}
			BaseButton component2 = GetComponent<BaseButton>();
			int num2 = 0;
			if (component2 != (Object)num2)
			{
				int num3 = ((component2.enabled = false) ? 1 : 0);
			}
			ButtonWithHold component3 = GetComponent<ButtonWithHold>();
			int num4 = 0;
			if (component3 != (Object)num4)
			{
				int num5 = ((component3.interactable = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001937")]
		[Cpp2IlInjected.Address(RVA = "0x1557990", Offset = "0x1556390", VA = "0x181557990")]
		public DecalBaseItem()
		{
			Color white = Color.white;
			base._002Ector();
		}
	}
}
