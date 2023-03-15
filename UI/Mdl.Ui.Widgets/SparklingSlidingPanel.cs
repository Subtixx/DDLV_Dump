using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009C6")]
	public class SparklingSlidingPanel : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003997")]
		public SlidingPanel slidingPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003998")]
		public GameObject sparkles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003999")]
		private ParticleSystem[] _sparkles;

		[Cpp2IlInjected.Token(Token = "0x6003D2A")]
		[Cpp2IlInjected.Address(RVA = "0x15FE720", Offset = "0x15FD120", VA = "0x1815FE720")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0081
			ParticleSystem[] array = (_sparkles = sparkles.GetComponentsInChildren<ParticleSystem>());
			SlidingPanel slidingPanel = this.slidingPanel;
			SlidingPanel.SlidingPanelEvent b = PlaySparkles;
			SlidingPanel.SlidingPanelEvent onOpen = slidingPanel.OnOpen;
			Delegate @delegate = Delegate.Combine(onOpen, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onOpen)
				{
				}
				SlidingPanel slidingPanel2 = this.slidingPanel;
				SlidingPanel.SlidingPanelEvent b2 = StopSparkles;
				SlidingPanel.SlidingPanelEvent onClose = slidingPanel2.OnClose;
				Delegate delegate2 = Delegate.Combine(onClose, b2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					while ((object)delegate2 != onClose)
					{
					}
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D2B")]
		[Cpp2IlInjected.Address(RVA = "0x15FE910", Offset = "0x15FD310", VA = "0x1815FE910")]
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

		[Cpp2IlInjected.Token(Token = "0x6003D2C")]
		[Cpp2IlInjected.Address(RVA = "0x15FE970", Offset = "0x15FD370", VA = "0x1815FE970")]
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

		[Cpp2IlInjected.Token(Token = "0x6003D2D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SparklingSlidingPanel()
		{
		}
	}
}
