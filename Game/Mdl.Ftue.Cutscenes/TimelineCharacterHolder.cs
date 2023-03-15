using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Characters;
using Mdl.Systems;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005E7")]
	public class TimelineCharacterHolder : MonoBehaviour, ITimelineCutsceneCleanUp
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023E0")]
		[SerializeField]
		public bool usePlayerAvatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x40023E1")]
		[SerializeField]
		private bool useRandomCharacter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x40023E2")]
		public bool useAquaticCharacters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40023E3")]
		[SerializeField]
		[ItemID]
		private int characterID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40023E4")]
		public bool disableHeadTracking = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40023E5")]
		public bool rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x40023E6")]
		public bool position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x40023E7")]
		public bool scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40023E8")]
		public Transform finalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40023E9")]
		public bool restoreStartPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40023EA")]
		public bool forceUseCharacterInGame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40023EB")]
		private Character character;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40023EC")]
		private GameObject charGameObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40023ED")]
		private bool charIsLoaded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40023EE")]
		private CharacterManager.CharacterInstance disableCharInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40023EF")]
		private bool animatorsDisabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x40023F0")]
		private bool headTrackingSaved;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x40023F1")]
		private bool headTrackingState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5B")]
		[Cpp2IlInjected.Token(Token = "0x40023F2")]
		private bool startPositionSaved;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40023F3")]
		private Vector3 startPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40023F4")]
		private Quaternion startRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40023F5")]
		private Vector3 startLocalScale;

		[Cpp2IlInjected.Token(Token = "0x170003C6")]
		public bool UsePlayerAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x6001A2F")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return usePlayerAvatar;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C7")]
		public bool UseRandomCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x6001A30")]
			[Cpp2IlInjected.Address(RVA = "0x63C0C0", Offset = "0x63AAC0", VA = "0x18063C0C0")]
			get
			{
				return useRandomCharacter;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A2E")]
		[Cpp2IlInjected.Address(RVA = "0x951C70", Offset = "0x950670", VA = "0x180951C70")]
		public bool CharIsLoaded()
		{
			return charIsLoaded;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A31")]
		[Cpp2IlInjected.Address(RVA = "0x13CA020", Offset = "0x13C8A20", VA = "0x1813CA020")]
		public int CharacterID()
		{
			//IL_0029: Expected O, but got I4
			if (!usePlayerAvatar)
			{
				if (!useRandomCharacter)
				{
					return characterID;
				}
				Character character = this.character;
				int num = 0;
				if (character == (UnityEngine.Object)num)
				{
					Character character2 = GetCharacter();
				}
				Character character3 = this.character;
				if ((object)character3 != null)
				{
					Item _003CItem_003Ek__BackingField = character3.Item;
				}
			}
			Item invalid = Item.Invalid;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A32")]
		[Cpp2IlInjected.Address(RVA = "0x13CACB0", Offset = "0x13C96B0", VA = "0x1813CACB0")]
		public Character GetCharacter()
		{
			//IL_0010: Expected O, but got I4
			//IL_0026: Expected O, but got I4
			//IL_0084: Expected O, but got I4
			//IL_00f7: Expected O, but got I4
			Character character = this.character;
			int num = 0;
			if (character == (UnityEngine.Object)num)
			{
				GameObject gameObject = charGameObj;
				int num2 = 0;
				if (gameObject == (UnityEngine.Object)num2)
				{
					int num3 = 0;
					if (Application.isPlaying)
					{
						if (!usePlayerAvatar)
						{
							if (!useRandomCharacter)
							{
								long num4 = Convert.ToInt64((uint)characterID);
								bool flag = default(bool);
								if (flag)
								{
									int num5 = 0;
									SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
									CharacterManager.CharacterInstance characterInstance = default(CharacterManager.CharacterInstance);
									if ((object)_003CInstance_003Ek__BackingField == null || (object)_003CInstance_003Ek__BackingField.GetSystem<CharacterManager>() == null || characterInstance != null)
									{
									}
									this.character = (Character)num5;
									Character character2 = this.character;
									GameObject _003CgameObject_003Ek__BackingField = default(GameObject);
									if ((object)character2 != null)
									{
										_003CgameObject_003Ek__BackingField = character2.gameObject;
									}
									charGameObj = _003CgameObject_003Ek__BackingField;
								}
								goto IL_00a2;
							}
							int num6 = 0;
							CharacterManager characterManager = default(CharacterManager);
							List<Character> list = (List<Character>)(object)Enumerable.ToList<Character>(characterManager.GetActiveCharacters((byte)num6 != 0));
							Func<Character, bool> func = (Func<Character, bool>)(object)(Func<T, TResult>)delegate(Character x)
							{
								//Discarded unreachable code: IL_0013, IL_0024
								NpcBodyType bodyType = x.bodyType;
								return 1L == (useAquaticCharacters ? 1 : 0);
							};
							Character character3 = (this.character = ((IEnumerable<>)Enumerable.ToList<Character>(Enumerable.Where<Character>((IEnumerable<>)list, (Func<, >)(object)func))).RandomElement<Character>());
							if ((object)this.character == null)
							{
							}
						}
						charGameObj = (GameObject)num2;
						throw new NullReferenceException();
					}
				}
			}
			goto IL_00a2;
			IL_00a2:
			return this.character;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A33")]
		[Cpp2IlInjected.Address(RVA = "0x13CA830", Offset = "0x13C9230", VA = "0x1813CA830")]
		public void EnableAnimations(bool doEnable = true)
		{
			//Discarded unreachable code: IL_0033
			Animator[] componentsInChildren = charGameObj.GetComponentsInChildren<Animator>(includeInactive: true);
			int num = 0;
			int length = componentsInChildren.Length;
			if (num < length)
			{
				componentsInChildren[num].enabled = doEnable;
				num++;
			}
			animatorsDisabled = doEnable;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A34")]
		[Cpp2IlInjected.Address(RVA = "0x13CB1B0", Offset = "0x13C9BB0", VA = "0x1813CB1B0")]
		[AsyncStateMachine(typeof(_003CSetup_003Ed__24))]
		public Task Setup()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A35")]
		[Cpp2IlInjected.Address(RVA = "0x13CA740", Offset = "0x13C9140", VA = "0x1813CA740")]
		private void DisableHeadTracking()
		{
			//Discarded unreachable code: IL_004c
			//IL_0030: Expected O, but got I4
			if (!disableHeadTracking || headTrackingSaved)
			{
				return;
			}
			headTrackingSaved = true;
			Character character = GetCharacter();
			GameObject gameObject = charGameObj;
			int num = 0;
			if (gameObject != (UnityEngine.Object)num)
			{
				GameObject gameObject2 = charGameObj;
				bool flag = default(bool);
				if (flag)
				{
					bool flag2 = default(bool);
					headTrackingState = flag2;
					int num2 = 0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A36")]
		[Cpp2IlInjected.Address(RVA = "0x13CB0E0", Offset = "0x13C9AE0", VA = "0x1813CB0E0")]
		private void RestoreHeadTracking()
		{
			//Discarded unreachable code: IL_003a
			//IL_0022: Expected O, but got I4
			if (!disableHeadTracking || !headTrackingSaved)
			{
				return;
			}
			GameObject gameObject = charGameObj;
			int num = 0;
			if (gameObject != (UnityEngine.Object)num)
			{
				GameObject gameObject2 = charGameObj;
				bool flag = default(bool);
				if (flag)
				{
					bool flag2 = headTrackingState;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A37")]
		[Cpp2IlInjected.Address(RVA = "0x13CA9D0", Offset = "0x13C93D0", VA = "0x1813CA9D0")]
		private List<Character> FilterBodyType(List<Character> characters)
		{
			Func<Character, bool> func = (Func<Character, bool>)(object)(Func<T, TResult>)delegate(Character x)
			{
				//Discarded unreachable code: IL_0013, IL_0024
				NpcBodyType bodyType = x.bodyType;
				return 1L == (useAquaticCharacters ? 1 : 0);
			};
			return (List<Character>)(object)Enumerable.ToList<Character>(Enumerable.Where<Character>((IEnumerable<>)characters, (Func<, >)(object)func));
		}

		[Cpp2IlInjected.Token(Token = "0x6001A38")]
		[Cpp2IlInjected.Address(RVA = "0x13CAA90", Offset = "0x13C9490", VA = "0x1813CAA90")]
		public Animator GetAnimator()
		{
			//IL_0010: Expected O, but got I4
			//IL_002c: Expected O, but got I4
			Character character = this.character;
			int num = 0;
			if (character == (UnityEngine.Object)num)
			{
				Character character2 = GetCharacter();
			}
			GameObject gameObject = charGameObj;
			int num2 = 0;
			if (gameObject != (UnityEngine.Object)num2)
			{
				return charGameObj.GetComponentInChildren<Animator>(includeInactive: true);
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A39")]
		[Cpp2IlInjected.Address(RVA = "0x13CAB70", Offset = "0x13C9570", VA = "0x1813CAB70")]
		[AsyncStateMachine(typeof(_003CGetCharacterForCutscene_003Ed__31))]
		private Task<CharacterManager.CharacterInstance> GetCharacterForCutscene(Item charItem)
		{
			int itemID = charItem.ItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<CharacterManager.CharacterInstance>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A3A")]
		[Cpp2IlInjected.Address(RVA = "0x13CB090", Offset = "0x13C9A90", VA = "0x1813CB090")]
		private bool IsAquaticCharacter(Character character)
		{
			//Discarded unreachable code: IL_0009, IL_0012
			NpcBodyType bodyType = character.bodyType;
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A3B")]
		[Cpp2IlInjected.Address(RVA = "0x13CB0D0", Offset = "0x13C9AD0", VA = "0x1813CB0D0")]
		private void OnDestroy()
		{
			Cleanup();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A3C")]
		[Cpp2IlInjected.Address(RVA = "0x13CA100", Offset = "0x13C8B00", VA = "0x1813CA100")]
		public unsafe void Cleanup()
		{
			//Discarded unreachable code: IL_0091, IL_0097, IL_00a9
			//IL_007f: Expected O, but got I4
			//IL_007f: Expected O, but got I4
			GameObject gameObject = default(GameObject);
			bool flag = default(bool);
			bool flag2 = default(bool);
			Vector3 vector = default(Vector3);
			Vector3 vector2 = default(Vector3);
			bool flag3 = default(bool);
			Vector3 vector3 = default(Vector3);
			bool flag4 = default(bool);
			while (true)
			{
				int num = 0;
				IEnumerator enumerator = base.transform.GetEnumerator();
				if (enumerator != null)
				{
					int num2 = 0;
					if (enumerator == null)
					{
						break;
					}
					int num3 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					UnityEngine.Object.DestroyImmediate(gameObject);
				}
				int num4 = 0;
				if ((object)gameObject == null)
				{
					continue;
				}
				if (false)
				{
					int num5 = 0;
					Task asyncTask;
					asyncTask.FireAndForgetTask();
				}
				if (flag)
				{
					if (flag2)
					{
						int num6 = 0;
						float z = vector.z;
						int num7 = 0;
						int num8 = 0;
						float z2 = vector2.z;
					}
					if (flag3)
					{
						float z3 = vector3.z;
					}
				}
				int num9 = 0;
				if (!((UnityEngine.Object)num != (UnityEngine.Object)num9) || flag4)
				{
				}
				((int*)num4)->m_value = num4;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A3D")]
		[Cpp2IlInjected.Address(RVA = "0x13CB300", Offset = "0x13C9D00", VA = "0x1813CB300")]
		public unsafe void UpdateTransform(Transform newTransform)
		{
			//Discarded unreachable code: IL_015b
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I4
			//IL_0037: Expected O, but got I4
			//IL_0077: Expected O, but got I4
			//IL_00d5: Expected native int or pointer, but got O
			//IL_0101: Expected native int or pointer, but got O
			int num = 0;
			if (newTransform == (UnityEngine.Object)num)
			{
				return;
			}
			GameObject gameObject = charGameObj;
			int num2 = 0;
			if (gameObject == (UnityEngine.Object)num2)
			{
				return;
			}
			Character character = this.character;
			int num3 = 0;
			if (character == (UnityEngine.Object)num3)
			{
				Character character2 = GetCharacter();
			}
			if (disableHeadTracking && !headTrackingSaved)
			{
				headTrackingSaved = true;
				Character character3 = GetCharacter();
				GameObject gameObject2 = charGameObj;
				int num4 = 0;
				if (gameObject2 != (UnityEngine.Object)num4)
				{
					GameObject gameObject3 = charGameObj;
					bool flag = default(bool);
					if (flag)
					{
						bool flag2 = default(bool);
						headTrackingState = flag2;
						int num5 = 0;
					}
				}
			}
			if (restoreStartPosition && !startPositionSaved)
			{
				GameObject gameObject4 = charGameObj;
				startPositionSaved = true;
				Transform transform = gameObject4.transform;
				GameObject gameObject5 = charGameObj;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				((Vector3*)(IntPtr)startPosition)->z = z;
				Transform transform2 = gameObject5.transform;
				Transform transform3 = charGameObj.transform;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				((Vector3*)(IntPtr)startLocalScale)->z = z2;
			}
			if (position)
			{
				Transform transform4 = charGameObj.transform;
				Vector3 vector3 = default(Vector3);
				float z3 = vector3.z;
			}
			if (rotation)
			{
				Transform transform5 = charGameObj.transform;
			}
			if (scale)
			{
				Transform transform6 = charGameObj.transform;
				Vector3 vector4 = default(Vector3);
				float z4 = vector4.z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A3E")]
		[Cpp2IlInjected.Address(RVA = "0x13CA8F0", Offset = "0x13C92F0", VA = "0x1813CA8F0", Slot = "4")]
		public void EndCutsceneCleanup()
		{
			//Discarded unreachable code: IL_004a
			int num = 0;
			if (!Application.isPlaying)
			{
				return;
			}
			if (!usePlayerAvatar)
			{
				GetCharacter()?.AnimatorComponent?.SetTrigger("Locomotion");
				return;
			}
			int num2 = 0;
			Animator animator = default(Animator);
			while ((object)animator == null)
			{
			}
			animator.SetTrigger("ExitCutscene");
		}

		[Cpp2IlInjected.Token(Token = "0x6001A3F")]
		[Cpp2IlInjected.Address(RVA = "0x13CB6A0", Offset = "0x13CA0A0", VA = "0x1813CB6A0")]
		public TimelineCharacterHolder()
		{
		}
	}
}
