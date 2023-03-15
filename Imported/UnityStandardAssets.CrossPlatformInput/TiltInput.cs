using System;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class TiltInput : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public enum AxisOptions
		{
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			ForwardAxis,
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			SidewaysAxis
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		public class AxisMapping
		{
			[Cpp2IlInjected.Token(Token = "0x200009C")]
			public enum MappingType
			{
				[Cpp2IlInjected.Token(Token = "0x4000264")]
				NamedAxis,
				[Cpp2IlInjected.Token(Token = "0x4000265")]
				MousePositionX,
				[Cpp2IlInjected.Token(Token = "0x4000266")]
				MousePositionY,
				[Cpp2IlInjected.Token(Token = "0x4000267")]
				MousePositionZ
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			public MappingType type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000262")]
			public string axisName;

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public AxisMapping()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public AxisMapping mapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public AxisOptions tiltAroundAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public float fullTiltAngle = 25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public float centreAngleOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3340", Offset = "0x3DC1D40", VA = "0x183DC3340")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0038
			AxisMapping axisMapping = mapping;
			if (axisMapping.type == AxisMapping.MappingType.NamedAxis)
			{
				CrossPlatformInputManager.VirtualAxis virtualAxis = default(CrossPlatformInputManager.VirtualAxis);
				string text = (virtualAxis.name = axisMapping.axisName);
				virtualAxis.matchWithInputManager = true;
				m_SteerAxis = virtualAxis;
				CrossPlatformInputManager.RegisterVirtualAxis(m_SteerAxis);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3410", Offset = "0x3DC1E10", VA = "0x183DC3410")]
		private void Update()
		{
			//IL_0061: Expected F4, but got I4
			//IL_00c4: Expected F4, but got I4
			int num = 0;
			float z = Input.acceleration.z;
			float z2 = Vector3.zero.z;
			bool flag = default(bool);
			if (flag)
			{
				AxisOptions axisOptions = tiltAroundAxis;
				if (axisOptions == AxisOptions.ForwardAxis)
				{
					Vector3 acceleration = Input.acceleration;
					Vector3 acceleration2 = Input.acceleration;
				}
				if (axisOptions == AxisOptions.SidewaysAxis)
				{
					float z3 = Input.acceleration.z;
					Vector3 acceleration3 = Input.acceleration;
				}
			}
			float num2 = fullTiltAngle;
			float num3 = Mathf.InverseLerp(num2, num2, num);
			AxisMapping.MappingType type = mapping.type;
			if (type != 0)
			{
				int width2;
				if (type != 0)
				{
					switch (type)
					{
					case AxisMapping.MappingType.MousePositionX:
					{
						int num4 = 0;
						int width = Screen.width;
						CrossPlatformInputManager.SetVirtualMousePositionZ(num3);
						return;
					}
					default:
						return;
					case AxisMapping.MappingType.NamedAxis:
						break;
					}
					int num5 = 0;
					width2 = Screen.width;
					CrossPlatformInputManager.SetVirtualMousePositionY(num3);
				}
				int num6 = 0;
				width2 = Screen.width;
				CrossPlatformInputManager.SetVirtualMousePositionX(num3);
			}
			m_SteerAxis.m_Value = 0f;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3DC32D0", Offset = "0x3DC1CD0", VA = "0x183DC32D0")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0011
			CrossPlatformInputManager.UnRegisterVirtualAxis(m_SteerAxis.name);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3DC36C0", Offset = "0x3DC20C0", VA = "0x183DC36C0")]
		public TiltInput()
		{
		}
	}
}
