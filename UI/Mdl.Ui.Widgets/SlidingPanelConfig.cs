using Cpp2IlInjected;
using Mdl.Motion;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009C4")]
	[CreateAssetMenu]
	public class SlidingPanelConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003986")]
		public float openDuration = 0.3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4003987")]
		public float openAnticAmount = 30f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003988")]
		public float openAnticDuration = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003989")]
		public float openOvershootAmount = 30f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400398A")]
		public float openOvershootDuration = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400398B")]
		public float closeDuration = 0.3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400398C")]
		public float closeOvershootAmount = 100f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400398D")]
		public float closeOvershootDuration = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400398E")]
		public float closeSettleAmount = 30f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400398F")]
		public float closeSettleDuration = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003990")]
		public EasingType openAnticEasing = EasingType.QuadEaseInOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4003991")]
		public EasingType openEasing = EasingType.QuadEaseIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003992")]
		public EasingType openOvershootEasing = EasingType.QuadEaseInOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4003993")]
		public EasingType closeEasing = EasingType.QuadEaseIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003994")]
		public EasingType closeOvershootEasing = EasingType.QuadEaseInOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4003995")]
		public EasingType closeSettleEasing = EasingType.QuartEaseInOut;

		[Cpp2IlInjected.Token(Token = "0x6003D24")]
		[Cpp2IlInjected.Address(RVA = "0x15F5F00", Offset = "0x15F4900", VA = "0x1815F5F00")]
		public SlidingPanelConfig()
		{
		}//IL_0078: Expected I4, but got I8
		//IL_0081: Expected I4, but got I8
		//IL_008b: Expected I4, but got I8
		//IL_0094: Expected I4, but got I8
		//IL_009e: Expected I4, but got I8
		//IL_00a8: Expected I4, but got I8

	}
}
