using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005D4")]
	public class TimelineClearFlag : MonoBehaviour, ITimelineCutsceneCleanUp
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023C0")]
		[SerializeField]
		[ItemID]
		private int flag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40023C1")]
		public bool triggerRequired = true;

		[Cpp2IlInjected.Token(Token = "0x60019F5")]
		[Cpp2IlInjected.Address(RVA = "0x13CD2A0", Offset = "0x13CBCA0", VA = "0x1813CD2A0")]
		public void ClearFlag()
		{
			//Discarded unreachable code: IL_000c, IL_0029
			//IL_0026: Expected O, but got I4
			Dictionary<int, bool> dictionary = (Dictionary<int, bool>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019F6")]
		[Cpp2IlInjected.Address(RVA = "0x13CD650", Offset = "0x13CC050", VA = "0x1813CD650")]
		public bool IsFlagCleared()
		{
			//Discarded unreachable code: IL_0026
			ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
			long num = Convert.ToInt64((uint)this.flag);
			bool flag = default(bool);
			return !flag;
		}

		[Cpp2IlInjected.Token(Token = "0x60019F7")]
		[Cpp2IlInjected.Address(RVA = "0x13CD3E0", Offset = "0x13CBDE0", VA = "0x1813CD3E0", Slot = "4")]
		public void EndCutsceneCleanup()
		{
			//Discarded unreachable code: IL_003a, IL_005b
			//IL_0058: Expected O, but got I4
			if (triggerRequired)
			{
				ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
				long num = Convert.ToInt64((uint)this.flag);
				bool flag = default(bool);
				if (flag)
				{
					Dictionary<int, bool> dictionary = (Dictionary<int, bool>)(object)new Dictionary<TKey, TValue>();
					throw new NullReferenceException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019F8")]
		[Cpp2IlInjected.Address(RVA = "0x13CD770", Offset = "0x13CC170", VA = "0x1813CD770")]
		public TimelineClearFlag()
		{
		}
	}
}
