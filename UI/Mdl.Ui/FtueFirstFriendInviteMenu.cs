using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004BA")]
	public class FtueFirstFriendInviteMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40018E1")]
		[SerializeField]
		private RectTransform content;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40018E2")]
		[SerializeField]
		private RectTransform backgroundMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40018E3")]
		[SerializeField]
		private RectTransform background;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40018E4")]
		[SerializeField]
		private Toggle anaToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40018E5")]
		[SerializeField]
		private Toggle woodyToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40018E6")]
		[SerializeField]
		private Toggle nalaToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40018E7")]
		[SerializeField]
		private ButtonTmProIcon _btnConfirm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40018E8")]
		[SerializeField]
		private GameObject sparkles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40018E9")]
		private ParticleSystem[] _sparkles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40018EA")]
		private Toggle _selectedToggle;

		[Cpp2IlInjected.Token(Token = "0x6001ED9")]
		[Cpp2IlInjected.Address(RVA = "0x166E520", Offset = "0x166CF20", VA = "0x18166E520")]
		private void Awake()
		{
			ParticleSystem[] array = (_sparkles = sparkles.GetComponentsInChildren<ParticleSystem>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EDA")]
		[Cpp2IlInjected.Address(RVA = "0x166E620", Offset = "0x166D020", VA = "0x18166E620", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_00d6
			//IL_00cb: Expected O, but got I4
			base.OnFocusIn();
			Transform transform = base.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			RectTransform rectTransform = background;
			Transform transform2 = base.transform;
			Vector2 sizeDelta = background.sizeDelta;
			RectTransform rectTransform2 = content;
			float z = Vector3.zero.z;
			RectTransform rectTransform3 = content;
			float z2 = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.OutBack).SetDelay(0.3f);
			Toggle toggle = (_selectedToggle = woodyToggle);
			ParticleSystem[] array = _sparkles;
			int num2 = 0;
			int num3 = 0;
			int length = array.Length;
			if (num2 < length)
			{
				ParticleSystemManager.Play(array[num3]);
				num3++;
			}
			RectTransform rectTransform4 = backgroundMask;
			int num4 = 0;
			int num5 = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = ((TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOSizeDelta(rectTransform4, (Vector2)num4, 0.35f, (byte)num5 != 0)).SetEase(Ease.InOutExpo);
		}

		[Cpp2IlInjected.Token(Token = "0x6001EDB")]
		[Cpp2IlInjected.Address(RVA = "0x166EA10", Offset = "0x166D410", VA = "0x18166EA10", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__12))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__12 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__12(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EDC")]
		[Cpp2IlInjected.Address(RVA = "0x166E900", Offset = "0x166D300", VA = "0x18166E900")]
		public void OnSelectClickHandler()
		{
			//Discarded unreachable code: IL_0039
			//IL_0030: Expected O, but got I4
			bool isOn = anaToggle.m_IsOn;
			Toggle toggle = nalaToggle;
			((Action<T>)(object)_menuParam?.AnswerAction)?.Invoke((T)2);
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EDD")]
		[Cpp2IlInjected.Address(RVA = "0x166E9A0", Offset = "0x166D3A0", VA = "0x18166E9A0")]
		private void PlaySparkles()
		{
			//Discarded unreachable code: IL_0025
			ParticleSystem[] array = _sparkles;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				ParticleSystemManager.Play(array[num]);
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EDE")]
		[Cpp2IlInjected.Address(RVA = "0x166EA90", Offset = "0x166D490", VA = "0x18166EA90")]
		private void StopSparkles()
		{
			//Discarded unreachable code: IL_0025
			ParticleSystem[] array = _sparkles;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				array[num].Stop();
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EDF")]
		[Cpp2IlInjected.Address(RVA = "0x166E580", Offset = "0x166CF80", VA = "0x18166E580", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0051
			if (redirectionType == RedirectionType.GamePromptGoForward)
			{
				ButtonTmProIcon btnConfirm = _btnConfirm;
				if (anaToggle.m_IsOn || nalaToggle.m_IsOn || woodyToggle.m_IsOn)
				{
					btnConfirm.ButtonComponent.m_OnClick?.Invoke();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EE0")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public FtueFirstFriendInviteMenu()
		{
		}
	}
}
