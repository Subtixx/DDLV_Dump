using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C2F")]
	[CreateAssetMenu]
	public class FollowCameraConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40043ED")]
		public bool DrawDebug;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x40043EE")]
		public bool Enabled = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40043EF")]
		public float Alpha = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40043F0")]
		public float BaseYawRotationInDegreesPerSecond = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40043F1")]
		public AnimationCurve VelocityCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40043F2")]
		public AnimationCurve AngleCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40043F3")]
		public AnimationCurve InputIdleCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40043F4")]
		public AnimationCurve InputActiveCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40043F5")]
		public float TargetPitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40043F6")]
		public float BasePitchRotationInDegreesPerSecond;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40043F7")]
		[Tooltip("Desired distance from the avatar for the camera (think of a camera boom; this is how long it is) (meters)")]
		public float DesiredCameraDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40043F8")]
		[Tooltip("If the camera was moved due to collision, this is how fast it moves back to the desired position (meters/sec)")]
		public AnimationCurve returnSpeed;

		[Cpp2IlInjected.Token(Token = "0x600377F")]
		[Cpp2IlInjected.Address(RVA = "0x145E8D0", Offset = "0x145D2D0", VA = "0x18145E8D0")]
		public FollowCameraConfig()
		{
			//Discarded unreachable code: IL_01ec
			//IL_0035: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_004c: Expected O, but got I4
			//IL_0058: Expected O, but got I4
			//IL_0064: Expected O, but got I4
			//IL_006e: Expected O, but got I4
			//IL_0099: Expected O, but got I4
			//IL_00a6: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			//IL_00bd: Expected O, but got I4
			//IL_00ec: Expected O, but got I4
			//IL_00f9: Expected O, but got I4
			//IL_0106: Expected O, but got I4
			//IL_0110: Expected O, but got I4
			//IL_013f: Expected O, but got I4
			//IL_014c: Expected O, but got I4
			//IL_0159: Expected O, but got I4
			//IL_0163: Expected O, but got I4
			//IL_01b0: Expected O, but got I4
			//IL_01bd: Expected O, but got I4
			//IL_01ca: Expected O, but got I4
			//IL_01d4: Expected O, but got I4
			Keyframe[] array = new Keyframe[3];
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			array[0] = (Keyframe)num2;
			int num5 = 0;
			array[3] = (Keyframe)num;
			int num6 = 0;
			array[3] = (Keyframe)num5;
			int num7 = 0;
			array[6] = (Keyframe)num6;
			int num8 = 0;
			array[7] = (Keyframe)num7;
			array[10] = (Keyframe)num8;
			VelocityCurve = new AnimationCurve(array);
			Keyframe[] array2 = new Keyframe[2];
			int num9 = 0;
			int num10 = 0;
			int num11 = 0;
			array2[0] = (Keyframe)num10;
			int num12 = 0;
			array2[3] = (Keyframe)num9;
			int num13 = 0;
			array2[3] = (Keyframe)num12;
			array2[6] = (Keyframe)num13;
			AngleCurve = new AnimationCurve(array2);
			Keyframe[] array3 = new Keyframe[2];
			int num14 = 0;
			int num15 = 0;
			int num16 = 0;
			int num17 = 0;
			array3[0] = (Keyframe)num15;
			int num18 = 0;
			array3[3] = (Keyframe)num14;
			int num19 = 0;
			array3[3] = (Keyframe)num18;
			array3[6] = (Keyframe)num19;
			InputIdleCurve = new AnimationCurve(array3);
			Keyframe[] array4 = new Keyframe[2];
			int num20 = 0;
			int num21 = 0;
			int num22 = 0;
			int num23 = 0;
			array4[0] = (Keyframe)num21;
			int num24 = 0;
			array4[3] = (Keyframe)num20;
			int num25 = 0;
			array4[3] = (Keyframe)num24;
			array4[6] = (Keyframe)num25;
			InputActiveCurve = new AnimationCurve(array4);
			TargetPitch = 15f;
			BasePitchRotationInDegreesPerSecond = 45f;
			DesiredCameraDistance = 7f;
			Keyframe[] array5 = new Keyframe[2];
			int num26 = 0;
			int num27 = 0;
			int num28 = 0;
			array5[0] = (Keyframe)num27;
			int num29 = 0;
			array5[3] = (Keyframe)num26;
			int num30 = 0;
			array5[3] = (Keyframe)num29;
			array5[6] = (Keyframe)num30;
			returnSpeed = new AnimationCurve(array5);
			base._002Ector();
		}
	}
}
