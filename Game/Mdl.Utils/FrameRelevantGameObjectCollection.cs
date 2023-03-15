using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200074F")]
	public class FrameRelevantGameObjectCollection : FrameRelevantCollection<GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6002086")]
		[Cpp2IlInjected.Address(RVA = "0x1464F40", Offset = "0x1463940", VA = "0x181464F40", Slot = "7")]
		protected override void FireAdded(GameObject gameObject)
		{
			//Discarded unreachable code: IL_0023
			DestroyEventProvider orAddComponent = gameObject.GetOrAddComponent<DestroyEventProvider>();
			EventHandler value = GameObjectDestroyed;
			orAddComponent.DestroyEvent += value;
			((FrameRelevantCollection<ObjectType>)(object)this).FireAdded((ObjectType)gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6002087")]
		[Cpp2IlInjected.Address(RVA = "0x1465010", Offset = "0x1463A10", VA = "0x181465010", Slot = "8")]
		protected override void FireRemoved(GameObject gameObject)
		{
			//Discarded unreachable code: IL_0023
			DestroyEventProvider orAddComponent = gameObject.GetOrAddComponent<DestroyEventProvider>();
			EventHandler value = GameObjectDestroyed;
			orAddComponent.DestroyEvent -= value;
			((FrameRelevantCollection<ObjectType>)(object)this).FireRemoved((ObjectType)gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6002088")]
		[Cpp2IlInjected.Address(RVA = "0x14650E0", Offset = "0x1463AE0", VA = "0x1814650E0")]
		private void GameObjectDestroyed(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0010
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			if (flag)
			{
				GameObject gameObject = default(GameObject);
				FireRemoved(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002089")]
		[Cpp2IlInjected.Address(RVA = "0x14651E0", Offset = "0x1463BE0", VA = "0x1814651E0")]
		public FrameRelevantGameObjectCollection()
		{
			((FrameRelevantCollection<ObjectType>)(object)this)._002Ector();
		}
	}
}
