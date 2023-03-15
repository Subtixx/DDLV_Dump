using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[AddComponentMenu("Rewired/Rewired Event System")]
	public class RewiredEventSystem : EventSystem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		[SerializeField]
		[Tooltip("If enabled, the Event System will be updated every frame even if other Event Systems are enabled. Otherwise, only EventSystem.current will be updated.")]
		private bool _alwaysUpdate;

		[Cpp2IlInjected.Token(Token = "0x17000233")]
		public bool alwaysUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730")]
			get
			{
				return _alwaysUpdate;
			}
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set
			{
				_alwaysUpdate = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x1E97E40", Offset = "0x1E96840", VA = "0x181E97E40", Slot = "18")]
		protected override void Update()
		{
			int num = 0;
			if ((_alwaysUpdate ? 1 : 0) != num)
			{
				int num2 = 0;
				EventSystem eventSystem = EventSystem.current;
				if (eventSystem != this)
				{
					EventSystem.current = this;
				}
				base.Update();
				bool flag = default(bool);
				if (flag)
				{
					EventSystem.current = eventSystem;
				}
				uint num3 = default(uint);
				if (num3 == 0)
				{
				}
			}
			base.Update();
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x1E97FE0", Offset = "0x1E969E0", VA = "0x181E97FE0")]
		public RewiredEventSystem()
		{
		}
	}
}
