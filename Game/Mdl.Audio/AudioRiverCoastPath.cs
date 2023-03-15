using System.Collections.Generic;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Scene;
using UnityEngine;

namespace Mdl.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000B11")]
	public class AudioRiverCoastPath : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003D8A")]
		public List<Transform> Nodes = (List<Transform>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003D8B")]
		public VillageAreaType areaType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003D8C")]
		public AK.Wwise.Event water_sfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003D8D")]
		public Bank[] banksToLoad = new Bank[0];

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003D8E")]
		public float emitterMoveTime = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003D8F")]
		public GameObject emitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003D91")]
		private Transform targetTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003D92")]
		private bool curPathSegmentStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003D93")]
		private PathSegmentPos curPathSegment = new PathSegmentPos();

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003D94")]
		private PathSegmentPos targetPathSegment = new PathSegmentPos();

		[Cpp2IlInjected.Token(Token = "0x170006FA")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x4003D90")]
		private bool IsEmitterActive
		{
			[Cpp2IlInjected.Token(Token = "0x6003303")]
			[Cpp2IlInjected.Address(RVA = "0x951C70", Offset = "0x950670", VA = "0x180951C70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003304")]
			[Cpp2IlInjected.Address(RVA = "0x951E90", Offset = "0x950890", VA = "0x180951E90")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6003305")]
		[Cpp2IlInjected.Address(RVA = "0x1507C30", Offset = "0x1506630", VA = "0x181507C30")]
		public void OnDisable()
		{
			//Discarded unreachable code: IL_002b
			StopEmitter();
			Bank[] array = banksToLoad;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				array[num].Unload();
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003306")]
		[Cpp2IlInjected.Address(RVA = "0x1506E30", Offset = "0x1505830", VA = "0x181506E30")]
		public void ActivateEmitter(Transform targetTransform)
		{
			//Discarded unreachable code: IL_00a6
			//IL_002a: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			if (IsEmitterActive || (long)water_sfx == 0)
			{
				return;
			}
			GameObject gameObject = emitter;
			int num = 0;
			if (gameObject == (Object)num)
			{
				return;
			}
			List<Transform> nodes = Nodes;
			int num2 = 0;
			if (!(targetTransform == (Object)num2))
			{
				this.targetTransform = targetTransform;
				Bank[] array = banksToLoad;
				int num3 = 0;
				int length = array.Length;
				if (num3 < length)
				{
					Bank bank = array[num3];
					int saveDecodedBank = 0;
					int decodeBank = 0;
					bank.Load((byte)decodeBank != 0, (byte)saveDecodedBank != 0);
					num3++;
				}
				AK.Wwise.Event @event = water_sfx;
				GameObject gameObject2 = emitter;
				uint num4 = @event.Post(gameObject2);
				IsEmitterActive = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003307")]
		[Cpp2IlInjected.Address(RVA = "0x1508070", Offset = "0x1506A70", VA = "0x181508070")]
		public void StopEmitter()
		{
			//Discarded unreachable code: IL_005a
			IsEmitterActive = false;
			AK.Wwise.Event @event = water_sfx;
			GameObject gameObject = emitter;
			int transitionDuration = 0;
			@event.Stop(gameObject, transitionDuration);
			Bank[] array = banksToLoad;
			int num = 0;
			int num2 = 0;
			int length = array.Length;
			if (num < length)
			{
				array[num2].Unload();
				num2++;
			}
			curPathSegmentStarted = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6003308")]
		[Cpp2IlInjected.Address(RVA = "0x1508B70", Offset = "0x1507570", VA = "0x181508B70")]
		public void Update()
		{
			if (IsEmitterActive)
			{
				UpdateEmitterTargetPosition();
				UpdateEmitterPosition();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003309")]
		[Cpp2IlInjected.Address(RVA = "0x1508120", Offset = "0x1506B20", VA = "0x181508120")]
		private void UpdateEmitterPosition()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600330A")]
		[Cpp2IlInjected.Address(RVA = "0x1507860", Offset = "0x1506260", VA = "0x181507860")]
		private void MoveEmmiterFromTo(PathSegmentPos curPathSegment, PathSegmentPos targetPathSegment, float distanceToMove)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600330B")]
		[Cpp2IlInjected.Address(RVA = "0x15071B0", Offset = "0x1505BB0", VA = "0x1815071B0")]
		private float GetDistanceFromCurrentToTargetNode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600330C")]
		[Cpp2IlInjected.Address(RVA = "0x15082D0", Offset = "0x1506CD0", VA = "0x1815082D0")]
		private void UpdateEmitterTargetPosition()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600330D")]
		[Cpp2IlInjected.Address(RVA = "0x1507730", Offset = "0x1506130", VA = "0x181507730")]
		public float GetPointOnSegmentProjection(Vector3 NodeA, Vector3 NodeB, Vector3 point)
		{
			//IL_000e: Expected F4, but got I4
			//IL_000e: Expected F4, but got I4
			int num = 0;
			return Mathf.Clamp(0f, num, 1f);
		}

		[Cpp2IlInjected.Token(Token = "0x600330E")]
		[Cpp2IlInjected.Address(RVA = "0x1507630", Offset = "0x1506030", VA = "0x181507630")]
		public Vector3 GetPointOnSegmentProjectionPosition(Vector3 NodeA, Vector3 NodeB, float t)
		{
			float z = NodeB.z;
			float z2 = NodeB.z;
			float z3 = NodeB.z;
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600330F")]
		[Cpp2IlInjected.Address(RVA = "0x1506F90", Offset = "0x1505990", VA = "0x181506F90")]
		private int GetClosestNodeToTarget(Transform cameraTransform)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003310")]
		[Cpp2IlInjected.Address(RVA = "0x1507CA0", Offset = "0x15066A0", VA = "0x181507CA0")]
		private void OnDrawGizmos()
		{
			//Discarded unreachable code: IL_00a4
			//IL_003c: Expected O, but got I4
			Color red = Color.red;
			List<Transform> nodes = Nodes;
			int num = 0;
			List<Transform> nodes2 = Nodes;
			List<Transform> nodes3 = Nodes;
			if (IsEmitterActive)
			{
				Transform transform = targetTransform;
				int num2 = 0;
				if (transform != (Object)num2)
				{
					Color blue = Color.blue;
					Transform transform2 = emitter.transform;
					Vector3 one = Vector3.one;
					Transform transform3 = emitter.transform;
					Transform transform4 = targetTransform;
					Color green = Color.green;
					PathSegmentPos pathSegmentPos = curPathSegment;
					Vector3 one2 = Vector3.one;
					PathSegmentPos pathSegmentPos2 = curPathSegment;
					PathSegmentPos pathSegmentPos3 = targetPathSegment;
					float z = pathSegmentPos2.intersectionPoint.z;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003311")]
		[Cpp2IlInjected.Address(RVA = "0x1508BA0", Offset = "0x15075A0", VA = "0x181508BA0")]
		public AudioRiverCoastPath()
		{
		}
	}
}
