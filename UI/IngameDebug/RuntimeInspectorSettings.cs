using Cpp2IlInjected;
using UnityEngine;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CreateAssetMenu]
	public class RuntimeInspectorSettings : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		[SerializeField]
		private InspectorField[] m_standardDrawers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		[SerializeField]
		private InspectorField[] m_referenceDrawers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		[SerializeField]
		private VariableSet[] m_hiddenVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		[SerializeField]
		private VariableSet[] m_exposedVariables;

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		public InspectorField[] StandardDrawers
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return m_standardDrawers;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		public InspectorField[] ReferenceDrawers
		{
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return m_referenceDrawers;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		public VariableSet[] HiddenVariables
		{
			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return m_hiddenVariables;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		public VariableSet[] ExposedVariables
		{
			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return m_exposedVariables;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public RuntimeInspectorSettings()
		{
		}
	}
}
