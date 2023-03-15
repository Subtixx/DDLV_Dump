using System;
using System.Data.SqlTypes;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class BoundsField : InspectorField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		[SerializeField]
		private Vector3Field inputCenter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		[SerializeField]
		private Vector3Field inputExtents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private MemberInfo centerVariable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private MemberInfo extentsVariable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private MemberInfo intCenterVariable;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private MemberInfo intSizeVariable;

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		protected override float HeightMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xA640C0", Offset = "0xA62AC0", VA = "0x180A640C0", Slot = "5")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xA63BA0", Offset = "0xA625A0", VA = "0x180A63BA0", Slot = "6")]
		public override void Initialize()
		{
			base.Initialize();
			PropertyInfo propertyInfo = (PropertyInfo)(centerVariable = typeof(Bounds).GetProperty("center"));
			PropertyInfo propertyInfo2 = (PropertyInfo)(extentsVariable = typeof(Bounds).GetProperty("extents"));
			PropertyInfo propertyInfo3 = (PropertyInfo)(intCenterVariable = typeof(BoundsInt).GetProperty("center"));
			PropertyInfo propertyInfo4 = (PropertyInfo)(intSizeVariable = typeof(BoundsInt).GetProperty("size"));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA629E0", VA = "0x180A63FE0", Slot = "7")]
		public override bool SupportsType(Type type)
		{
			Type typeFromHandle = typeof(BoundsInt);
			if (!((object)type).Equals((object)typeFromHandle))
			{
				Type typeFromHandle2 = typeof(Bounds);
				return ((object)type).Equals((object)typeFromHandle2);
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA63D30", Offset = "0xA62730", VA = "0x180A63D30", Slot = "9")]
		protected override void OnBound(MemberInfo variable)
		{
			base.OnBound(variable);
			Type boundVariableType = base.m_boundVariableType;
			Type typeFromHandle = typeof(BoundsInt);
			bool flag = ((object)boundVariableType).Equals((object)typeFromHandle);
			Vector3Field vector3Field = inputCenter;
			if (!flag)
			{
				int num = 0;
				MemberInfo variable2 = centerVariable;
				vector3Field.BindTo(this, variable2, "Center:");
				Vector3Field vector3Field2 = inputExtents;
				MemberInfo variable3 = extentsVariable;
				vector3Field2.BindTo(this, variable3, "Extents:");
				return;
			}
			int num2 = 0;
			MemberInfo variable4 = intCenterVariable;
			vector3Field.BindTo(this, variable4, "Center:");
			Vector3Field vector3Field3 = inputExtents;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA63EE0", Offset = "0xA628E0", VA = "0x180A63EE0", Slot = "11")]
		protected override void OnInspectorChanged()
		{
			//Discarded unreachable code: IL_0031
			base.OnInspectorChanged();
			Vector3Field vector3Field = inputCenter;
			RuntimeInspector runtimeInspector = (vector3Field.Inspector = base.m_inspector);
			Vector3Field vector3Field2 = inputExtents;
			RuntimeInspector runtimeInspector2 = (vector3Field2.Inspector = base.m_inspector);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA63F30", Offset = "0xA62930", VA = "0x180A63F30", Slot = "12")]
		protected override void OnSkinChanged()
		{
			//Discarded unreachable code: IL_0031
			base.OnSkinChanged();
			Vector3Field vector3Field = inputCenter;
			UISkin uISkin = (vector3Field.Skin = base.m_skin);
			Vector3Field vector3Field2 = inputExtents;
			UISkin uISkin2 = (vector3Field2.Skin = base.m_skin);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xA63E90", Offset = "0xA62890", VA = "0x180A63E90", Slot = "13")]
		protected override void OnDepthChanged()
		{
			//Discarded unreachable code: IL_0039
			base.OnDepthChanged();
			Vector3Field vector3Field = inputCenter;
			int depth = base.m_depth;
			depth = (vector3Field.Depth = depth + 1);
			Vector3Field vector3Field2 = inputExtents;
			int depth2 = base.m_depth;
			depth2 = (vector3Field2.Depth = depth2 + 1);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62980", VA = "0x180A63F80", Slot = "14")]
		public override void Refresh()
		{
			//Discarded unreachable code: IL_0021
			//IL_0009: Expected O, but got I4
			int num = 0;
			base.OnBound((MemberInfo)num);
			inputCenter.Refresh();
			long length = ((System.Data.SqlTypes.SqlStreamChars)(object)inputExtents).Length;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA63100", Offset = "0xA61B00", VA = "0x180A63100")]
		public BoundsField()
		{
		}
	}
}
