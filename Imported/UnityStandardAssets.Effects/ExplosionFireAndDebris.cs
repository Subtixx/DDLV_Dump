using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public Transform[] debrisPrefabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public Transform firePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public int numDebrisPieces;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public int numFires;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x2F107D0", Offset = "0x2F0F1D0", VA = "0x182F107D0")]
		[IteratorStateMachine(typeof(_003CStart_003Ed__4))]
		private IEnumerator Start()
		{
			int _003C_003E1__state = default(int);
			_003CStart_003Ed__4 _003CStart_003Ed__ = new _003CStart_003Ed__4(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CStart_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2F10660", Offset = "0x2F0F060", VA = "0x182F10660")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
			//Discarded unreachable code: IL_0015
			Transform transform = firePrefab;
			Quaternion identity = Quaternion.identity;
			Transform transform2 = default(Transform);
			transform2.parent = t;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ExplosionFireAndDebris()
		{
		}
	}
}
