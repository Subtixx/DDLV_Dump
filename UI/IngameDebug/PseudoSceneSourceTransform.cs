using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public class PseudoSceneSourceTransform : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		[SerializeField]
		private RuntimeHierarchy m_hierarchy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		[SerializeField]
		private string m_sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		[SerializeField]
		private bool m_hideOnDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private HashSet<Transform> childrenCurrent = (HashSet<Transform>)(object)new HashSet<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private HashSet<Transform> childrenNew = (HashSet<Transform>)(object)new HashSet<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private bool updateChildren;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private bool isEnabled = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private bool isQuitting;

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public RuntimeHierarchy Hierarchy
		{
			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return m_hierarchy;
			}
			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0xE1F180", Offset = "0xE1DB80", VA = "0x180E1F180")]
			set
			{
				if (m_hierarchy != value)
				{
					RemoveChildrenFromScene();
					m_hierarchy = value;
					AddChildrenToScene();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public string SceneName
		{
			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return m_sceneName;
			}
			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0xE1F230", Offset = "0xE1DC30", VA = "0x180E1F230")]
			set
			{
				if (m_sceneName != value)
				{
					RemoveChildrenFromScene();
					m_sceneName = value;
					AddChildrenToScene();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public bool HideOnDisable
		{
			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return m_hideOnDisable;
			}
			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0xE1F150", Offset = "0xE1DB50", VA = "0x180E1F150")]
			set
			{
				if (m_hideOnDisable == value)
				{
					return;
				}
				m_hideOnDisable = value;
				if (!isEnabled)
				{
					if (!value)
					{
						AddChildrenToScene();
					}
					else
					{
						RemoveChildrenFromScene();
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		private bool ShouldUpdateChildren
		{
			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0xE1F0C0", Offset = "0xE1DAC0", VA = "0x180E1F0C0")]
			get
			{
				if ((!isEnabled && m_hideOnDisable) || !m_hierarchy)
				{
					int num = 0;
				}
				return !string.IsNullOrEmpty(m_sceneName);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0xE1ECF0", Offset = "0xE1D6F0", VA = "0x180E1ECF0")]
		private void OnEnable()
		{
			updateChildren = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xE1ECD0", Offset = "0xE1D6D0", VA = "0x180E1ECD0")]
		private void OnDisable()
		{
			if (!isQuitting)
			{
				isEnabled = false;
				if (m_hideOnDisable)
				{
					RemoveChildrenFromScene();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xE1ECC0", Offset = "0xE1D6C0", VA = "0x180E1ECC0")]
		private void OnApplicationQuit()
		{
			isQuitting = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0xA3C690", Offset = "0xA3B090", VA = "0x180A3C690")]
		private void OnTransformChildrenChanged()
		{
			updateChildren = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0xE1EEC0", Offset = "0xE1D8C0", VA = "0x180E1EEC0")]
		private void Update()
		{
			//Discarded unreachable code: IL_009e
			//IL_009d: Expected O, but got I4
			if (!updateChildren)
			{
				return;
			}
			updateChildren = false;
			if (!ShouldUpdateChildren)
			{
				return;
			}
			int num = 0;
			int childCount = base.transform.childCount;
			if (num < childCount)
			{
				Transform child = base.transform.GetChild(num);
				bool flag = ((HashSet<T>)(object)childrenNew).Add((T)child);
				if (!((HashSet<T>)(object)childrenCurrent).Remove((T)child))
				{
					RuntimeHierarchy hierarchy = m_hierarchy;
					string sceneName = m_sceneName;
					hierarchy.AddToPseudoScene(sceneName, child);
				}
				num++;
				Transform transform = base.transform;
			}
			RemoveChildrenFromScene();
			HashSet<Transform> hashSet = (childrenCurrent = childrenNew);
			childrenNew = (HashSet<Transform>)num;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0xE1EBD0", Offset = "0xE1D5D0", VA = "0x180E1EBD0")]
		private void AddChildrenToScene()
		{
			//Discarded unreachable code: IL_005c
			if (!ShouldUpdateChildren)
			{
				return;
			}
			int num = 0;
			int childCount = base.transform.childCount;
			if (num < childCount)
			{
				Transform child = base.transform.GetChild(num);
				if (((HashSet<T>)(object)childrenCurrent).Add((T)child))
				{
					RuntimeHierarchy hierarchy = m_hierarchy;
					string sceneName = m_sceneName;
					hierarchy.AddToPseudoScene(sceneName, child);
				}
				num++;
				Transform transform = base.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xE1ED00", Offset = "0xE1D700", VA = "0x180E1ED00")]
		private void RemoveChildrenFromScene()
		{
			//Discarded unreachable code: IL_0037, IL_003d
			int num = 0;
			if (!m_hierarchy || string.IsNullOrEmpty(m_sceneName))
			{
				return;
			}
			HashSet<Transform> hashSet = childrenCurrent;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				RuntimeHierarchy hierarchy = m_hierarchy;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xE1F010", Offset = "0xE1DA10", VA = "0x180E1F010")]
		public PseudoSceneSourceTransform()
		{
			((LODGroup)(object)this)._002Ector();
		}
	}
}
