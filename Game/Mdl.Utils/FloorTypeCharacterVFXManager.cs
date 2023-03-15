using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Grid;
using Mdl.Avatar;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.TextCore;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200074A")]
	public class FloorTypeCharacterVFXManager : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200074B")]
		public class VFXByGridFloorType
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002A1E")]
			public GridFloorType GridFloorType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002A1F")]
			public GameObject VFX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4002A20")]
			public float HeightOverride;

			[Cpp2IlInjected.Token(Token = "0x6002070")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public VFXByGridFloorType()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002A17")]
		[SerializeField]
		private List<VFXByGridFloorType> _vfxByGridFloorTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002A18")]
		private Dictionary<GridFloorType, VFXByGridFloorType> vfxByGridFloorTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002A19")]
		private Mdl.Environments.Environment currentEnvironment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002A1A")]
		private GridFloorType currentFloorType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002A1B")]
		private GameObject currentVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002A1C")]
		private float? currentHeightOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002A1D")]
		private PlayerAvatar avatar;

		[Cpp2IlInjected.Token(Token = "0x600206A")]
		[Cpp2IlInjected.Address(RVA = "0x1456D60", Offset = "0x1455760", VA = "0x181456D60")]
		private void Start()
		{
			//Discarded unreachable code: IL_00c5
			//IL_001e: Expected O, but got I4
			PlayerAvatar playerAvatar = (avatar = GetComponentInParent<PlayerAvatar>());
			PlayerAvatar playerAvatar2 = avatar;
			int num = 0;
			if (playerAvatar2 != (UnityEngine.Object)num)
			{
				PlayerAvatar playerAvatar3 = SystemRoot.Instance._avatar;
				PlayerAvatar.AvatarTeleported value = OnAvatarTeleported;
				playerAvatar3.OnAvatarTeleported += value;
			}
			List<VFXByGridFloorType> list = _vfxByGridFloorTypes;
			Func<VFXByGridFloorType, GridFloorType> func = default(Func<VFXByGridFloorType, GridFloorType>);
			if (_003C_003Ec._003C_003E9__8_0 == null)
			{
				func = (Func<VFXByGridFloorType, GridFloorType>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((VFXByGridFloorType x) => x.GridFloorType));
			}
			Func<VFXByGridFloorType, VFXByGridFloorType> func2 = default(Func<VFXByGridFloorType, VFXByGridFloorType>);
			if (_003C_003Ec._003C_003E9__8_1 == null)
			{
				func2 = (Func<VFXByGridFloorType, VFXByGridFloorType>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((VFXByGridFloorType x) => x));
			}
			Dictionary<VFXByGridFloorType, GridFloorType> dictionary = (Dictionary<VFXByGridFloorType, GridFloorType>)(object)(vfxByGridFloorTypes = (Dictionary<GridFloorType, VFXByGridFloorType>)(object)Enumerable.ToDictionary<VFXByGridFloorType, GridFloorType, VFXByGridFloorType>((IEnumerable<>)list, (Func<, >)(object)func, (Func<, >)(object)func2));
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneStack.CurrentSceneChanged value2 = SceneStack_OnCurrentSceneChanged;
			sceneStack.OnCurrentSceneChanged += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x600206B")]
		[Cpp2IlInjected.Address(RVA = "0x1456300", Offset = "0x1454D00", VA = "0x181456300")]
		private unsafe void LateUpdate()
		{
			//Discarded unreachable code: IL_0209
			//IL_0014: Expected O, but got I4
			//IL_0036: Expected O, but got I4
			//IL_008a: Expected O, but got I4
			//IL_00e4: Expected F4, but got I4
			//IL_0128: Expected F4, but got I4
			//IL_012f: Expected O, but got I4
			//IL_013a: Expected O, but got I4
			//IL_018b: Expected O, but got I4
			//IL_01ba: Expected O, but got F4
			//IL_01cb: Expected O, but got F4
			//IL_01df: Expected O, but got I4
			//IL_0208: Expected O, but got I4
			int num = 0;
			Mdl.Environments.Environment environment = currentEnvironment;
			int num2 = 0;
			int num3 = 0;
			if (environment != (UnityEngine.Object)num3)
			{
				Mdl.Environments.Environment environment2 = currentEnvironment;
				Transform transform = base.transform;
				int num4 = 0;
				GridScript gridScript = default(GridScript);
				if (gridScript != (UnityEngine.Object)num4 && (IntPtr)gridScript.Grid != (IntPtr)num)
				{
					Transform transform2 = base.transform;
					GridData gridData = gridScript.GridData;
					GridFloorType all = GridFloorTypeExtensions.All;
					if (currentFloorType != all)
					{
						GameObject gameObject = currentVFX;
						currentFloorType = all;
						int num5 = 0;
						if (gameObject != (UnityEngine.Object)num5)
						{
							ParticleSystem[] componentsInChildren = currentVFX.GetComponentsInChildren<ParticleSystem>();
							if (componentsInChildren.Length == num)
							{
								UnityEngine.Object.Destroy(currentVFX);
							}
							int num6 = 0;
							int length = componentsInChildren.Length;
							if (num < length)
							{
								ParticleSystem particleSystem = componentsInChildren[num];
								ParticleSystem.MainModule main = particleSystem.main;
								float num7 = Mathf.Max(((FaceInfo*)particleSystem)->scale, num6);
								ParticleSystem.MainModule main2 = particleSystem.main;
								num++;
							}
							Transform transform3 = currentVFX.transform;
							Transform transform5 = (transform3.parent = currentEnvironment.transform);
							currentVFX.AddComponent<DestroyAfterTime>().destroyAfterSeconds = num6;
							currentVFX = (GameObject)num;
						}
						int num8 = 0;
						currentHeightOverride = (float?)(object)num8;
						Dictionary<GridFloorType, VFXByGridFloorType> dictionary = vfxByGridFloorTypes;
						bool flag = default(bool);
						if (flag)
						{
							Transform parent = base.transform;
							GameObject gameObject2 = (currentVFX = UnityEngine.Object.Instantiate(gameObject, parent));
							int num9 = (int)currentFloorType;
							bool flag2 = default(bool);
							float z = default(float);
							if (flag2)
							{
								Transform waterSurface = currentEnvironment.WaterSurface;
								int num10 = 0;
								if (waterSurface != (UnityEngine.Object)num10)
								{
									Transform waterSurface2 = currentEnvironment.WaterSurface;
									Transform transform6 = waterSurface2.transform;
									z = waterSurface2.position.z;
									currentHeightOverride = (float?)(object)z;
								}
							}
							if (z != 0f)
							{
								currentHeightOverride = (float?)(object)z;
							}
						}
					}
				}
			}
			GameObject gameObject3 = currentVFX;
			int num11 = 0;
			if (gameObject3 != (UnityEngine.Object)num11)
			{
				Transform transform7 = currentVFX.transform;
				GameObject gameObject4 = currentVFX;
				int num12 = 0;
				gameObject4.transform.position = (Vector3)num12;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600206C")]
		[Cpp2IlInjected.Address(RVA = "0x1456A70", Offset = "0x1455470", VA = "0x181456A70")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0036
			//IL_0013: Expected O, but got I4
			//IL_0013: Expected O, but got I4
			if ((object)SystemRoot.Instance != null)
			{
			}
			int num = 0;
			int num2 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
			{
				PlayerAvatar playerAvatar = SystemRoot.Instance._avatar;
				PlayerAvatar.AvatarTeleported value = OnAvatarTeleported;
				playerAvatar.OnAvatarTeleported -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600206D")]
		[Cpp2IlInjected.Address(RVA = "0x1456C50", Offset = "0x1455650", VA = "0x181456C50")]
		private unsafe void SceneStack_OnCurrentSceneChanged(SceneData scene)
		{
			//Discarded unreachable code: IL_004d
			//IL_0010: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			GameObject sceneRoot = ((SceneData*)scene)->sceneRoot;
			int num = 0;
			if (sceneRoot != (UnityEngine.Object)num)
			{
				Mdl.Environments.Environment environment = (currentEnvironment = ((SceneData*)scene)->sceneRoot.GetComponent<Mdl.Environments.Environment>());
			}
			UnityEngine.Object.Destroy(currentVFX);
			int num2 = 0;
			currentVFX = (GameObject)num2;
			int num3 = 0;
			currentHeightOverride = (float?)(object)num3;
			currentFloorType = (GridFloorType)num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600206E")]
		[Cpp2IlInjected.Address(RVA = "0x14569E0", Offset = "0x14553E0", VA = "0x1814569E0")]
		private void OnAvatarTeleported(Vector3 position, PlayerAvatar.AvatarTeleportedReason reason)
		{
			//IL_0014: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			UnityEngine.Object.Destroy(currentVFX);
			int num = 0;
			currentVFX = (GameObject)num;
			int num2 = 0;
			currentHeightOverride = (float?)(object)num2;
			currentFloorType = (GridFloorType)num;
		}

		[Cpp2IlInjected.Token(Token = "0x600206F")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FloorTypeCharacterVFXManager()
		{
		}
	}
}
