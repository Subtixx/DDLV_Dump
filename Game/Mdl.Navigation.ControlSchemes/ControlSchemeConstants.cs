using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Navigation.ControlSchemes
{
	[Cpp2IlInjected.Token(Token = "0x2000C9A")]
	public static class ControlSchemeConstants
	{
		[Cpp2IlInjected.Token(Token = "0x4004696")]
		private static readonly float defaultResetAngle;

		[Cpp2IlInjected.Token(Token = "0x4004697")]
		private static readonly float inFrontOfAvatarAngle;

		[Cpp2IlInjected.Token(Token = "0x4004698")]
		private static readonly float behindAvatarAngle;

		[Cpp2IlInjected.Token(Token = "0x4004699")]
		public static readonly float InstantTransitionTime;

		[Cpp2IlInjected.Token(Token = "0x400469A")]
		public static readonly float DefaultTransitionTime;

		[Cpp2IlInjected.Token(Token = "0x6003A7B")]
		[Cpp2IlInjected.Address(RVA = "0xA92FF0", Offset = "0xA919F0", VA = "0x180A92FF0")]
		private static float CalculateAngle(Transform transform, float angle)
		{
			//Discarded unreachable code: IL_002d
			//IL_0017: Expected F4, but got I4
			//IL_0017: Expected F4, but got I4
			//IL_002c: Expected O, but got I4
			Vector3 vector = default(Vector3);
			float z = vector.z;
			int num = 0;
			int num2 = 0;
			Quaternion quaternion = Quaternion.Euler(z, num2, num);
			int num3 = 0;
			Vector2 up = Vector2.up;
			return Vector2.SignedAngle((Vector2)num3, up);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A7C")]
		[Cpp2IlInjected.Address(RVA = "0xA93120", Offset = "0xA91B20", VA = "0x180A93120")]
		public static float DefaultResetAngle(Transform transform)
		{
			float angle = defaultResetAngle;
			return CalculateAngle(transform, angle);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A7D")]
		[Cpp2IlInjected.Address(RVA = "0xA93190", Offset = "0xA91B90", VA = "0x180A93190")]
		public static float InFrontOfAvatarAngle(Transform transform)
		{
			float angle = inFrontOfAvatarAngle;
			return CalculateAngle(transform, angle);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A7E")]
		[Cpp2IlInjected.Address(RVA = "0xA92F80", Offset = "0xA91980", VA = "0x180A92F80")]
		public static float BehindAvatarAngle(Transform transform)
		{
			float angle = behindAvatarAngle;
			return CalculateAngle(transform, angle);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A7F")]
		[Cpp2IlInjected.Address(RVA = "0xA93200", Offset = "0xA91C00", VA = "0x180A93200")]
		static ControlSchemeConstants()
		{
			//IL_0008: Expected F4, but got I4
			//IL_000e: Expected F4, but got I4
			//IL_0014: Expected F4, but got I4
			int num = 0;
			defaultResetAngle = num;
			behindAvatarAngle = num;
			InstantTransitionTime = num;
		}
	}
}
