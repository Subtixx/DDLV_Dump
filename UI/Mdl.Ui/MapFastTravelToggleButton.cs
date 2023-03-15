using System;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl.Navigation;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200062C")]
	[RequiredAllNotNull]
	public class MapFastTravelToggleButton : MapFilterToggleButton
	{
		[Cpp2IlInjected.Token(Token = "0x200062D")]
		public enum DestinationType
		{
			[Cpp2IlInjected.Token(Token = "0x4002263")]
			Beach,
			[Cpp2IlInjected.Token(Token = "0x4002264")]
			Cliffs,
			[Cpp2IlInjected.Token(Token = "0x4002265")]
			DarkMountain,
			[Cpp2IlInjected.Token(Token = "0x4002266")]
			Forest,
			[Cpp2IlInjected.Token(Token = "0x4002267")]
			Meadow,
			[Cpp2IlInjected.Token(Token = "0x4002268")]
			Savana,
			[Cpp2IlInjected.Token(Token = "0x4002269")]
			Wetlands,
			[Cpp2IlInjected.Token(Token = "0x400226A")]
			Plaza,
			[Cpp2IlInjected.Token(Token = "0x400226B")]
			Realms
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002255")]
		private FastTravelDestination _fastTravelPod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002256")]
		public Action OnButtonClicked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002257")]
		[SerializeField]
		public DestinationType Destination;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4002258")]
		public int ItemID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002259")]
		[SerializeField]
		private TextBase _itemName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400225A")]
		[SerializeField]
		private RectTransform _holder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400225B")]
		[SerializeField]
		private GameObject _regularBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400225C")]
		[SerializeField]
		private GameObject _selectedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400225D")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400225E")]
		[SerializeField]
		private GameObject _highlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400225F")]
		[SerializeField]
		private AK.Wwise.Event _destinationLockedSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002260")]
		[SerializeField]
		protected GameObject HighlightBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002261")]
		private bool _isLocked = true;

		[Cpp2IlInjected.Token(Token = "0x1700060B")]
		public bool IsLocked
		{
			[Cpp2IlInjected.Token(Token = "0x600283C")]
			[Cpp2IlInjected.Address(RVA = "0xBD6330", Offset = "0xBD4D30", VA = "0x180BD6330")]
			get
			{
				return _isLocked;
			}
			[Cpp2IlInjected.Token(Token = "0x600283D")]
			[Cpp2IlInjected.Address(RVA = "0x117CBB0", Offset = "0x117B5B0", VA = "0x18117CBB0")]
			set
			{
				//Discarded unreachable code: IL_001e
				_isLocked = value;
				CanvasGroup canvasGroup = _canvasGroup;
				if (value)
				{
				}
				canvasGroup.alpha = 1f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600283E")]
		[Cpp2IlInjected.Address(RVA = "0x117C5F0", Offset = "0x117AFF0", VA = "0x18117C5F0")]
		public void Activate(FastTravelDestination fastTravelPod, Action onButtonClicked, bool isLocked)
		{
			//Discarded unreachable code: IL_009a
			_fastTravelPod = fastTravelPod;
			Item item = fastTravelPod.Item;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			TextBase itemName = _itemName;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			UnityEvent onActivate = OnActivate;
			_isSelected = true;
			int num3 = default(int);
			if (onActivate != null)
			{
				num3 = 0;
				onActivate.Invoke();
			}
			CanvasGroup canvasGroup = _canvasGroup;
			_isLocked = isLocked;
			if (isLocked)
			{
				num3 += num3;
			}
			canvasGroup.alpha = 1f;
			FocusNavigationElement component = GetComponent<FocusNavigationElement>();
			bool flag = (component.IgnoreThis = _isLocked);
			if (!isLocked)
			{
				OnButtonClicked = onButtonClicked;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600283F")]
		[Cpp2IlInjected.Address(RVA = "0x117CA30", Offset = "0x117B430", VA = "0x18117CA30")]
		public void SetName(Item item)
		{
			//Discarded unreachable code: IL_001d
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			TextBase itemName = _itemName;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002840")]
		[Cpp2IlInjected.Address(RVA = "0x117C840", Offset = "0x117B240", VA = "0x18117C840")]
		public new void OnClicked()
		{
			//Discarded unreachable code: IL_0045
			//IL_0010: Expected O, but got I4
			FastTravelDestination fastTravelPod = _fastTravelPod;
			int num = 0;
			if (fastTravelPod != (UnityEngine.Object)num)
			{
				if (!_fastTravelPod.Unlocked)
				{
					return;
				}
				FastTravelDestination fastTravelPod2 = _fastTravelPod;
				PlayerNavigation playerNavigation = default(PlayerNavigation);
				playerNavigation.UseFastTravel(fastTravelPod2);
			}
			OnButtonClicked?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002841")]
		[Cpp2IlInjected.Address(RVA = "0x117C970", Offset = "0x117B370", VA = "0x18117C970")]
		public void OnHighlight(bool highlighted)
		{
			//Discarded unreachable code: IL_0050
			//IL_004d: Expected F4, but got I4
			if (!_isLocked)
			{
				SoundComponent component = GetComponent<SoundComponent>();
				if ((object)component != null)
				{
					int index = 0;
					component.PostSfx(index);
				}
				_highlight.SetActive(highlighted);
				HighlightBg.SetActive(highlighted);
				RectTransform holder = _holder;
				int num = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(holder, (float)(highlighted ? 1 : 0), 0.1f, (byte)num != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002842")]
		[Cpp2IlInjected.Address(RVA = "0x117CB90", Offset = "0x117B590", VA = "0x18117CB90")]
		public MapFastTravelToggleButton()
		{
			_isSelected = true;
			((MonoBehaviour)this)._002Ector();
		}
	}
}
