using Cpp2IlInjected;
using UnityEngine;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public abstract class SkinnedWindow : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		[SerializeField]
		private UISkin m_skin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private int m_skinVersion;

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		public UISkin Skin
		{
			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return m_skin;
			}
			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x15F4BF0", Offset = "0x15F35F0", VA = "0x1815F4BF0")]
			set
			{
				//Discarded unreachable code: IL_0036
				//IL_0009: Expected O, but got I4
				int num = 0;
				if (value != (Object)num && m_skin != value)
				{
					m_skin = value;
					int num2 = (m_skinVersion = m_skin.m_version);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x15F4B50", Offset = "0x15F3550", VA = "0x1815F4B50", Slot = "4")]
		protected virtual void Awake()
		{
			//Discarded unreachable code: IL_0030
			int num = (m_skinVersion = m_skin.m_version);
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			base.gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x15F4BB0", Offset = "0x15F35B0", VA = "0x1815F4BB0", Slot = "5")]
		protected virtual void Update()
		{
			//Discarded unreachable code: IL_0024
			int version = m_skin.m_version;
			if (m_skinVersion != version)
			{
				m_skinVersion = version;
				RefreshSkin();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void RefreshSkin();

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected SkinnedWindow()
		{
		}
	}
}
