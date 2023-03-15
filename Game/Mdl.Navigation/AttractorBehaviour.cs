using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C1B")]
	public class AttractorBehaviour : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004383")]
		private List<Character> characters = (List<Character>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004384")]
		private Coroutine periodicAttractCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4004385")]
		private PlayerAvatar cachedAvatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4004386")]
		private List<Character> trackedCharacters = (List<Character>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4004387")]
		[SerializeField]
		private AttractorConfig config;

		[Cpp2IlInjected.Token(Token = "0x6003710")]
		[Cpp2IlInjected.Address(RVA = "0xA46D70", Offset = "0xA45770", VA = "0x180A46D70")]
		[Conditional("DEBUG_ATTRACTOR")]
		private void DebugLog(string message)
		{
			//Discarded unreachable code: IL_0023
			string text = base.gameObject.name;
			UnityEngine.Debug.LogWarning("AttractorBehaviour-" + text + ": " + message);
		}

		[Cpp2IlInjected.Token(Token = "0x6003711")]
		[Cpp2IlInjected.Address(RVA = "0xA46CB0", Offset = "0xA456B0", VA = "0x180A46CB0")]
		private void Awake()
		{
			//IL_0010: Expected O, but got I4
			//IL_002d: Expected I4, but got I8
			AttractorConfig attractorConfig = config;
			int num = 0;
			if (attractorConfig == (UnityEngine.Object)num)
			{
				AttractorConfig attractorConfig2 = new AttractorConfig();
				attractorConfig2.maxRange = 3000f;
				attractorConfig2.maxCharacters = 1;
				attractorConfig2.periodicCheckInterval = 1f;
				config = attractorConfig2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003712")]
		[Cpp2IlInjected.Address(RVA = "0xA46E40", Offset = "0xA45840", VA = "0x180A46E40")]
		[Conditional("DEBUG_ATTRACTOR")]
		private unsafe void OnDrawGizmos()
		{
			//IL_0012: Expected O, but got I4
			int num = 0;
			PlayerAvatar playerAvatar = cachedAvatar;
			int num2 = 0;
			if (playerAvatar != (UnityEngine.Object)num2)
			{
				bool flag = ColorUtility.TryParseHtmlString("#FFA500", out *(Color*)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003713")]
		[Cpp2IlInjected.Address(RVA = "0xA46ED0", Offset = "0xA458D0", VA = "0x180A46ED0")]
		private void OnTriggerEnter(Collider other)
		{
			//Discarded unreachable code: IL_0076
			//IL_0015: Expected O, but got I4
			//IL_002d: Expected O, but got I4
			Character componentInParent = other.gameObject.GetComponentInParent<Character>();
			int num = 0;
			if (!(componentInParent != (UnityEngine.Object)num))
			{
				PlayerAvatar componentInParent2 = other.gameObject.GetComponentInParent<PlayerAvatar>();
				int num2 = 0;
				if (!(componentInParent2 == (UnityEngine.Object)num2))
				{
					cachedAvatar = componentInParent2;
					if ((long)periodicAttractCoroutine == 0)
					{
						int _003C_003E1__state = default(int);
						_003CPeriodicAttractCharacters_003Ed__9 _003CPeriodicAttractCharacters_003Ed__ = new _003CPeriodicAttractCharacters_003Ed__9(_003C_003E1__state);
						_003C_003E1__state = 0;
						_003CPeriodicAttractCharacters_003Ed__._003C_003E4__this = this;
						Coroutine coroutine = (periodicAttractCoroutine = StartCoroutine(_003CPeriodicAttractCharacters_003Ed__));
					}
				}
			}
			else
			{
				((List<T>)(object)trackedCharacters).Add((T)componentInParent);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003714")]
		[Cpp2IlInjected.Address(RVA = "0xA47230", Offset = "0xA45C30", VA = "0x180A47230")]
		[IteratorStateMachine(typeof(_003CPeriodicAttractCharacters_003Ed__9))]
		private IEnumerator PeriodicAttractCharacters()
		{
			int _003C_003E1__state = default(int);
			_003CPeriodicAttractCharacters_003Ed__9 _003CPeriodicAttractCharacters_003Ed__ = new _003CPeriodicAttractCharacters_003Ed__9(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPeriodicAttractCharacters_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003715")]
		[Cpp2IlInjected.Address(RVA = "0xA473D0", Offset = "0xA45DD0", VA = "0x180A473D0")]
		private void SetAttractionForCharacters(PlayerAvatar avatar)
		{
			//Discarded unreachable code: IL_00e8, IL_00ee, IL_00f4, IL_00fa
			int num = 0;
			CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
			float maxRangeSq = config.maxRange;
			int num2 = 0;
			IEnumerable<Character> activeCharacters = (IEnumerable<Character>)system.GetActiveCharacters((byte)num2 != 0);
			List<Character> list = trackedCharacters;
			IEnumerable<Character> enumerable = (IEnumerable<Character>)Enumerable.Distinct<Character>(Enumerable.Concat<Character>((IEnumerable<>)activeCharacters, (IEnumerable<>)list));
			Func<Character, bool> func = (Func<Character, bool>)(object)(Func<T, TResult>)((Character x) => ShouldCharacterBeAttracted(x));
			IEnumerable<Character> enumerable2 = (IEnumerable<Character>)Enumerable.Where<Character>((IEnumerable<>)enumerable, (Func<, >)(object)func);
			Func<Character, bool> func2 = (Func<Character, bool>)(object)(Func<T, TResult>)delegate(Character x)
			{
				Transform transform2 = x.gameObject.transform;
				PlayerAvatar playerAvatar2 = avatar;
				Vector3 vector3 = default(Vector3);
				float z3 = vector3.z;
				Transform _003Ctransform_003Ek__BackingField2 = playerAvatar2.transform;
				Vector3 vector4 = default(Vector3);
				float z4 = vector4.z;
				float num4 = maxRangeSq;
				throw new NullReferenceException();
			};
			IEnumerable<Character> enumerable3 = (IEnumerable<Character>)Enumerable.Where<Character>((IEnumerable<>)enumerable2, (Func<, >)(object)func2);
			Func<Character, float> func3 = (Func<Character, float>)(object)(Func<T, TResult>)delegate(Character x)
			{
				//Discarded unreachable code: IL_002e
				Transform transform = x.gameObject.transform;
				PlayerAvatar playerAvatar = avatar;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Transform _003Ctransform_003Ek__BackingField = playerAvatar.transform;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				float result = default(float);
				return result;
			};
			IOrderedEnumerable<Character> orderedEnumerable = (IOrderedEnumerable<Character>)Enumerable.OrderBy<Character, float>((IEnumerable<>)enumerable3, (Func<, >)(object)func3);
			int maxCharacters = config.maxCharacters;
			IEnumerable<Character> enumerable4 = (IEnumerable<Character>)Enumerable.Take<Character>((IEnumerable<>)orderedEnumerable, maxCharacters);
			if (enumerable4 != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					if (num == (int)num3)
					{
						goto IL_00db;
					}
					num++;
				}
				List<Character> list2 = characters;
				goto IL_00db;
			}
			goto IL_00e2;
			IL_00e2:
			if (enumerable4 == null)
			{
			}
			return;
			IL_00db:
			enumerable4 = (IEnumerable<Character>)(object)((object)enumerable4 + (object)enumerable4);
			goto IL_00e2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003716")]
		[Cpp2IlInjected.Address(RVA = "0xA470A0", Offset = "0xA45AA0", VA = "0x180A470A0")]
		private void OnTriggerExit(Collider other)
		{
			//Discarded unreachable code: IL_006e
			//IL_0015: Expected O, but got I4
			//IL_002d: Expected O, but got I4
			//IL_0050: Expected O, but got I4
			//IL_005e: Expected O, but got I4
			Character componentInParent = other.gameObject.GetComponentInParent<Character>();
			int num = 0;
			if (!(componentInParent != (UnityEngine.Object)num))
			{
				PlayerAvatar componentInParent2 = other.gameObject.GetComponentInParent<PlayerAvatar>();
				int num2 = 0;
				if (!(componentInParent2 == (UnityEngine.Object)num2))
				{
					Coroutine coroutine = periodicAttractCoroutine;
					int num3 = 0;
					if (coroutine != null)
					{
						StopCoroutine(coroutine);
						periodicAttractCoroutine = (Coroutine)num3;
					}
					RemoveAttractionFromCharacters();
					cachedAvatar = (PlayerAvatar)num3;
				}
			}
			else
			{
				bool flag = ((List<T>)(object)trackedCharacters).Remove((T)componentInParent);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003717")]
		[Cpp2IlInjected.Address(RVA = "0xA46E30", Offset = "0xA45830", VA = "0x180A46E30")]
		private void OnDisable()
		{
			RemoveAttractionFromCharacters();
		}

		[Cpp2IlInjected.Token(Token = "0x6003718")]
		[Cpp2IlInjected.Address(RVA = "0xA472A0", Offset = "0xA45CA0", VA = "0x180A472A0")]
		private void RemoveAttractionFromCharacters()
		{
			//Discarded unreachable code: IL_000c, IL_0012, IL_0018
			List<Character> list = characters;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003719")]
		[Cpp2IlInjected.Address(RVA = "0xA47840", Offset = "0xA46240", VA = "0x180A47840")]
		private bool ShouldCharacterBeAttracted(Character character)
		{
			if (!character.IsAttracted && CharacterAttractedToAvatarState.CanEverBeAttractedToAvatar(character))
			{
				return !character.TraversingLink;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600371A")]
		[Cpp2IlInjected.Address(RVA = "0xA47890", Offset = "0xA46290", VA = "0x180A47890")]
		public AttractorBehaviour()
		{
		}
	}
}
