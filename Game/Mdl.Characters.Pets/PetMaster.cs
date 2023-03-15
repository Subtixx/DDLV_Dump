using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Characters.Pets
{
	[Cpp2IlInjected.Token(Token = "0x20008C1")]
	public class PetMaster : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003108")]
		private bool updatePet = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003109")]
		private (Vector3 position, Quaternion rotation)? lockedTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400310A")]
		private CurseSystem curseSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400310B")]
		private bool wasLimboActive;

		[Cpp2IlInjected.Token(Token = "0x170005ED")]
		public Pet Pet
		{
			[Cpp2IlInjected.Token(Token = "0x6002876")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CPet_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002877")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			private set
			{
				_003CPet_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005EE")]
		private CurseSystem CurseSystem
		{
			[Cpp2IlInjected.Token(Token = "0x6002881")]
			[Cpp2IlInjected.Address(RVA = "0xF0F430", Offset = "0xF0DE30", VA = "0x180F0F430")]
			get
			{
				//Discarded unreachable code: IL_002c
				//IL_0010: Expected O, but got I4
				CurseSystem curseSystem = this.curseSystem;
				int num = 0;
				if (curseSystem == (UnityEngine.Object)num)
				{
					CurseSystem curseSystem2 = (this.curseSystem = SystemRoot.Instance.GetSystem<CurseSystem>());
				}
				return this.curseSystem;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002878")]
		[Cpp2IlInjected.Address(RVA = "0xF0EC00", Offset = "0xF0D600", VA = "0x180F0EC00")]
		public void SetPet(string petAddress, Transform parent)
		{
			//Discarded unreachable code: IL_0027
			SetPetAsync().FireAndForgetTask();
			[Cpp2IlInjected.Token(Token = "0x6002885")]
			[Cpp2IlInjected.Address(RVA = "0x12170F0", Offset = "0x1215AF0", VA = "0x1812170F0")]
			[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass6_0._003C_003CSetPet_003Eg__SetPetAsync_007C0_003Ed))]
			Task SetPetAsync()
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002879")]
		[Cpp2IlInjected.Address(RVA = "0xF0E7C0", Offset = "0xF0D1C0", VA = "0x180F0E7C0")]
		public void LockPet(Vector3 position, Quaternion rotation)
		{
			//Discarded unreachable code: IL_0099
			//IL_0017: Expected O, but got I4
			//IL_0020: Expected O, but got I4
			//IL_0048: Expected O, but got I4
			//IL_005a: Expected O, but got I4
			updatePet = false;
			int num = 0;
			Pet pet = Pet;
			lockedTransform = ((Vector3 position, Quaternion rotation)?)(object)num;
			int num2 = 0;
			if (pet != (UnityEngine.Object)num2 && Pet.isActiveAndEnabled)
			{
				Pet pet2 = Pet;
				int num3 = 0;
				pet2.transform.rotation = (Quaternion)num3;
				bool flag = Pet.Agent.Warp((Vector3)num3);
				Pet pet3 = Pet;
				NavMeshAgent _003CAgent_003Ek__BackingField = pet3.Agent;
				int num4 = ((_003CAgent_003Ek__BackingField.enabled = false) ? 1 : 0);
				pet3.Agent.isStopped = true;
				IMotivation freeTime = pet3.freeTime;
				GameObject gameObject = pet3.gameObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600287A")]
		[Cpp2IlInjected.Address(RVA = "0xF0F0B0", Offset = "0xF0DAB0", VA = "0x180F0F0B0")]
		public void UnlockedPet()
		{
			//Discarded unreachable code: IL_0069
			//IL_0010: Expected O, but got I4
			//IL_0020: Expected O, but got I4
			updatePet = true;
			int num = 0;
			lockedTransform = ((Vector3 position, Quaternion rotation)?)(object)num;
			Pet pet = Pet;
			int num2 = 0;
			if (pet != (UnityEngine.Object)num2 && Pet.isActiveAndEnabled)
			{
				Pet pet2 = Pet;
				pet2.Agent.enabled = true;
				NavMeshAgent _003CAgent_003Ek__BackingField = pet2.Agent;
				int num3 = ((_003CAgent_003Ek__BackingField.isStopped = false) ? 1 : 0);
				IMotivation freeTime = pet2.freeTime;
				GameObject gameObject = pet2.gameObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600287B")]
		[Cpp2IlInjected.Address(RVA = "0xF0E300", Offset = "0xF0CD00", VA = "0x180F0E300")]
		public void LoadPet()
		{
			//Discarded unreachable code: IL_0090
			//IL_007a: Expected O, but got I4
			long num = Convert.ToInt64((uint)SystemRoot.Instance.MetaClient.profile.player_.currentPet_);
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			PetItemData petItemData = default(PetItemData);
			if (petItemData != null)
			{
			}
			int num2 = 0;
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			if (_003C_003Ec._003C_003E9__9_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((SceneData x) => (long)"{il2cpp field on {'constant1' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x40}" == 1);
			}
			GameObject gameObject = default(GameObject);
			Transform transform = gameObject.transform;
			string petAddress = (string)num2;
			Transform parent = transform;
			SetPetAsync().FireAndForgetTask();
			[Cpp2IlInjected.Token(Token = "0x6002885")]
			[Cpp2IlInjected.Address(RVA = "0x12170F0", Offset = "0x1215AF0", VA = "0x1812170F0")]
			[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass6_0._003C_003CSetPet_003Eg__SetPetAsync_007C0_003Ed))]
			Task SetPetAsync()
			{
				int num3 = 0;
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600287C")]
		[Cpp2IlInjected.Address(RVA = "0xF0E260", Offset = "0xF0CC60", VA = "0x180F0E260")]
		private void ActivatePet(bool value)
		{
			//Discarded unreachable code: IL_0025
			//IL_0010: Expected O, but got I4
			Pet pet = Pet;
			int num = 0;
			if (pet != (UnityEngine.Object)num)
			{
				Pet.gameObject.SetActive(value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600287D")]
		[Cpp2IlInjected.Address(RVA = "0xF0EBF0", Offset = "0xF0D5F0", VA = "0x180F0EBF0")]
		private void OnEnable()
		{
			ActivatePet(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600287E")]
		[Cpp2IlInjected.Address(RVA = "0xF0EBE0", Offset = "0xF0D5E0", VA = "0x180F0EBE0")]
		private void OnDisable()
		{
			int value = 0;
			ActivatePet((byte)value != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600287F")]
		[Cpp2IlInjected.Address(RVA = "0xF0EA00", Offset = "0xF0D400", VA = "0x180F0EA00")]
		private void OnAvatarTeleported(Vector3 position, PlayerAvatar.AvatarTeleportedReason reason)
		{
			//Discarded unreachable code: IL_006c
			//IL_001b: Expected O, but got I4
			PlayerAvatar avatar = SystemRoot.Instance._avatar;
			Pet pet = Pet;
			int num = 0;
			if (pet != (UnityEngine.Object)num)
			{
				Pet pet2 = Pet;
				if (!TeleportPetToMaster(avatar.gameObject, pet2))
				{
					string text = Pet.gameObject.name;
					string text2 = base.gameObject.name;
					Debug.LogWarning("Failed to teleport pet (" + text + ") to master " + text2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002880")]
		[Cpp2IlInjected.Address(RVA = "0xF0ECE0", Offset = "0xF0D6E0", VA = "0x180F0ECE0")]
		private static bool TeleportPetToMaster(GameObject petMaster, Pet pet)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002882")]
		[Cpp2IlInjected.Address(RVA = "0xF0F1C0", Offset = "0xF0DBC0", VA = "0x180F0F1C0")]
		private void Update()
		{
			//Discarded unreachable code: IL_00ad
			//IL_0010: Expected O, but got I4
			//IL_005c: Expected O, but got I4
			CurseSystem curseSystem3;
			do
			{
				CurseSystem curseSystem = this.curseSystem;
				int num = 0;
				if (curseSystem == (UnityEngine.Object)num)
				{
					CurseSystem curseSystem2 = (this.curseSystem = SystemRoot.Instance.GetSystem<CurseSystem>());
				}
				curseSystem3 = this.curseSystem;
			}
			while ((object)curseSystem3 == null);
			bool flag = curseSystem3.isLimboActive;
			if (wasLimboActive == flag)
			{
				Pet pet = Pet;
				int num2 = 0;
				if (pet != (UnityEngine.Object)num2 && Pet.isActiveAndEnabled && updatePet)
				{
					Pet pet2 = Pet;
					int num3 = 0;
					float deltaTime = Time.deltaTime;
					if (!pet2.interactingWithAvatar)
					{
						IMotivation freeTime = pet2.freeTime;
						GameObject gameObject = pet2.gameObject;
					}
				}
			}
			else
			{
				GameObject gameObject = default(GameObject);
				bool flag2 = (object)gameObject == null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002883")]
		[Cpp2IlInjected.Address(RVA = "0xF0F420", Offset = "0xF0DE20", VA = "0x180F0F420")]
		public PetMaster()
		{
		}
	}
}
