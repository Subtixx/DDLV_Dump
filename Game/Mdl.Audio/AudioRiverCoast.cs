using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using Mdl.Avatar;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000B0F")]
	public class AudioRiverCoast : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4003D81")]
		private const int CHECK_INTERVAL = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003D82")]
		public List<GameObject> Paths = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003D83")]
		private Mdl.Environments.Environment environment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003D84")]
		private VillageAreaType curAreaType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003D85")]
		private Transform avatarTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003D86")]
		private bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x60032FC")]
		[Cpp2IlInjected.Address(RVA = "0x1509320", Offset = "0x1507D20", VA = "0x181509320")]
		public void OnEnable()
		{
			isEnabled = true;
			ActivateEmitters();
		}

		[Cpp2IlInjected.Token(Token = "0x60032FD")]
		[Cpp2IlInjected.Address(RVA = "0x1509310", Offset = "0x1507D10", VA = "0x181509310")]
		public void OnDisable()
		{
			isEnabled = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60032FE")]
		[Cpp2IlInjected.Address(RVA = "0x1508E80", Offset = "0x1507880", VA = "0x181508E80")]
		public void CheckPlayerVillageArea()
		{
			//IL_0012: Expected O, but got I4
			//IL_006a: Expected O, but got I4
			//IL_0081: Expected O, but got I4
			//IL_00ba: Expected O, but got I4
			//IL_00ba: Expected O, but got I4
			//IL_00fe: Expected O, but got I4
			//IL_014b: Expected O, but got I4
			//IL_014b: Expected O, but got I4
			//IL_0157: Expected O, but got I8
			SceneData sceneData = default(SceneData);
			GameObject gameObject = default(GameObject);
			Vector3 vector = default(Vector3);
			GridScript gridScript = default(GridScript);
			PlayerAvatar avatar = default(PlayerAvatar);
			Vector3 vector2 = default(Vector3);
			GridScript gridScript2 = default(GridScript);
			while (true)
			{
				int num = 0;
				Mdl.Environments.Environment environment = this.environment;
				int num2 = 0;
				if (environment == (UnityEngine.Object)num2)
				{
					SceneStack sceneStack = SystemRoot.Instance._sceneStack;
					AsyncOperation operation = sceneData.sceneInstance.m_Operation;
					CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
					SceneItemData sceneItemData = sceneData.sceneItemData;
					if ((object)gameObject != null)
					{
						Mdl.Environments.Environment component = gameObject.GetComponent<Mdl.Environments.Environment>();
					}
					this.environment = (Mdl.Environments.Environment)(object)gameObject;
					Mdl.Environments.Environment environment2 = this.environment;
					int num3 = 0;
					if (environment2 == (UnityEngine.Object)num3)
					{
						return;
					}
				}
				Transform transform = avatarTransform;
				int num4 = 0;
				if (!(transform == (UnityEngine.Object)num4))
				{
					Transform transform2 = avatarTransform;
					Mdl.Environments.Environment environment3 = this.environment;
					float z = vector.z;
					if ((object)gridScript != null)
					{
						VillageArea component2 = gridScript.GetComponent<VillageArea>();
					}
					int num5 = 0;
					int num6 = 0;
					bool flag = (UnityEngine.Object)num5 == (UnityEngine.Object)num6;
					if (flag)
					{
						break;
					}
					if (curAreaType != (flag ? VillageAreaType.Wetland : VillageAreaType.Beach))
					{
						curAreaType = (flag ? VillageAreaType.Wetland : VillageAreaType.Beach);
						ActivateEmitters();
					}
					return;
				}
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField != null)
				{
					avatar = _003CInstance_003Ek__BackingField._avatar;
				}
				int num7 = 0;
				if (!(avatar == (UnityEngine.Object)num7))
				{
					Transform transform3 = (avatarTransform = avatar.transform);
					Transform transform4 = avatarTransform;
					Mdl.Environments.Environment environment4 = this.environment;
					float z2 = vector2.z;
					if ((object)gridScript2 != null)
					{
						VillageArea component3 = gridScript2.GetComponent<VillageArea>();
					}
					int num8 = 0;
					int num9 = 0;
					if ((UnityEngine.Object)num8 == (UnityEngine.Object)num9)
					{
					}
					break;
				}
			}
			avatarTransform = (Transform)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60032FF")]
		[Cpp2IlInjected.Address(RVA = "0x1508CB0", Offset = "0x15076B0", VA = "0x181508CB0")]
		private void ActivateEmitters()
		{
			//Discarded unreachable code: IL_0052, IL_0058
			//IL_0027: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			AudioRiverCoastPath audioRiverCoastPath = default(AudioRiverCoastPath);
			while (true)
			{
				int num = 0;
				if ((isEnabled ? 1 : 0) == num)
				{
					break;
				}
				List<GameObject> paths = Paths;
				if (!flag)
				{
					break;
				}
				while (flag2)
				{
				}
				int num2 = 0;
				if (!(audioRiverCoastPath == (UnityEngine.Object)num2))
				{
					if (audioRiverCoastPath.areaType != curAreaType)
					{
						audioRiverCoastPath.StopEmitter();
					}
					Transform targetTransform = avatarTransform;
					audioRiverCoastPath.ActivateEmitter(targetTransform);
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003300")]
		[Cpp2IlInjected.Address(RVA = "0x1509380", Offset = "0x1507D80", VA = "0x181509380")]
		public AudioRiverCoast()
		{
		}
	}
}
