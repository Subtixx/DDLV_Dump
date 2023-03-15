using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Buildings;
using UnityEngine;
using UnityEngine.Playables;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005E6")]
	[RequireComponent(typeof(PlayableDirector))]
	public class TimelineBuildingUpgrade : MonoBehaviour, ITimelineCutsceneCleanUp
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40023DF")]
		private bool IsMarkerTriggered;

		[Cpp2IlInjected.Token(Token = "0x170003C5")]
		public UpgradableBuilding UpgradableBuilding
		{
			[Cpp2IlInjected.Token(Token = "0x6001A28")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CUpgradableBuilding_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A29")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CUpgradableBuilding_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A2A")]
		[Cpp2IlInjected.Address(RVA = "0x13C8E20", Offset = "0x13C7820", VA = "0x1813C8E20")]
		private void OnEnable()
		{
			IsMarkerTriggered = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A2B")]
		[Cpp2IlInjected.Address(RVA = "0x13C8E30", Offset = "0x13C7830", VA = "0x1813C8E30")]
		public void RefreshBuildingModel()
		{
			//Discarded unreachable code: IL_0026
			//IL_0010: Expected O, but got I4
			UpgradableBuilding upgradableBuilding = UpgradableBuilding;
			int num = 0;
			if (upgradableBuilding != (Object)num)
			{
				UpgradableBuilding.UpdateModelCS();
				IsMarkerTriggered = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A2C")]
		[Cpp2IlInjected.Address(RVA = "0x13C8D90", Offset = "0x13C7790", VA = "0x1813C8D90", Slot = "4")]
		public void EndCutsceneCleanup()
		{
			//Discarded unreachable code: IL_002f
			//IL_0019: Expected O, but got I4
			if (!IsMarkerTriggered)
			{
				UpgradableBuilding upgradableBuilding = UpgradableBuilding;
				int num = 0;
				if (upgradableBuilding != (Object)num)
				{
					UpgradableBuilding.UpdateModelCS();
				}
				IsMarkerTriggered = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A2D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TimelineBuildingUpgrade()
		{
		}
	}
}
