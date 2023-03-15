using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x200045B")]
	[CreateAssetMenu]
	public class GridEditModeInputConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001BB2")]
		[Tooltip("Percent of screen covered per second")]
		public float CursorSpeed = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001BB3")]
		[Tooltip("Remap cursor inputs to this map; used to help with precision movements")]
		public AnimationCurve CursorInputRemap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001BB4")]
		[Tooltip("DPad cursor scaling based on distance from ground")]
		public AnimationCurve CursorPrecisionDistanceMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001BB5")]
		[Tooltip("DPag cursor acceleration")]
		public float CursorPrecisionAcceleration = 1.4f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4001BB6")]
		[Tooltip("DPag cursor deceleration")]
		public float CursorPrecisionDeceleration = 1000f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001BB7")]
		[Tooltip("Percent of screen at which to start auto-panning")]
		public float AutoPanHorizontalPercent = 0.05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4001BB8")]
		[Tooltip("Percent of screen at which to start auto-panning")]
		public float AutoPanVerticalPercent = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x60012B2")]
		[Cpp2IlInjected.Address(RVA = "0xCEC560", Offset = "0xCEAF60", VA = "0x180CEC560")]
		public GridEditModeInputConfig()
		{
		}
	}
}
