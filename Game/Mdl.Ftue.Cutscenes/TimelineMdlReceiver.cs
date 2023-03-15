using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.Playables;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005DB")]
	public class TimelineMdlReceiver : MonoBehaviour, INotificationReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6001A07")]
		[Cpp2IlInjected.Address(RVA = "0x13CF340", Offset = "0x13CDD40", VA = "0x1813CF340", Slot = "4")]
		public void OnNotify(Playable origin, INotification notification, object context)
		{
			//Discarded unreachable code: IL_0046
			//IL_0042: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			if (notification == null)
			{
				return;
			}
			int num = 0;
			int num2 = 0;
			if (notification == null)
			{
				return;
			}
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				PlayerAvatar avatar = _003CInstance_003Ek__BackingField._avatar;
				if ((object)avatar != null)
				{
					Animator animator = avatar.Animator;
				}
			}
			SystemRoot _003CInstance_003Ek__BackingField2 = SystemRoot.Instance;
			SystemRoot _003CInstance_003Ek__BackingField3 = SystemRoot.Instance;
			int num3 = 0;
			if (!((Object)num2 != (Object)num3))
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A08")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TimelineMdlReceiver()
		{
		}
	}
}
