using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Characters;
using Mdl.Systems;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

namespace Mdl.Utils.EQ
{
	[Cpp2IlInjected.Token(Token = "0x20007E6")]
	internal class TestAvoidCharacterByProximity : EnvironmentQuery.Test
	{
		[Cpp2IlInjected.Token(Token = "0x4002C34")]
		private static readonly ProfilerMarker s_Test_AvoidCharacter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002C35")]
		public float Proximity = 1f;

		[Cpp2IlInjected.Token(Token = "0x170004DF")]
		public override float Cost
		{
			[Cpp2IlInjected.Token(Token = "0x60022FC")]
			[Cpp2IlInjected.Address(RVA = "0xA640C0", Offset = "0xA62AC0", VA = "0x180A640C0", Slot = "4")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022FD")]
		[Cpp2IlInjected.Address(RVA = "0x1071A50", Offset = "0x1070450", VA = "0x181071A50", Slot = "6")]
		protected unsafe override (bool, float) FilterAndScore(GameObject queryObject, Vector3 queryPosition, Vector3 position)
		{
			//Discarded unreachable code: IL_0059, IL_005f
			//IL_0050: Expected F4, but got I4
			//IL_0051: Invalid comparison between F4 and I4
			int num2;
			NonAllocSelectEnumerator<CharacterManager.CharacterInstance, Character, NonAllocWhereEnumerator<CharacterManager.CharacterInstance, List<CharacterManager.CharacterInstance>.Enumerator>> nonAllocSelectEnumerator = default(NonAllocSelectEnumerator<CharacterManager.CharacterInstance, Character, NonAllocWhereEnumerator<CharacterManager.CharacterInstance, List<CharacterManager.CharacterInstance>.Enumerator>>);
			bool flag = default(bool);
			Character character = default(Character);
			Vector3 vector = default(Vector3);
			float proximity;
			float value;
			int num3;
			do
			{
				int num = 0;
				CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
				num2 = 0;
				Func<, > func = (Func<, >)(object)((NonAllocSelectEnumerator<, , >*)(&nonAllocSelectEnumerator))->func;
				if (!flag)
				{
					break;
				}
				Transform _003Ctransform_003Ek__BackingField = character.transform;
				float z = vector.z;
				float z2 = position.z;
				proximity = Proximity;
				value = proximity;
				num3 = 0;
			}
			while (Mathf.Clamp(value, num3, proximity) <= (float)num2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60022FE")]
		[Cpp2IlInjected.Address(RVA = "0x1071DB0", Offset = "0x10707B0", VA = "0x181071DB0")]
		public TestAvoidCharacterByProximity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60022FF")]
		[Cpp2IlInjected.Address(RVA = "0x1071D30", Offset = "0x1070730", VA = "0x181071D30")]
		static TestAvoidCharacterByProximity()
		{
			//IL_001a: Expected O, but got I
			int num = 0;
			int flags = 0;
			int metadataCount = 0;
			ushort categoryId = default(ushort);
			s_Test_AvoidCharacter = (ProfilerMarker)(long)ProfilerUnsafeUtility.CreateMarker("FilterAndScore.NpcProximity", categoryId, (MarkerFlags)flags, metadataCount);
		}
	}
}
