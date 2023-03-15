using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B18")]
	[CreateAssetMenu]
	internal class AutomaticPickUpData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003DB8")]
		public int automaticPickupDurationInSeconds = 60;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4003DB9")]
		public float distanceToCollect = 0.9f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003DBA")]
		public GameObject vfxPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003DBB")]
		public AssetReferenceGameObject itemPickedUpGizmoPrefab;

		[Cpp2IlInjected.Token(Token = "0x600332D")]
		[Cpp2IlInjected.Address(RVA = "0x150B2E0", Offset = "0x1509CE0", VA = "0x18150B2E0")]
		public AutomaticPickUpData()
		{
		}//IL_000a: Expected I4, but got I8

	}
}
