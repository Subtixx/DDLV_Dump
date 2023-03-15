using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006CD")]
	public static class PointOfInterestUtil
	{
		[Cpp2IlInjected.Token(Token = "0x6001E38")]
		[Cpp2IlInjected.Address(RVA = "0xCB3360", Offset = "0xCB1D60", VA = "0x180CB3360")]
		public static float DefaultInterestWeight(IPointOfInterest point, GameObject avatar, PointOfInterestActionConfig config, int weightBonus)
		{
			//Discarded unreachable code: IL_0049
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			Transform transform = avatar.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			float nearAvatarDistance = config.nearAvatarDistance;
			uint num3 = default(uint);
			if (num < (int)num3)
			{
				num += num;
				num++;
			}
			if (num > 0)
			{
				num += 328;
				num += 344;
			}
			float result = default(float);
			return result;
		}
	}
}
