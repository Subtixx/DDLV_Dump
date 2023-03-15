using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000766")]
	[RequiredAllNotNull]
	public class SelectGenderPanel : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002B3A")]
		public Action OnChangeGender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002B3B")]
		[SerializeField]
		private Toggle _toggleMale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002B3C")]
		[SerializeField]
		private Toggle _toggleFemale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002B3F")]
		private bool _constructed;

		[Cpp2IlInjected.Token(Token = "0x170006BF")]
		public AvatarCustomization AvatarCustomization
		{
			[Cpp2IlInjected.Token(Token = "0x6002F66")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CAvatarCustomization_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F67")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CAvatarCustomization_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C0")]
		public AvatarAppearance Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x6002F68")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CAvatar_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F69")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CAvatar_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F6A")]
		[Cpp2IlInjected.Address(RVA = "0x125B720", Offset = "0x125A120", VA = "0x18125B720")]
		public void Show()
		{
			//Discarded unreachable code: IL_00f3
			if (!_constructed)
			{
				Toggle toggleMale = _toggleMale;
				_constructed = true;
				Toggle.ToggleEvent onValueChanged = toggleMale.onValueChanged;
				UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnValueChangedHandler);
				((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
			}
			base.gameObject.SetActive(value: true);
			if (base.gameObject.activeInHierarchy)
			{
				BaseWardrobeItem component = _toggleMale.GetComponent<BaseWardrobeItem>();
				bool flag = (component.IsSelected = Avatar.IsMale);
				BaseWardrobeItem component2 = _toggleFemale.GetComponent<BaseWardrobeItem>();
				bool flag3 = (component2.IsSelected = !Avatar.IsMale);
				AvatarAppearance avatarAppearance = Avatar;
				Toggle toggleMale2 = _toggleMale;
				bool _003CIsMale_003Ek__BackingField2 = avatarAppearance.IsMale;
				toggleMale2.SetIsOnWithoutNotify(_003CIsMale_003Ek__BackingField2);
				AvatarAppearance avatarAppearance2 = Avatar;
				Toggle toggleFemale = _toggleFemale;
				bool isOnWithoutNotify = !avatarAppearance2.IsMale;
				toggleFemale.SetIsOnWithoutNotify(isOnWithoutNotify);
			}
			bool _003CIsMale_003Ek__BackingField3 = Avatar.IsMale;
			SetGender(_003CIsMale_003Ek__BackingField3);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F6B")]
		[Cpp2IlInjected.Address(RVA = "0x125B400", Offset = "0x1259E00", VA = "0x18125B400")]
		public void RefreshToggles()
		{
			//Discarded unreachable code: IL_009b
			if (base.gameObject.activeInHierarchy)
			{
				BaseWardrobeItem component = _toggleMale.GetComponent<BaseWardrobeItem>();
				bool flag = (component.IsSelected = Avatar.IsMale);
				BaseWardrobeItem component2 = _toggleFemale.GetComponent<BaseWardrobeItem>();
				bool flag3 = (component2.IsSelected = !Avatar.IsMale);
				AvatarAppearance avatarAppearance = Avatar;
				Toggle toggleMale = _toggleMale;
				bool _003CIsMale_003Ek__BackingField2 = avatarAppearance.IsMale;
				toggleMale.SetIsOnWithoutNotify(_003CIsMale_003Ek__BackingField2);
				AvatarAppearance avatarAppearance2 = Avatar;
				Toggle toggleFemale = _toggleFemale;
				bool isOnWithoutNotify = !avatarAppearance2.IsMale;
				toggleFemale.SetIsOnWithoutNotify(isOnWithoutNotify);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F6C")]
		[Cpp2IlInjected.Address(RVA = "0x125B040", Offset = "0x1259A40", VA = "0x18125B040")]
		private void Construct()
		{
			//Discarded unreachable code: IL_002a
			Toggle toggleMale = _toggleMale;
			_constructed = true;
			Toggle.ToggleEvent onValueChanged = toggleMale.onValueChanged;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F6D")]
		[Cpp2IlInjected.Address(RVA = "0x125B240", Offset = "0x1259C40", VA = "0x18125B240")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0021
			Toggle.ToggleEvent onValueChanged = _toggleMale.onValueChanged;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F6E")]
		[Cpp2IlInjected.Address(RVA = "0x125B100", Offset = "0x1259B00", VA = "0x18125B100")]
		public List<List<FocusNavigationElement>> GetNavGrid()
		{
			//Discarded unreachable code: IL_003b
			List<List<FocusNavigationElement>> list = (List<List<FocusNavigationElement>>)(object)new List<T>();
			List<FocusNavigationElement> list2 = (List<FocusNavigationElement>)(object)new List<T>();
			FocusNavigationElement component = _toggleFemale.GetComponent<FocusNavigationElement>();
			((List<T>)(object)list2).Add((T)component);
			FocusNavigationElement component2 = _toggleMale.GetComponent<FocusNavigationElement>();
			((List<T>)(object)list2).Add((T)component2);
			((List<T>)(object)list).Add((T)list2);
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F6F")]
		[Cpp2IlInjected.Address(RVA = "0x125B300", Offset = "0x1259D00", VA = "0x18125B300")]
		private void OnValueChangedHandler(bool isMale)
		{
			//Discarded unreachable code: IL_0054
			AvatarAppearance avatarAppearance = Avatar;
			if (isMale != avatarAppearance.IsMale)
			{
				if (!isMale)
				{
				}
				_toggleMale.GetComponent<BaseButton>()?.PostWwiseEvent();
			}
			_toggleMale.GetComponent<BaseWardrobeItem>().IsSelected = isMale;
			_toggleFemale.GetComponent<BaseWardrobeItem>().IsSelected = isMale;
			SetGender(isMale);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F70")]
		[Cpp2IlInjected.Address(RVA = "0x9BB7F0", Offset = "0x9BA1F0", VA = "0x1809BB7F0")]
		public void Hide()
		{
			//Discarded unreachable code: IL_0011
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F71")]
		[Cpp2IlInjected.Address(RVA = "0x125B520", Offset = "0x1259F20", VA = "0x18125B520")]
		public void SetGender(bool isMale)
		{
			//Discarded unreachable code: IL_0049
			//IL_0010: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			AvatarAppearance avatarAppearance = Avatar;
			int num = 0;
			if (avatarAppearance == (UnityEngine.Object)num)
			{
				return;
			}
			AvatarCustomization avatarCustomization = AvatarCustomization;
			int num2 = 0;
			if (!(avatarCustomization == (UnityEngine.Object)num2))
			{
				AvatarAppearance avatarAppearance2 = Avatar;
				if (isMale != avatarAppearance2.IsMale)
				{
					int num3 = 0;
					int num4 = 0;
					int num5 = 0;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F72")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SelectGenderPanel()
		{
		}
	}
}
