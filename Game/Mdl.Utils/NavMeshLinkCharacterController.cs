using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Characters;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200078C")]
	internal class NavMeshLinkCharacterController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002B3A")]
		[SerializeField]
		private float duration = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002B3B")]
		[SerializeField]
		private bool IsWaterLink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002B3C")]
		[SerializeField]
		private string inAnimTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002B3D")]
		[SerializeField]
		private bool HideCharacterDuringTraversal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4002B3E")]
		[SerializeField]
		private float animationTimeoutInSeconds = 3f;

		[Cpp2IlInjected.Token(Token = "0x4002B3F")]
		private const int INVALID_INDEX = -1;

		[Cpp2IlInjected.Token(Token = "0x600218D")]
		[Cpp2IlInjected.Address(RVA = "0xF03040", Offset = "0xF01A40", VA = "0x180F03040")]
		[AsyncStateMachine(typeof(_003CTraverseLink_003Ed__5))]
		public Task TraverseLink(Character character)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600218E")]
		[Cpp2IlInjected.Address(RVA = "0xF02F30", Offset = "0xF01930", VA = "0x180F02F30")]
		private static bool IsCharacterAttemptingToTraverseLink(Character character, OffMeshLinkData linkData)
		{
			if (character.NavMeshAgentComponent.hasPath)
			{
				Vector3[] corners = character.NavMeshAgentComponent.path.corners;
				int num = 0;
				int length = corners.Length;
				if (num < length)
				{
					float z = linkData.m_EndPos.z;
					bool flag = default(bool);
					if (!flag)
					{
						num++;
					}
				}
				return -1L != -1L;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600218F")]
		[Cpp2IlInjected.Address(RVA = "0xF02E70", Offset = "0xF01870", VA = "0x180F02E70")]
		private static int FindPositionIndex(Vector3 position, Vector3[] path)
		{
			//Discarded unreachable code: IL_0020
			int num = 0;
			int length = path.Length;
			if (num < length)
			{
				float z = position.z;
				bool flag = default(bool);
				if (!flag)
				{
					num++;
				}
				return num;
			}
			return -1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002190")]
		[Cpp2IlInjected.Address(RVA = "0xF02B70", Offset = "0xF01570", VA = "0x180F02B70")]
		[Conditional("NAVMESHLINK_DEBUG")]
		private static void DebugLog(Character character, OffMeshLinkData linkData, string message)
		{
			//Discarded unreachable code: IL_00ac
			//IL_0072: Expected O, but got F4
			//IL_009b: Expected O, but got F4
			object[] array;
			float z;
			while (true)
			{
				array = new object[5];
				string text = character.name;
				if (text != null && text == null)
				{
					continue;
				}
				array[0] = text;
				if ("NavMeshLinkCharacterController" != null && "NavMeshLinkCharacterController" == null)
				{
					continue;
				}
				array[1] = "NavMeshLinkCharacterController";
				if (message != null && "NavMeshLinkCharacterController" == null)
				{
					continue;
				}
				array[2] = message;
				z = linkData.m_StartPos.z;
				if (z == 0f || z != 0f)
				{
					array[3] = z;
					float z2 = linkData.m_EndPos.z;
					z = z2;
					if (z2 == 0f || z2 != 0f)
					{
						break;
					}
				}
			}
			array[4] = z;
			UnityEngine.Debug.Log(string.Format("{0}:{1} -> {2} (from: {3}, to: {4}", array));
		}

		[Cpp2IlInjected.Token(Token = "0x6002191")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("NAVMESHLINK_DEBUG")]
		private static void DebugOnscreen(Character character, OffMeshLinkData linkData, string message)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002192")]
		[Cpp2IlInjected.Address(RVA = "0xF03160", Offset = "0xF01B60", VA = "0x180F03160")]
		public NavMeshLinkCharacterController()
		{
		}
	}
}
