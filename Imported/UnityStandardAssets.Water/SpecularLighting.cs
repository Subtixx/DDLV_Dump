using System;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class SpecularLighting : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public Transform specularLight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private WaterBase m_WaterBase;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2730", Offset = "0x3DC1130", VA = "0x183DC2730")]
		public void Start()
		{
			GameObject gameObject = base.gameObject;
			Type typeFromHandle = typeof(WaterBase);
			Component component = gameObject.GetComponent(typeFromHandle);
			if ((object)component == null)
			{
			}
			int num = 0;
			if ((object)component != null)
			{
				m_WaterBase = (WaterBase)component;
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2840", Offset = "0x3DC1240", VA = "0x183DC2840")]
		public void Update()
		{
			//Discarded unreachable code: IL_0086
			if (!m_WaterBase)
			{
				GameObject gameObject = base.gameObject;
				Type typeFromHandle = typeof(WaterBase);
				Component component = gameObject.GetComponent(typeFromHandle);
				if ((object)component == null)
				{
				}
				int num = 0;
				if ((object)component == null)
				{
					throw new InvalidCastException();
				}
				m_WaterBase = (WaterBase)component;
			}
			if ((bool)specularLight && (bool)m_WaterBase.sharedMaterial)
			{
				WaterBase waterBase = m_WaterBase;
				Transform transform = specularLight;
				Material sharedMaterial = waterBase.sharedMaterial;
				Transform transform2 = transform.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SpecularLighting()
		{
		}
	}
}
