using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.UnitySceneCompiler
{
	[Cpp2IlInjected.Token(Token = "0x200022C")]
	public class USCTag : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200022D")]
		public enum TagAction
		{
			[Cpp2IlInjected.Token(Token = "0x4001309")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400130A")]
			RemoveGameObject,
			[Cpp2IlInjected.Token(Token = "0x400130B")]
			UnpackPrefab,
			[Cpp2IlInjected.Token(Token = "0x400130C")]
			SkipPrefabRefForChildren
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001306")]
		[SerializeField]
		private bool isRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4001307")]
		[SerializeField]
		private TagAction action;

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		public bool IsRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000984")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return isRoot;
			}
			[Cpp2IlInjected.Token(Token = "0x6000985")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			private set
			{
				isRoot = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		public TagAction Action
		{
			[Cpp2IlInjected.Token(Token = "0x6000986")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return action;
			}
			[Cpp2IlInjected.Token(Token = "0x6000987")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			private set
			{
				action = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000988")]
		[Cpp2IlInjected.Address(RVA = "0xD42FB0", Offset = "0xD419B0", VA = "0x180D42FB0")]
		private void Awake()
		{
			base.hideFlags = HideFlags.DontSaveInBuild;
		}

		[Cpp2IlInjected.Token(Token = "0x6000989")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public USCTag()
		{
		}
	}
}
