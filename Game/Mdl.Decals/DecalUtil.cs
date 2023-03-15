using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Meta.Customization;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Mdl.Decals
{
	[Cpp2IlInjected.Token(Token = "0x2000837")]
	public static class DecalUtil
	{
		[Cpp2IlInjected.Token(Token = "0x6002501")]
		[Cpp2IlInjected.Address(RVA = "0x1621920", Offset = "0x1620320", VA = "0x181621920")]
		public static List<IDecal> ParseDecals(TextAsset asset)
		{
			//Discarded unreachable code: IL_0050, IL_0056, IL_005c, IL_0062
			//IL_0011: Expected O, but got I4
			int num = 0;
			List<IDecal> list = (List<IDecal>)(object)new List<T>();
			int num2 = 0;
			IEnumerator<JToken> enumerator;
			Decal decal = default(Decal);
			if (!(asset == (UnityEngine.Object)num2))
			{
				enumerator = (IEnumerator<JToken>)JArray.Parse(asset.text).GetEnumerator();
				if (enumerator != null)
				{
					uint num3 = default(uint);
					if (num < (int)num3)
					{
						num += num;
						if (num == (int)num3)
						{
							goto IL_0043;
						}
						num++;
					}
					((List<T>)(object)list).Add((T)decal);
					goto IL_0043;
				}
				goto IL_004a;
			}
			goto IL_004e;
			IL_004e:
			return list;
			IL_0043:
			decal = (Decal)(object)((object)decal + (object)decal);
			goto IL_004a;
			IL_004a:
			if (enumerator == null)
			{
			}
			goto IL_004e;
		}

		[Cpp2IlInjected.Token(Token = "0x6002502")]
		[Cpp2IlInjected.Address(RVA = "0x1621BD0", Offset = "0x16205D0", VA = "0x181621BD0")]
		public static UnityEngine.Vector3 ToUnityVector3(IVector3 v)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002503")]
		[Cpp2IlInjected.Address(RVA = "0x16218A0", Offset = "0x16202A0", VA = "0x1816218A0")]
		public static Meta.Customization.Vector3 FromUnityVector3(UnityEngine.Vector3 v)
		{
			//Discarded unreachable code: IL_0024
			Meta.Customization.Vector3 vector = new Meta.Customization.Vector3();
			float y = v.y;
			float z = v.z;
			vector.y_ = y;
			vector.z_ = z;
			return vector;
		}
	}
}
