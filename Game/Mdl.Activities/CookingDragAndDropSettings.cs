using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B26")]
	public class CookingDragAndDropSettings : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003DF9")]
		[SerializeField]
		private float force = 1000f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4003DFA")]
		[SerializeField]
		private Vector2 magnet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003DFB")]
		[SerializeField]
		private Vector2 positionMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4003DFC")]
		[SerializeField]
		private float cameraDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003DFD")]
		[SerializeField]
		private float catchDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4003DFE")]
		[SerializeField]
		private float catchLerp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003DFF")]
		[SerializeField]
		private float inRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4003E00")]
		[SerializeField]
		private float inOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003E01")]
		[SerializeField]
		private Transform surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003E02")]
		[SerializeField]
		private GameObject smokeVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003E03")]
		[SerializeField]
		private GameObject splashVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003E04")]
		[SerializeField]
		private GameObject potSmokeVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003E05")]
		[SerializeField]
		public AK.Wwise.Event sfxIngredientHitPot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003E06")]
		public GameObject cookingPotAudioEmitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003E07")]
		[SerializeField]
		private Transform target;

		[Cpp2IlInjected.Token(Token = "0x170006FF")]
		public float Force
		{
			[Cpp2IlInjected.Token(Token = "0x6003367")]
			[Cpp2IlInjected.Address(RVA = "0x837330", Offset = "0x835D30", VA = "0x180837330")]
			get
			{
				return force;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000700")]
		public Vector2 PositionMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6003368")]
			[Cpp2IlInjected.Address(RVA = "0x10680F0", Offset = "0x1066AF0", VA = "0x1810680F0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000701")]
		public float CameraDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6003369")]
			[Cpp2IlInjected.Address(RVA = "0xE3A600", Offset = "0xE39000", VA = "0x180E3A600")]
			get
			{
				return cameraDistance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600336A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9F30", Offset = "0x10F8930", VA = "0x1810F9F30")]
		[AsyncStateMachine(typeof(_003CCheckPot_003Ed__21))]
		public Task CheckPot(Rigidbody rb, Action successCallback, Action failureCallback)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600336B")]
		[Cpp2IlInjected.Address(RVA = "0x10FA160", Offset = "0x10F8B60", VA = "0x1810FA160")]
		private void Success(GameObject go, Action successCallback)
		{
			//Discarded unreachable code: IL_0083
			//IL_006f: Expected O, but got I4
			Transform transform = surface;
			GameObject gameObject = splashVFX;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Quaternion identity = Quaternion.identity;
			Transform transform2 = base.transform;
			GameObject obj = default(GameObject);
			UnityEngine.Object.Destroy(obj, 3f);
			Transform transform3 = surface;
			GameObject gameObject2 = potSmokeVFX;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			Quaternion identity2 = Quaternion.identity;
			Transform transform4 = base.transform;
			GameObject obj2 = default(GameObject);
			UnityEngine.Object.Destroy(obj2, 3f);
			int num = 0;
			if (go != (UnityEngine.Object)num)
			{
				UnityEngine.Object.Destroy(go);
			}
			successCallback?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x600336C")]
		[Cpp2IlInjected.Address(RVA = "0x10FA090", Offset = "0x10F8A90", VA = "0x1810FA090")]
		private void SpawnSmoke(Vector3 position)
		{
			GameObject gameObject = smokeVFX;
			Quaternion identity = Quaternion.identity;
			Transform transform = base.transform;
			float z = position.z;
		}

		[Cpp2IlInjected.Token(Token = "0x600336D")]
		[Cpp2IlInjected.Address(RVA = "0x10FA360", Offset = "0x10F8D60", VA = "0x1810FA360")]
		public unsafe CookingDragAndDropSettings()
		{
			//IL_0026: Expected F4, but got I4
			//IL_0021: Expected native int or pointer, but got O
			int num = 0;
			magnet = Vector2.one;
			((Vector2*)(IntPtr)magnet)->y = 0f;
			cameraDistance = 2f;
			base._002Ector();
		}
	}
}
