using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Motion;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001DC")]
	public class ProgressBar : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		[SerializeField]
		private Image mc_background;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		[SerializeField]
		private Image mc_progression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000807")]
		private float _fillAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000808")]
		private Tween<float> _fill;

		[Cpp2IlInjected.Token(Token = "0x17000260")]
		public Image Background
		{
			[Cpp2IlInjected.Token(Token = "0x6000C30")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return mc_background;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000261")]
		internal float FillAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6000C31")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF60", Offset = "0xA7C960", VA = "0x180A7DF60")]
			get
			{
				return _fillAmount;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C32")]
			[Cpp2IlInjected.Address(RVA = "0xE1E9B0", Offset = "0xE1D3B0", VA = "0x180E1E9B0")]
			set
			{
				//Discarded unreachable code: IL_0030
				//IL_0017: Expected O, but got I4
				Image image = mc_progression;
				_fillAmount = value;
				int num = 0;
				if (image != (UnityEngine.Object)num)
				{
					Image image2 = mc_progression;
					float num2 = (image2.fillAmount = _fillAmount);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C33")]
		[Cpp2IlInjected.Address(RVA = "0xE1E8F0", Offset = "0xE1D2F0", VA = "0x180E1E8F0")]
		[IteratorStateMachine(typeof(_003CFill_003Ed__9))]
		public IEnumerator Fill(float from, float to, float duration, EasingType easing)
		{
			int _003C_003E1__state = default(int);
			_003CFill_003Ed__9 _003CFill_003Ed__ = new _003CFill_003Ed__9(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CFill_003Ed__._003C_003E4__this = this;
			_003CFill_003Ed__.easing = EasingType.Linear;
			_003CFill_003Ed__.from = from;
			_003CFill_003Ed__.to = to;
			_003CFill_003Ed__.duration = duration;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C34")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ProgressBar()
		{
		}
	}
}
