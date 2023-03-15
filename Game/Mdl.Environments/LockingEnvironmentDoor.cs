using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Navigation;
using Mdl.Utils;
using NodeCanvas.DialogueTrees;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000655")]
	public abstract class LockingEnvironmentDoor : EnvironmentDoor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40025B7")]
		[SerializeField]
		internal GameObject _lockedPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40025B8")]
		internal GameObject lockedVFXInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40025B9")]
		[SerializeField]
		internal GameObject _lockedGlowVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40025BA")]
		internal GameObject lockedGlowVFXInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40025BB")]
		[SerializeField]
		internal string _lockedPrefabOutBool = "out";

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40025BC")]
		[SerializeField]
		internal GameObject _unlockedPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40025BD")]
		internal GameObject unlockedVFXInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40025BE")]
		[SerializeField]
		internal AK.Wwise.Event _lockRemovedSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40025BF")]
		[SerializeField]
		internal AK.Wwise.Event _lockRemovedMusic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40025C0")]
		[SerializeField]
		internal DialogueTree _dialogue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40025C1")]
		[SerializeField]
		[ItemID]
		internal int _employeeCharacter;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40025C2")]
		[SerializeField]
		private Transform _avatarPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40025C3")]
		[SerializeField]
		internal Transform _employeePosition;

		[Cpp2IlInjected.Token(Token = "0x170003F7")]
		public DialogueTree UnlockDialogue
		{
			[Cpp2IlInjected.Token(Token = "0x6001C42")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			get
			{
				return _dialogue;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F8")]
		public Item EmployeeCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x6001C43")]
			[Cpp2IlInjected.Address(RVA = "0xBB9F50", Offset = "0xBB8950", VA = "0x180BB9F50")]
			get
			{
				long num = Convert.ToInt64((uint)_employeeCharacter);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F9")]
		public Vector3 EmployeePosition
		{
			[Cpp2IlInjected.Token(Token = "0x6001C44")]
			[Cpp2IlInjected.Address(RVA = "0xBB9FB0", Offset = "0xBB89B0", VA = "0x180BB9FB0")]
			get
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FA")]
		public Vector3 AvatarPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6001C45")]
			[Cpp2IlInjected.Address(RVA = "0xBB9E90", Offset = "0xBB8890", VA = "0x180BB9E90")]
			get
			{
				int num = 0;
				bool flag = default(bool);
				if (flag)
				{
					Vector3 vector = default(Vector3);
					float z = vector.z;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C46")]
		[Cpp2IlInjected.Address(RVA = "0xBB9AB0", Offset = "0xBB84B0", VA = "0x180BB9AB0")]
		internal void ShowVFX(bool showLockedVFX, bool showUnlockedVFX)
		{
			//Discarded unreachable code: IL_012e
			//IL_0014: Expected O, but got I4
			//IL_0036: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			//IL_008c: Expected O, but got I4
			//IL_00ca: Expected O, but got I4
			//IL_00d9: Expected O, but got I4
			//IL_00f0: Expected O, but got I4
			//IL_012a: Expected O, but got I4
			GameObject gameObject = lockedVFXInstance;
			if (!showLockedVFX)
			{
				int num = 0;
				if (!(gameObject != (UnityEngine.Object)num))
				{
					goto IL_00b2;
				}
				GameObject thorns = lockedVFXInstance;
				RemoveThorns(thorns).FireAndForgetTask();
			}
			int num2 = 0;
			if (gameObject == (UnityEngine.Object)num2)
			{
				GameObject lockedPrefab = _lockedPrefab;
				Transform destination = GetComponent<PlayerTaskCollider>().Destination;
				GameObject gameObject2 = (lockedVFXInstance = UnityEngine.Object.Instantiate(lockedPrefab, destination));
			}
			GameObject gameObject3 = lockedGlowVFXInstance;
			int num3 = 0;
			if (gameObject3 == (UnityEngine.Object)num3)
			{
				GameObject lockedGlowVFXPrefab = _lockedGlowVFXPrefab;
				int num4 = 0;
				if (lockedGlowVFXPrefab != (UnityEngine.Object)num4)
				{
					GameObject lockedGlowVFXPrefab2 = _lockedGlowVFXPrefab;
					Transform parent = base.transform;
					GameObject gameObject4 = (lockedGlowVFXInstance = UnityEngine.Object.Instantiate(lockedGlowVFXPrefab2, parent));
				}
			}
			goto IL_00b2;
			IL_00b2:
			GameObject gameObject5 = unlockedVFXInstance;
			if (!showUnlockedVFX)
			{
				int num5 = 0;
				if (!(gameObject5 != (UnityEngine.Object)num5))
				{
					return;
				}
			}
			int num6 = 0;
			if (gameObject5 == (UnityEngine.Object)num6)
			{
				GameObject unlockedPrefab = _unlockedPrefab;
				int num7 = 0;
				if (unlockedPrefab != (UnityEngine.Object)num7)
				{
					GameObject unlockedPrefab2 = _unlockedPrefab;
					Transform parent2 = base.transform;
					GameObject gameObject6 = (unlockedVFXInstance = UnityEngine.Object.Instantiate(unlockedPrefab2, parent2));
				}
			}
			GameObject gameObject7 = lockedGlowVFXInstance;
			int num8 = 0;
			if (!(gameObject7 != (UnityEngine.Object)num8))
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C47")]
		[Cpp2IlInjected.Address(RVA = "0xBB9990", Offset = "0xBB8390", VA = "0x180BB9990")]
		private void RemoveVFX(ref GameObject vfx)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			Animator animator = default(Animator);
			if (!(animator != (UnityEngine.Object)num))
			{
			}
			string lockedPrefabOutBool = _lockedPrefabOutBool;
			animator.SetBool(lockedPrefabOutBool, value: true);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C48")]
		[Cpp2IlInjected.Address(RVA = "0xBB9870", Offset = "0xBB8270", VA = "0x180BB9870", Slot = "11")]
		[AsyncStateMachine(typeof(_003CRemoveThorns_003Ed__23))]
		protected virtual Task RemoveThorns(GameObject thorns)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C49")]
		[Cpp2IlInjected.Address(RVA = "0xBB9E40", Offset = "0xBB8840", VA = "0x180BB9E40")]
		protected LockingEnvironmentDoor()
		{
		}
	}
}
