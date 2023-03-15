using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public class TransformField : ExpandableInspectorField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private PropertyInfo positionProp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private PropertyInfo rotationProp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private PropertyInfo scaleProp;

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		protected override int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000696")]
			[Cpp2IlInjected.Address(RVA = "0x8C8560", Offset = "0x8C6F60", VA = "0x1808C8560", Slot = "15")]
			get
			{
				return 3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x17F31B0", Offset = "0x17F1BB0", VA = "0x1817F31B0", Slot = "6")]
		public override void Initialize()
		{
			base.Initialize();
			PropertyInfo propertyInfo = (positionProp = typeof(Transform).GetProperty("localPosition"));
			PropertyInfo propertyInfo2 = (rotationProp = typeof(Transform).GetProperty("localEulerAngles"));
			PropertyInfo propertyInfo3 = (scaleProp = typeof(Transform).GetProperty("localScale"));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x17F32F0", Offset = "0x17F1CF0", VA = "0x1817F32F0", Slot = "7")]
		public override bool SupportsType(Type type)
		{
			Type typeFromHandle = typeof(Transform);
			return ((object)type).Equals((object)typeFromHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x17F3120", Offset = "0x17F1B20", VA = "0x1817F3120", Slot = "16")]
		protected override void GenerateElements()
		{
			PropertyInfo variable = positionProp;
			InspectorField inspectorField = CreateDrawerForVariable(variable, "Position");
			PropertyInfo variable2 = rotationProp;
			InspectorField inspectorField2 = CreateDrawerForVariable(variable2, "Rotation");
			PropertyInfo variable3 = scaleProp;
			InspectorField inspectorField3 = CreateDrawerForVariable(variable3, "Scale");
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x12A2DE0", Offset = "0x12A17E0", VA = "0x1812A2DE0")]
		public TransformField()
		{
		}
	}
}
