using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Mdl.Characters;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B43")]
	public class RewardBounds : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003EB8")]
		public Bounds Bounds;

		[Cpp2IlInjected.Token(Token = "0x6003421")]
		[Cpp2IlInjected.Address(RVA = "0xCC2790", Offset = "0xCC1190", VA = "0x180CC2790")]
		public Vector3 CalculateRewardItemScale(GameObject rewardObject)
		{
			//IL_00fe: Expected F4, but got I8
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			StimulusBroadcaster[] array = default(StimulusBroadcaster[]);
			List<StimulusBroadcaster> list = (List<StimulusBroadcaster>)(object)Enumerable.ToList<StimulusBroadcaster>((IEnumerable<>)(object)array);
			List<Collider> unusedCollider = (List<Collider>)(object)new List<T>();
			Action<StimulusBroadcaster> action = (Action<StimulusBroadcaster>)(object)(Action<T>)delegate(StimulusBroadcaster x)
			{
				//Discarded unreachable code: IL_001b
				List<Collider> list3 = unusedCollider;
				List<Collider> list4 = (List<Collider>)(object)Enumerable.ToList<Collider>((IEnumerable<>)(object)x.GetComponentsInChildren<Collider>());
				((List<T>)(object)list3).AddRange((IEnumerable<>)list4);
			};
			((List<T>)(object)list).ForEach((Action<>)(object)action);
			List<Collider> list2 = unusedCollider;
			Collider[] array2 = default(Collider[]);
			Collider[] array3 = Enumerable.Except<Collider>((IEnumerable<>)(object)array2, (IEnumerable<>)list2).ToArray<Collider>();
			Func<MeshRenderer, Bounds> func = default(Func<MeshRenderer, Bounds>);
			if (_003C_003Ec._003C_003E9__1_0 == null)
			{
				func = (Func<MeshRenderer, Bounds>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new NullReferenceException();
				});
			}
			MeshRenderer[] array4 = default(MeshRenderer[]);
			IEnumerable<MeshRenderer> enumerable = (IEnumerable<MeshRenderer>)Enumerable.Select<MeshRenderer, Bounds>((IEnumerable<>)(object)array4, (Func<, >)(object)func);
			Func<Collider, Bounds> func2 = default(Func<Collider, Bounds>);
			if (_003C_003Ec._003C_003E9__1_1 == null)
			{
				func2 = (Func<Collider, Bounds>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new NullReferenceException();
				});
			}
			IEnumerable<Collider> enumerable2 = (IEnumerable<Collider>)Enumerable.Select<Collider, Bounds>((IEnumerable<>)(object)array2, (Func<, >)(object)func2);
			IEnumerable<Bounds> enumerable3 = (IEnumerable<Bounds>)Enumerable.Concat<Bounds>((IEnumerable<>)enumerable, (IEnumerable<>)enumerable2);
			int num4 = 0;
			int num5 = 0;
			float z = Vector3.zero.z;
			if (_003C_003Ec._003C_003E9__1_2 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T1, T2, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			float[] array5 = new float[4];
			array5[0] = 1.0653532E+09f;
			float num6 = Mathf.Min(array5);
			float z2 = Vector3.one.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003422")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public RewardBounds()
		{
		}
	}
}
