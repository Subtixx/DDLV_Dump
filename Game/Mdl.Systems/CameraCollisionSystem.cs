using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Characters;
using Mdl.Navigation;
using Mdl.Utils;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

namespace Mdl.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000947")]
	public class CameraCollisionSystem : System
	{
		[Cpp2IlInjected.Token(Token = "0x2000948")]
		private class ForceCharacterVisibleScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003389")]
			private CameraCollisionSystem cameraCollisions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400338A")]
			private Character character;

			[Cpp2IlInjected.Token(Token = "0x6002ACB")]
			[Cpp2IlInjected.Address(RVA = "0x539250", Offset = "0x537C50", VA = "0x180539250")]
			public ForceCharacterVisibleScope(CameraCollisionSystem cameraCollisions, Character character)
			{
				this.cameraCollisions = cameraCollisions;
				this.character = character;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6002ACC")]
			[Cpp2IlInjected.Address(RVA = "0x13E5410", Offset = "0x13E3E10", VA = "0x1813E5410", Slot = "4")]
			public void Dispose()
			{
				//Discarded unreachable code: IL_0012, IL_0016, IL_0038, IL_0059, IL_005a
				Dictionary<Character, CountedBool> forcedVisibleCharacters = cameraCollisions.forcedVisibleCharacters;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003371")]
		[SerializeField]
		private List<ItemType> AutoDitherItems = (List<ItemType>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003372")]
		[SerializeField]
		private List<FurnitureItemType> AutoDitherFurnitureItems = (List<FurnitureItemType>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003373")]
		[SerializeField]
		private List<ActivityItemType> AutoDitherActivityItems = (List<ActivityItemType>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003374")]
		[SerializeField]
		private List<ItemType> AutoCameraCollisionItems = (List<ItemType>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003375")]
		[SerializeField]
		private List<FurnitureItemType> AutoCameraCollisionFurnitureItems = (List<FurnitureItemType>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003376")]
		[SerializeField]
		private List<ActivityItemType> AutoCameraCollisionActivityItems = (List<ActivityItemType>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4003377")]
		[SerializeField]
		private float HideAvatarDistance = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003378")]
		[SerializeField]
		private AnimationCurve LookAtHeadLerpAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4003379")]
		[SerializeField]
		private AnimationCurve VerticalCameraOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400337A")]
		[SerializeField]
		private Vector3 HeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400337B")]
		private List<SkinnedMeshRenderer> HiddenSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400337C")]
		private List<SkinnedMeshRenderer> AvatarHiddenSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400337D")]
		[SerializeField]
		public float DefaultCameraCollisionDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400337E")]
		public CountedBool ForcePlayerAvatarVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400337F")]
		private Dictionary<Character, CountedBool> forcedVisibleCharacters;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4003380")]
		public CountedBool FocusPlayerAvatar;

		[Cpp2IlInjected.Token(Token = "0x4003381")]
		private static readonly ProfilerMarker s_getCollisionPosition;

		[Cpp2IlInjected.Token(Token = "0x4003382")]
		private static readonly ProfilerMarker s_getCollisionPosition_movementCast;

		[Cpp2IlInjected.Token(Token = "0x4003383")]
		private static readonly ProfilerMarker s_getCollisionPosition_existingOverlap;

		[Cpp2IlInjected.Token(Token = "0x4003384")]
		private static Collider[] collisionArray;

		[Cpp2IlInjected.Token(Token = "0x4003385")]
		private static readonly ProfilerMarker s_adjustAvatarDistance;

		[Cpp2IlInjected.Token(Token = "0x4003386")]
		private static readonly ProfilerMarker s_updateCharacters;

		[Cpp2IlInjected.Token(Token = "0x4003387")]
		private static readonly ProfilerMarker s_updateCharacters_avatar;

		[Cpp2IlInjected.Token(Token = "0x4003388")]
		private static readonly ProfilerMarker s_updateCharacters_npcs;

		[Cpp2IlInjected.Token(Token = "0x6002AB7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002AB8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnSystemPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002AB9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002ABA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
		public override void OnSystemStop()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002ABB")]
		[Cpp2IlInjected.Address(RVA = "0x164AA20", Offset = "0x1649420", VA = "0x18164AA20")]
		private bool MatchesFilter(Item item, List<ItemType> itemTypes, List<FurnitureItemType> furnitureTypes, List<ActivityItemType> activityItems)
		{
			int num = 0;
			ItemType itemType = default(ItemType);
			int num2 = (int)itemType;
			bool flag = default(bool);
			if (flag)
			{
				switch (num2)
				{
				case 3:
				{
					bool flag3 = default(bool);
					if (flag3)
					{
						ActivityItemType activityItemType = default(ActivityItemType);
						int num3 = (int)activityItemType;
						bool result = default(bool);
						return result;
					}
					break;
				}
				case 4:
				{
					bool flag2 = default(bool);
					if (!flag2)
					{
					}
					break;
				}
				}
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002ABC")]
		[Cpp2IlInjected.Address(RVA = "0x164ABA0", Offset = "0x16495A0", VA = "0x18164ABA0")]
		internal bool ShouldDitherItem(Item item)
		{
			if (!FocusPlayerAvatar)
			{
				List<ActivityItemType> autoDitherActivityItems = AutoDitherActivityItems;
				bool result = default(bool);
				return result;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002ABD")]
		[Cpp2IlInjected.Address(RVA = "0x164AB70", Offset = "0x1649570", VA = "0x18164AB70")]
		internal bool ShouldAutoCameraCollisionItem(Item item)
		{
			List<ActivityItemType> autoCameraCollisionActivityItems = AutoCameraCollisionActivityItems;
			List<FurnitureItemType> autoCameraCollisionFurnitureItems = AutoCameraCollisionFurnitureItems;
			List<ItemType> autoCameraCollisionItems = AutoCameraCollisionItems;
			return this.MatchesFilter(item, (List<>)(object)autoCameraCollisionItems, (List<>)(object)autoCameraCollisionFurnitureItems, (List<>)(object)autoCameraCollisionActivityItems);
		}

		[Cpp2IlInjected.Token(Token = "0x6002ABE")]
		[Cpp2IlInjected.Address(RVA = "0x1649940", Offset = "0x1648340", VA = "0x181649940")]
		internal void AddAutoCameraCollisionTo(GameObject gameObject)
		{
			//Discarded unreachable code: IL_010c
			GameObject gameObject2 = new GameObject("autoCameraCollision");
			int num2 = (gameObject2.layer = LayerMask.NameToLayer("CameraCollision"));
			Transform transform = gameObject2.transform;
			Transform transform3 = (transform.parent = gameObject.transform);
			Transform transform4 = gameObject2.transform;
			float z = Vector3.zero.z;
			Collider[] components = gameObject.GetComponents<Collider>();
			int num3 = 0;
			int num4 = 0;
			int length = components.Length;
			if (num3 >= length)
			{
				return;
			}
			Collider collider = components[num4];
			if ((object)collider != null)
			{
				int num5 = 0;
				if ((object)collider == null)
				{
					int num6 = 0;
					float radius = default(float);
					if ((object)collider == null)
					{
						int num7 = 0;
						if ((object)collider == null)
						{
							goto IL_0105;
						}
						SphereCollider sphereCollider = gameObject2.AddComponent<SphereCollider>();
						Vector3 vector = default(Vector3);
						float z2 = vector.z;
						sphereCollider.radius = radius;
						num4++;
					}
					CapsuleCollider capsuleCollider = gameObject2.AddComponent<CapsuleCollider>();
					Vector3 vector2 = default(Vector3);
					float z3 = vector2.z;
					int direction = default(int);
					capsuleCollider.direction = direction;
					float num8 = default(float);
					radius = (capsuleCollider.height = num8);
					float num10 = default(float);
					radius = (capsuleCollider.radius = num10);
					num4++;
				}
				BoxCollider boxCollider = gameObject2.AddComponent<BoxCollider>();
				Vector3 vector3 = default(Vector3);
				float z4 = vector3.z;
				Vector3 vector4 = default(Vector3);
				float z5 = vector4.z;
			}
			goto IL_0105;
			IL_0105:
			num4++;
		}

		[Cpp2IlInjected.Token(Token = "0x6002ABF")]
		[Cpp2IlInjected.Address(RVA = "0x164A340", Offset = "0x1648D40", VA = "0x18164A340")]
		internal unsafe static (bool, Vector3) GetCollisionPosition(Vector3 targetOrigin, Vector3 cameraPosition, Vector3 cameraForward, float collisionRadius, float collisionOverlapRadius, int collisionMask)
		{
			//IL_0077: Expected native int or pointer, but got O
			//IL_00f0: Expected native int or pointer, but got O
			//IL_0142: Expected F4, but got I4
			//IL_013d: Expected native int or pointer, but got O
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			float z = cameraPosition.z;
			float z2 = cameraForward.z;
			float z3 = cameraPosition.z;
			float z4 = cameraForward.z;
			float z5 = cameraPosition.z;
			Vector3 vector = default(Vector3);
			float z6 = vector.z;
			float z7 = cameraPosition.z;
			float z8 = cameraForward.z;
			float z9 = cameraPosition.z;
			float z10 = cameraForward.z;
			float z11 = cameraPosition.z;
			float z12 = cameraPosition.z;
			bool flag = default(bool);
			if (flag)
			{
				Vector3 vector2 = default(Vector3);
				float num4 = (((Vector3*)(IntPtr)cameraForward)->z = vector2.z);
				float z13 = cameraPosition.z;
				float z14 = vector2.z;
				float z15 = cameraPosition.z;
				Vector3 vector3 = default(Vector3);
				float z16 = vector3.z;
				float z17 = cameraPosition.z;
				float z18 = cameraForward.z;
				float z19 = cameraPosition.z;
				float z20 = cameraForward.z;
				float z21 = cameraPosition.z;
				float z22 = cameraPosition.z;
				float num5 = default(float);
				float num6 = num5;
			}
			float z23 = cameraPosition.z;
			int num7 = default(int);
			bool flag2 = default(bool);
			if (num7 > 0 && flag2)
			{
				Vector3 vector4 = default(Vector3);
				float num8 = (((Vector3*)(IntPtr)cameraForward)->z = vector4.z);
				float z24 = cameraPosition.z;
				float z25 = vector4.z;
				float z26 = cameraPosition.z;
				Vector3 vector5 = default(Vector3);
				float z27 = vector5.z;
				float z28 = cameraForward.z;
				float z29 = cameraPosition.z;
				float z30 = cameraPosition.z;
			}
			float z31 = cameraForward.z;
			int num9 = 0;
			((Vector3*)(IntPtr)targetOrigin)->x = num9;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AC0")]
		[Cpp2IlInjected.Address(RVA = "0x1649D90", Offset = "0x1648790", VA = "0x181649D90")]
		internal unsafe static (Vector3, Vector3) AdjustCameraBasedOnAvatarDistance(Vector3 cameraPosition, Vector3 targetPosition, [global::System.Runtime.InteropServices.Optional] CameraCollisionSystem cameraCollision)
		{
			//IL_004d: Expected native int or pointer, but got O
			//IL_0055: Expected native int or pointer, but got O
			//IL_0065: Expected F4, but got I4
			//IL_0060: Expected native int or pointer, but got O
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				CameraCollisionSystem system = SystemRoot.Instance.GetSystem<CameraCollisionSystem>();
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				float z = targetPosition.z;
				GameObject gameObject = default(GameObject);
				Transform transform = gameObject.transform;
				Vector3 vector = default(Vector3);
				float z2 = vector.z;
				int num2 = 0;
				int num3 = 0;
				float num4 = default(float);
				float t = default(float);
				float y = Mathf.Lerp(targetPosition.y, num4, t);
				t = num4;
				((Vector3*)(IntPtr)targetPosition)->x = num4;
				((Vector3*)(IntPtr)targetPosition)->y = y;
			}
			int num5 = 0;
			((Vector3*)(IntPtr)cameraPosition)->x = num5;
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AC1")]
		[Cpp2IlInjected.Address(RVA = "0x164ADD0", Offset = "0x16497D0", VA = "0x18164ADD0")]
		internal unsafe static void UpdateNearbyCharacterVisibility(Vector3 cameraPosition, [global::System.Runtime.InteropServices.Optional] CameraCollisionSystem cameraCollision)
		{
			//Discarded unreachable code: IL_0111, IL_0117, IL_011d, IL_0123, IL_0129, IL_012f
			//IL_0013: Expected O, but got I4
			//IL_00cb: Expected O, but got I4
			//IL_0102: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			Vector3 vector = default(Vector3);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			NonAllocSelectEnumerator<CharacterManager.CharacterInstance, Character, NonAllocWhereEnumerator<CharacterManager.CharacterInstance, List<CharacterManager.CharacterInstance>.Enumerator>> nonAllocSelectEnumerator = default(NonAllocSelectEnumerator<CharacterManager.CharacterInstance, Character, NonAllocWhereEnumerator<CharacterManager.CharacterInstance, List<CharacterManager.CharacterInstance>.Enumerator>>);
			bool flag6 = default(bool);
			Character character = default(Character);
			Vector3 vector2 = default(Vector3);
			bool flag7 = default(bool);
			bool flag8 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				if (cameraCollision == (UnityEngine.Object)num5)
				{
					CameraCollisionSystem system = SystemRoot.Instance.GetSystem<CameraCollisionSystem>();
				}
				List<SkinnedMeshRenderer> avatarHiddenSkinnedMeshes = cameraCollision.AvatarHiddenSkinnedMeshes;
				if (flag)
				{
					int num6 = 0;
				}
				int num7 = 0;
				if (!flag2 && !flag3)
				{
					Collider _003CCollider_003Ek__BackingField = SystemRoot.Instance._avatar.Collider;
					float z = vector.z;
					if (flag4)
					{
						SkinnedMeshRenderer[] componentsInChildren = _003CCollider_003Ek__BackingField.GetComponentsInChildren<SkinnedMeshRenderer>();
						int length = componentsInChildren.Length;
						if (num7 < length)
						{
							componentsInChildren[num7].forceRenderingOff = true;
							num7++;
						}
					}
				}
				if (flag5)
				{
					int num8 = 0;
				}
				CharacterManager system2 = SystemRoot.Instance.GetSystem<CharacterManager>();
				Func<, > func = (Func<, >)(object)((NonAllocSelectEnumerator<, , >*)(&nonAllocSelectEnumerator))->func;
				if (!flag6)
				{
					break;
				}
				InteractionComponentCache orAddComponent = character.GetOrAddComponent<InteractionComponentCache>();
				Collider _003Ccollider_003Ek__BackingField = orAddComponent.collider;
				int num9 = 0;
				if (!(_003Ccollider_003Ek__BackingField == (UnityEngine.Object)num9))
				{
					Collider _003Ccollider_003Ek__BackingField2 = orAddComponent.collider;
					float z2 = vector2.z;
					while (flag7)
					{
					}
					while (!flag8)
					{
					}
					SkinnedMeshRenderer componentInChildren = character.GetComponentInChildren<SkinnedMeshRenderer>();
					int num10 = 0;
					if (componentInChildren != (UnityEngine.Object)num10)
					{
						componentInChildren.forceRenderingOff = true;
						break;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AC2")]
		[Cpp2IlInjected.Address(RVA = "0x164A1F0", Offset = "0x1648BF0", VA = "0x18164A1F0")]
		public IDisposable ForceCharacterVisible(Character character)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_002e
			Dictionary<Character, CountedBool> dictionary = forcedVisibleCharacters;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AC3")]
		[Cpp2IlInjected.Address(RVA = "0x164A9C0", Offset = "0x16493C0", VA = "0x18164A9C0")]
		private bool IsCharacterForcedVisible(Character character)
		{
			//Discarded unreachable code: IL_000d, IL_0015
			Dictionary<Character, CountedBool> dictionary = forcedVisibleCharacters;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AC4")]
		[Cpp2IlInjected.Address(RVA = "0x164AD50", Offset = "0x1649750", VA = "0x18164AD50")]
		public void UpdateCharacterVisibility(Vector3 cameraPosition)
		{
			float z = cameraPosition.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AC5")]
		[Cpp2IlInjected.Address(RVA = "0x164AC00", Offset = "0x1649600", VA = "0x18164AC00")]
		public void UpdateCharacterVisibilityFromPlayerCamera()
		{
			//Discarded unreachable code: IL_0018
			Transform transform = SystemRoot.Instance._playerCamera.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AC6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_ONSCREEN_CAMERA_COLLISION")]
		private static void OnscreenDebug(string key, float value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002AC7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_ONSCREEN_CAMERA_COLLISION")]
		private static void OnscreenDebug(string key, Vector3 value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002AC8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_ONSCREEN_CAMERA_COLLISION")]
		private static void DebugSphere(Vector3 position, float radius, Color color)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002AC9")]
		[Cpp2IlInjected.Address(RVA = "0x164B8E0", Offset = "0x164A2E0", VA = "0x18164B8E0")]
		public unsafe CameraCollisionSystem()
		{
			//Discarded unreachable code: IL_0190
			//IL_007b: Expected O, but got I4
			//IL_0088: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			//IL_009f: Expected O, but got I4
			//IL_00d1: Expected O, but got I4
			//IL_00de: Expected O, but got I4
			//IL_00eb: Expected O, but got I4
			//IL_00f5: Expected O, but got I4
			//IL_011a: Expected native int or pointer, but got O
			Keyframe[] array = new Keyframe[2];
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			array[0] = (Keyframe)num;
			int num5 = 0;
			array[3] = (Keyframe)num2;
			int num6 = 0;
			array[3] = (Keyframe)num5;
			array[6] = (Keyframe)num6;
			LookAtHeadLerpAlpha = new AnimationCurve(array);
			Keyframe[] array2 = new Keyframe[2];
			int num7 = 0;
			int num8 = 0;
			int num9 = 0;
			int num10 = 0;
			int num11 = 0;
			array2[0] = (Keyframe)num8;
			int num12 = 0;
			array2[3] = (Keyframe)num7;
			int num13 = 0;
			array2[3] = (Keyframe)num12;
			array2[6] = (Keyframe)num13;
			VerticalCameraOffset = new AnimationCurve(array2);
			float z = Vector3.zero.z;
			((Vector3*)(IntPtr)HeadOffset)->z = z;
			HiddenSkinnedMeshes = (List<SkinnedMeshRenderer>)(object)new List<T>();
			AvatarHiddenSkinnedMeshes = (List<SkinnedMeshRenderer>)(object)new List<T>();
			DefaultCameraCollisionDistance = 0.5f;
			int debug = default(int);
			CountedBool forcePlayerAvatarVisible = new CountedBool("", (byte)debug != 0);
			debug = 0;
			ForcePlayerAvatarVisible = forcePlayerAvatarVisible;
			forcedVisibleCharacters = (Dictionary<Character, CountedBool>)(object)new Dictionary<TKey, TValue>();
			int debug2 = default(int);
			CountedBool focusPlayerAvatar = new CountedBool("", (byte)debug2 != 0);
			debug2 = 0;
			FocusPlayerAvatar = focusPlayerAvatar;
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6002ACA")]
		[Cpp2IlInjected.Address(RVA = "0x164B660", Offset = "0x164A060", VA = "0x18164B660")]
		static CameraCollisionSystem()
		{
			//IL_0025: Expected O, but got I
			//IL_0047: Expected O, but got I
			//IL_0062: Expected O, but got I
			//IL_0092: Expected O, but got I
			//IL_00b4: Expected O, but got I
			//IL_00d6: Expected O, but got I
			//IL_00f1: Expected O, but got I
			int num = 0;
			int num2 = 0;
			int flags = 0;
			int metadataCount = 0;
			ushort categoryId = default(ushort);
			IntPtr intPtr = ProfilerUnsafeUtility.CreateMarker("GetCollisionPosition", categoryId, (MarkerFlags)flags, metadataCount);
			int num3 = 0;
			s_getCollisionPosition = (ProfilerMarker)(long)intPtr;
			int flags2 = 0;
			int metadataCount2 = 0;
			ushort categoryId2 = default(ushort);
			IntPtr intPtr2 = ProfilerUnsafeUtility.CreateMarker("MovementCast", categoryId2, (MarkerFlags)flags2, metadataCount2);
			int num4 = 0;
			s_getCollisionPosition_movementCast = (ProfilerMarker)(long)intPtr2;
			int flags3 = 0;
			int metadataCount3 = 0;
			ushort categoryId3 = default(ushort);
			s_getCollisionPosition_existingOverlap = (ProfilerMarker)(long)ProfilerUnsafeUtility.CreateMarker("ExistingOverlap", categoryId3, (MarkerFlags)flags3, metadataCount3);
			s_getCollisionPosition = (ProfilerMarker)new Collider[0];
			int num5 = 0;
			int flags4 = 0;
			int metadataCount4 = 0;
			ushort categoryId4 = default(ushort);
			IntPtr intPtr3 = ProfilerUnsafeUtility.CreateMarker("AdjustCameraBasedOnAvatarDistance", categoryId4, (MarkerFlags)flags4, metadataCount4);
			int num6 = 0;
			s_adjustAvatarDistance = (ProfilerMarker)(long)intPtr3;
			int flags5 = 0;
			int metadataCount5 = 0;
			ushort categoryId5 = default(ushort);
			IntPtr intPtr4 = ProfilerUnsafeUtility.CreateMarker("UpdateNearbyCharacterVisibility", categoryId5, (MarkerFlags)flags5, metadataCount5);
			int num7 = 0;
			s_updateCharacters = (ProfilerMarker)(long)intPtr4;
			int flags6 = 0;
			int metadataCount6 = 0;
			ushort categoryId6 = default(ushort);
			IntPtr intPtr5 = ProfilerUnsafeUtility.CreateMarker("UpdateAvatarVis", categoryId6, (MarkerFlags)flags6, metadataCount6);
			int num8 = 0;
			s_updateCharacters_avatar = (ProfilerMarker)(long)intPtr5;
			int flags7 = 0;
			int metadataCount7 = 0;
			ushort categoryId7 = default(ushort);
			s_updateCharacters_npcs = (ProfilerMarker)(long)ProfilerUnsafeUtility.CreateMarker("UpdateNpcVis", categoryId7, (MarkerFlags)flags7, metadataCount7);
		}
	}
}
