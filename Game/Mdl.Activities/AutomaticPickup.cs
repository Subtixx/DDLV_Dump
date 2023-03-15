using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B19")]
	internal class AutomaticPickup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003DBC")]
		[SerializeField]
		private AutomaticPickUpData _automaticPickUpData;

		[Cpp2IlInjected.Token(Token = "0x4003DBD")]
		private const string DefaultDataAddress = "guid:bad1e434818a239479cf34305eeaa5ee";

		[Cpp2IlInjected.Token(Token = "0x600332E")]
		[Cpp2IlInjected.Address(RVA = "0x150B430", Offset = "0x1509E30", VA = "0x18150B430")]
		private void Start()
		{
			CancellationTokenProvider cancellationTokenProvider = this.GetOrAddComponent<CancellationTokenProvider>();
			bool flag = default(bool);
			RewardSpawnAnimation rewardSpawnAnimation = default(RewardSpawnAnimation);
			if (flag)
			{
				RewardSpawnAnimation rewardSpawnAnimation2 = rewardSpawnAnimation;
				if (!rewardSpawnAnimation2.AnimationOver)
				{
					EventHandler value = RewardSpawnAnimationOver;
					rewardSpawnAnimation2.AnimationOverEvent += value;
					return;
				}
			}
			AutomaticPickUpData automaticPickUpData = _automaticPickUpData;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x6003332")]
			[Cpp2IlInjected.Address(RVA = "0x157C250", Offset = "0x157AC50", VA = "0x18157C250")]
			void RewardSpawnAnimationOver(object sender, EventArgs e)
			{
				//Discarded unreachable code: IL_0049
				RewardSpawnAnimation rewardSpawnAnimation3 = rewardSpawnAnimation;
				EventHandler value2 = RewardSpawnAnimationOver;
				rewardSpawnAnimation3.AnimationOverEvent -= value2;
				AutomaticPickup automaticPickup = this;
				CancellationTokenProvider cancellationTokenProvider2 = cancellationTokenProvider;
				AutomaticPickUpData automaticPickUpData2 = automaticPickup._automaticPickUpData;
				CancellationToken cancellationToken = cancellationTokenProvider2.CancellationToken;
				automaticPickup.AutomaticPickupCoroutine(automaticPickUpData2, cancellationToken).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600332F")]
		[Cpp2IlInjected.Address(RVA = "0x150B300", Offset = "0x1509D00", VA = "0x18150B300")]
		[AsyncStateMachine(typeof(_003CAutomaticPickupCoroutine_003Ed__3))]
		private Task AutomaticPickupCoroutine(AutomaticPickUpData automaticPickUpData, CancellationToken ct)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003330")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public AutomaticPickup()
		{
		}
	}
}
