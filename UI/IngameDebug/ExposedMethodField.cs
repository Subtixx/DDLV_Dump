using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public class ExposedMethodField : InspectorField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		[SerializeField]
		private Button invokeButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		protected ExposedMethod boundMethod;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x1520D50", Offset = "0x151F750", VA = "0x181520D50", Slot = "7")]
		public override bool SupportsType(Type type)
		{
			Type typeFromHandle = typeof(ExposedMethod);
			return ((object)type).Equals((object)typeFromHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x1520B00", Offset = "0x151F500", VA = "0x181520B00", Slot = "6")]
		public override void Initialize()
		{
			//Discarded unreachable code: IL_0027
			base.Initialize();
			Button.ButtonClickedEvent onClick = invokeButton.m_OnClick;
			UnityAction call = InvokeMethod;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x1520CC0", Offset = "0x151F6C0", VA = "0x181520CC0", Slot = "12")]
		protected override void OnSkinChanged()
		{
			base.OnSkinChanged();
			UISkin skin = base.m_skin;
			invokeButton.SetSkinButton(skin);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x1520C20", Offset = "0x151F620", VA = "0x181520C20", Slot = "13")]
		protected override void OnDepthChanged()
		{
			//Discarded unreachable code: IL_001a
			Transform transform = invokeButton.transform;
			UISkin skin = base.m_skin;
			int num = 0;
			if ((object)transform != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x1520CF0", Offset = "0x151F6F0", VA = "0x181520CF0")]
		public void SetBoundMethod(ExposedMethod boundMethod)
		{
			//Discarded unreachable code: IL_0014
			string text = (base.NameRaw = boundMethod.properties.m_label);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x1520BB0", Offset = "0x151F5B0", VA = "0x181520BB0")]
		public void InvokeMethod()
		{
			//Discarded unreachable code: IL_002d
			Refresh();
			RuntimeInspectorButtonAttribute properties = boundMethod.properties;
			object value = base.m_value;
			int num = 0;
			if ((properties.m_isInitializer ? 1 : 0) != num)
			{
				object value2 = default(object);
				base.Value = value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xA63100", Offset = "0xA61B00", VA = "0x180A63100")]
		public ExposedMethodField()
		{
		}
	}
}
