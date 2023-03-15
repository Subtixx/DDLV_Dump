using System;
using System.Collections.Generic;
using System.Linq;
using AK.Wwise;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl.Avatar;
using Meta.Customization;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004AA")]
	public class AvatarPresetPanel : MonoBehaviour, IStartFTUEPanel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001876")]
		[SerializeField]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001877")]
		[SerializeField]
		private AK.Wwise.Event _selectPresetSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001878")]
		public List<AvatarPresetItem> _avatarPresetItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001879")]
		private bool _isInit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400187A")]
		public RectTransform AnimatedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400187B")]
		public BaseButton NextButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400187C")]
		public BaseButton ImportAvatarButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400187D")]
		public AvatarCustomization AvatarCustomization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400187E")]
		private List<AvatarBodyPreset> _dataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4001880")]
		public int CurrentPreset;

		[Cpp2IlInjected.Token(Token = "0x170004EE")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x60"), Cpp2IlInjected.Token(Token = "0x400187F")]
		public bool IsInAnimation
		{
			[Cpp2IlInjected.Token(Token = "0x6001E57")]
			[Cpp2IlInjected.Address(RVA = "0x63F8A0", Offset = "0x63E2A0", VA = "0x18063F8A0", Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001E58")]
			[Cpp2IlInjected.Address(RVA = "0x63FD00", Offset = "0x63E700", VA = "0x18063FD00", Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E59")]
		[Cpp2IlInjected.Address(RVA = "0x88D740", Offset = "0x88C140", VA = "0x18088D740", Slot = "10")]
		public void Show()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001E5A")]
		[Cpp2IlInjected.Address(RVA = "0x88D650", Offset = "0x88C050", VA = "0x18088D650")]
		private void SetupAnim()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001E5B")]
		[Cpp2IlInjected.Address(RVA = "0x88CCB0", Offset = "0x88B6B0", VA = "0x18088CCB0")]
		public void AnimateIn()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001E5C")]
		[Cpp2IlInjected.Address(RVA = "0x88CE50", Offset = "0x88B850", VA = "0x18088CE50", Slot = "11")]
		public void Hide()
		{
			RectTransform animatedContent = AnimatedContent;
			float z = UnityEngine.Vector3.zero.z;
			TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions> t = default(TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions>);
			TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.InExpo);
			TweenCallback tweenCallback = delegate
			{
				//Discarded unreachable code: IL_001d
				GameObject gameObject = AnimatedContent.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				IsInAnimation = false;
			};
			Delegate @delegate = Delegate.Combine(tweenCallback, tweenCallback);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E5D")]
		[Cpp2IlInjected.Address(RVA = "0x88CF80", Offset = "0x88B980", VA = "0x18088CF80")]
		public void Init()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001E5E")]
		[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "6")]
		public Transform GetContent()
		{
			RectTransform animatedContent = AnimatedContent;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E5F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public BaseButton GetBackButton()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E60")]
		[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "8")]
		public BaseButton GetNextButton()
		{
			return NextButton;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E61")]
		[Cpp2IlInjected.Address(RVA = "0x88D2D0", Offset = "0x88BCD0", VA = "0x18088D2D0")]
		public void OnClickPreset(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001E62")]
		[Cpp2IlInjected.Address(RVA = "0x88D490", Offset = "0x88BE90", VA = "0x18088D490", Slot = "9")]
		public void SetFocus(FocusNavigation focusNavigation)
		{
			//Discarded unreachable code: IL_0062
			while (true)
			{
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					break;
				}
				List<AvatarPresetItem> avatarPresetItemList = _avatarPresetItemList;
				Func<AvatarPresetItem, bool> _003C_003E9__23_ = _003C_003Ec._003C_003E9__23_0;
				if (_003C_003E9__23_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((AvatarPresetItem x) => ((BaseWardrobeItem)x)._isSelected);
				}
				if ((object)Enumerable.FirstOrDefault<AvatarPresetItem>((IEnumerable<>)avatarPresetItemList, (Func<, >)(object)_003C_003E9__23_) == null)
				{
					FocusNavigationElement component = Enumerable.First<AvatarPresetItem>((IEnumerable<>)_avatarPresetItemList).GetComponent<FocusNavigationElement>();
					focusNavigation.SetFocus(component);
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E63")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public AvatarPresetPanel()
		{
		}
	}
}
