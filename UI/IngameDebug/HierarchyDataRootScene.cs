using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public class HierarchyDataRootScene : HierarchyDataRoot
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private readonly List<GameObject> rootObjects;

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		public override string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0xAE3C20", Offset = "0xAE2620", VA = "0x180AE3C20", Slot = "4")]
			get
			{
				Scene scene = Scene;
				string result = default(string);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public override int ChildCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xAE3BE0", Offset = "0xAE25E0", VA = "0x180AE3BE0", Slot = "6")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((List<>)(object)rootObjects)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4000384")]
		public Scene Scene
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0xAE3B40", Offset = "0xAE2540", VA = "0x180AE3B40")]
		public HierarchyDataRootScene(RuntimeHierarchy hierarchy, Scene target)
		{
			//IL_0022: Expected O, but got I4
			int handle = target.m_Handle;
			rootObjects = (List<GameObject>)(object)new List<T>();
			base._002Ector(hierarchy);
			Scene = (Scene)handle;
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xAE3AE0", Offset = "0xAE24E0", VA = "0x180AE3AE0", Slot = "10")]
		public override void RefreshContent()
		{
			//Discarded unreachable code: IL_001a
			((List<T>)(object)rootObjects).Clear();
			Scene scene = Scene;
			List<GameObject> list = rootObjects;
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xAE3A70", Offset = "0xAE2470", VA = "0x180AE3A70", Slot = "9")]
		public override Transform GetChild(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
