using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic
{
	[Cpp2IlInjected.Token(Token = "0x200049E")]
	public class LevelComplexityBoundary : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001D12")]
		[HideInInspector]
		public List<SceneComplexity> complexity = (List<SceneComplexity>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001D13")]
		public float ViewDistance = 150f;

		[Cpp2IlInjected.Token(Token = "0x1700028F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4001D11")]
		public bool DisplayGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x6001483")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001484")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000290")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x2C"), Cpp2IlInjected.Token(Token = "0x4001D14")]
		public bool isLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x6001485")]
			[Cpp2IlInjected.Address(RVA = "0xDD7720", Offset = "0xDD6120", VA = "0x180DD7720")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001486")]
			[Cpp2IlInjected.Address(RVA = "0xDD7730", Offset = "0xDD6130", VA = "0x180DD7730")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6001487")]
		[Cpp2IlInjected.Address(RVA = "0x11C5760", Offset = "0x11C4160", VA = "0x1811C5760")]
		private void OnDrawGizmos()
		{
			//Discarded unreachable code: IL_001e
			if (DisplayGizmo)
			{
				Color green = Color.green;
				Transform transform = base.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001488")]
		[Cpp2IlInjected.Address(RVA = "0x11C57E0", Offset = "0x11C41E0", VA = "0x1811C57E0")]
		public LevelComplexityBoundary()
		{
		}
	}
}
