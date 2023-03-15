using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x200062F")]
	internal class DarkForestController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400250E")]
		public ForestMistDoor[] ListOfRealMistDoors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400250F")]
		public ForestMistDoor[] ListOfFakeMistDoors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002510")]
		public GameObject FeatherIngredient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002511")]
		public ParticleSystem featherGlow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002512")]
		public AK.Wwise.Event featherGlowSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002513")]
		public AK.Wwise.Event StopFeatherSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002514")]
		public AK.Wwise.Event usignFakeWallSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002515")]
		public Transform FeatherStartLocation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002516")]
		public Transform PlayerStartLocation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002517")]
		public Transform EndLocation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002518")]
		private bool _mazeGameplayStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x4002519")]
		private bool failTriggering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400251A")]
		[SerializeField]
		[ItemID]
		private int _gameplayActiveCondition;

		[Cpp2IlInjected.Token(Token = "0x6001B6E")]
		[Cpp2IlInjected.Address(RVA = "0x1114C30", Offset = "0x1113630", VA = "0x181114C30")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0067
			int gameplayActiveCondition = _gameplayActiveCondition;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			long num = Convert.ToInt64((uint)gameplayActiveCondition);
			ConditionItemData conditionItemData = default(ConditionItemData);
			ConditionsList conditions_ = conditionItemData.conditions_;
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = SystemRoot.Instance.MetaClient.TransactionContext;
			if (!conditions_.Evaluate(profile, _003CTransactionContext_003Ek__BackingField))
			{
				InitDoors();
				return;
			}
			InitFeather();
			InitDoors();
			_mazeGameplayStarted = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B6F")]
		[Cpp2IlInjected.Address(RVA = "0x1114BE0", Offset = "0x11135E0", VA = "0x181114BE0")]
		private void OnDestroy()
		{
			StopMazeGameplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B70")]
		[Cpp2IlInjected.Address(RVA = "0x1115290", Offset = "0x1113C90", VA = "0x181115290")]
		private void StartMazeGameplay()
		{
			InitFeather();
			InitDoors();
			_mazeGameplayStarted = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B71")]
		[Cpp2IlInjected.Address(RVA = "0x11152C0", Offset = "0x1113CC0", VA = "0x1811152C0")]
		private void StopMazeGameplay()
		{
			//Discarded unreachable code: IL_00c8
			//IL_005a: Expected O, but got I4
			ForestMistDoor[] listOfFakeMistDoors = ListOfFakeMistDoors;
			int num = 0;
			int num2 = 0;
			int length = listOfFakeMistDoors.Length;
			if (num2 < length)
			{
				ForestMistDoor forestMistDoor = listOfFakeMistDoors[num];
				ForestMistDoor.WrongDoorEntered onWrongDoorEntered = forestMistDoor.OnWrongDoorEntered;
				ForestMistDoor.WrongDoorEntered value = OnWrongDoorEntered;
				Delegate @delegate = Delegate.Remove(onWrongDoorEntered, value);
				int num3 = 0;
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				forestMistDoor.OnWrongDoorEntered = (ForestMistDoor.WrongDoorEntered)num3;
				num++;
			}
			ForestMistDoor[] listOfRealMistDoors = ListOfRealMistDoors;
			int num4 = 0;
			int num5 = 0;
			int length2 = listOfRealMistDoors.Length;
			if (num5 < length2)
			{
				ForestMistDoor forestMistDoor2 = listOfRealMistDoors[num4];
				ForestMistDoor.RealDoorEntered onRealDoorEntered = forestMistDoor2.OnRealDoorEntered;
				ForestMistDoor.RealDoorEntered value2 = OnRealDoorEntered;
				Delegate delegate2 = Delegate.Remove(onRealDoorEntered, value2);
				if ((object)delegate2 != null && (object)delegate2 == null)
				{
					throw new InvalidCastException();
				}
				forestMistDoor2.OnRealDoorEntered = (ForestMistDoor.RealDoorEntered)delegate2;
				num4++;
			}
			CompleteMazeGameplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B72")]
		[Cpp2IlInjected.Address(RVA = "0x11145A0", Offset = "0x1112FA0", VA = "0x1811145A0")]
		private void CompleteMazeGameplay()
		{
			//Discarded unreachable code: IL_0044
			AK.Wwise.Event stopFeatherSfx = StopFeatherSfx;
			if (stopFeatherSfx != null)
			{
				GameObject featherIngredient = FeatherIngredient;
				uint num = stopFeatherSfx.Post(featherIngredient);
			}
			Trail component = FeatherIngredient.GetComponent<Trail>();
			EventHandler value = ReachedDestination;
			component.ReachedDestination -= value;
			_mazeGameplayStarted = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B73")]
		[Cpp2IlInjected.Address(RVA = "0x11146B0", Offset = "0x11130B0", VA = "0x1811146B0")]
		private void InitDoors()
		{
			//IL_005a: Expected O, but got I4
			ForestMistDoor[] listOfFakeMistDoors = ListOfFakeMistDoors;
			int num = 0;
			int num2 = 0;
			int length = listOfFakeMistDoors.Length;
			if (num2 < length)
			{
				ForestMistDoor forestMistDoor = listOfFakeMistDoors[num];
				ForestMistDoor.WrongDoorEntered onWrongDoorEntered = forestMistDoor.OnWrongDoorEntered;
				ForestMistDoor.WrongDoorEntered b = OnWrongDoorEntered;
				Delegate @delegate = Delegate.Combine(onWrongDoorEntered, b);
				int num3 = 0;
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				forestMistDoor.OnWrongDoorEntered = (ForestMistDoor.WrongDoorEntered)num3;
				num++;
			}
			ForestMistDoor[] listOfRealMistDoors = ListOfRealMistDoors;
			int num4 = 0;
			int num5 = 0;
			int length2 = listOfRealMistDoors.Length;
			if (num5 >= length2)
			{
				return;
			}
			ForestMistDoor forestMistDoor2 = listOfRealMistDoors[num4];
			Animator[] componentsInChildren = forestMistDoor2.GetComponentsInChildren<Animator>();
			Action<Animator> action = default(Action<Animator>);
			if (_003C_003Ec._003C_003E9__18_0 == null)
			{
				action = (Action<Animator>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(Animator x)
				{
					//Discarded unreachable code: IL_000c
					x.ResetTrigger("Dissipate");
				});
			}
			MoreLinq.ForEach<Animator>((IEnumerable<>)(object)componentsInChildren, (Action<>)(object)action);
			ForestMistDoor.RealDoorEntered onRealDoorEntered = forestMistDoor2.OnRealDoorEntered;
			ForestMistDoor.RealDoorEntered b2 = OnRealDoorEntered;
			Delegate delegate2 = Delegate.Combine(onRealDoorEntered, b2);
			if ((object)delegate2 == null || (object)delegate2 != null)
			{
				forestMistDoor2.OnRealDoorEntered = (ForestMistDoor.RealDoorEntered)delegate2;
				num4++;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B74")]
		[Cpp2IlInjected.Address(RVA = "0x11150C0", Offset = "0x1113AC0", VA = "0x1811150C0")]
		private void ResetRealDoors()
		{
			//Discarded unreachable code: IL_0060
			//IL_0029: Expected I4, but got I8
			ForestMistDoor[] listOfRealMistDoors = ListOfRealMistDoors;
			int num = 0;
			int length = listOfRealMistDoors.Length;
			if (num >= length)
			{
				return;
			}
			ForestMistDoor forestMistDoor = listOfRealMistDoors[num];
			ulong num2 = default(ulong);
			forestMistDoor.gameObject.SetActive((byte)num2 != 0);
			Animator[] componentsInChildren = forestMistDoor.GetComponentsInChildren<Animator>();
			Action<Animator> _003C_003E9__19_ = _003C_003Ec._003C_003E9__19_0;
			if (_003C_003E9__19_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(Animator x)
				{
					//Discarded unreachable code: IL_0017
					x.ResetTrigger("Dissipate");
					x.SetTrigger("Reappear");
				};
			}
			MoreLinq.ForEach<Animator>((IEnumerable<>)(object)componentsInChildren, (Action<>)(object)_003C_003E9__19_);
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B75")]
		[Cpp2IlInjected.Address(RVA = "0x11149D0", Offset = "0x11133D0", VA = "0x1811149D0")]
		private void InitFeather()
		{
			//Discarded unreachable code: IL_0085
			//IL_0084: Expected F4, but got I4
			NavMeshAgent component = FeatherIngredient.GetComponent<NavMeshAgent>();
			Transform featherStartLocation = FeatherStartLocation;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Trail component2 = FeatherIngredient.GetComponent<Trail>();
			PlayerAvatar avatar = SystemRoot.Instance._avatar;
			component2.Init(avatar);
			Transform transform = (component2.Target = EndLocation);
			EventHandler value = ReachedDestination;
			component2.ReachedDestination += value;
			CancelInvoke("GlowFeather");
			int num = 0;
			InvokeRepeating("GlowFeather", num, 3f);
		}

		[Cpp2IlInjected.Token(Token = "0x6001B76")]
		[Cpp2IlInjected.Address(RVA = "0x1114670", Offset = "0x1113070", VA = "0x181114670")]
		private void GlowFeather()
		{
			AK.Wwise.Event @event = featherGlowSfx;
			if (@event != null)
			{
				GameObject featherIngredient = FeatherIngredient;
				uint num = @event.Post(featherIngredient);
			}
			featherGlow?.Play();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B77")]
		[Cpp2IlInjected.Address(RVA = "0x11154C0", Offset = "0x1113EC0", VA = "0x1811154C0")]
		[AsyncStateMachine(typeof(_003CTriggerFail_003Ed__22))]
		private Task TriggerFail()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B78")]
		[Cpp2IlInjected.Address(RVA = "0x1115050", Offset = "0x1113A50", VA = "0x181115050")]
		private void OnWrongDoorEntered(ForestMistDoor door)
		{
			TriggerFail().FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B79")]
		[Cpp2IlInjected.Address(RVA = "0x1114EA0", Offset = "0x11138A0", VA = "0x181114EA0")]
		private void OnRealDoorEntered(ForestMistDoor door)
		{
			//Discarded unreachable code: IL_0043
			if (!_mazeGameplayStarted)
			{
				TriggerFail().FireAndForgetTask();
				return;
			}
			Animator[] componentsInChildren = door.GetComponentsInChildren<Animator>();
			Action<Animator> action = default(Action<Animator>);
			if (_003C_003Ec._003C_003E9__24_0 == null)
			{
				action = (Action<Animator>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(Animator x)
				{
					//Discarded unreachable code: IL_0017
					x.ResetTrigger("Reappear");
					x.SetTrigger("Dissipate");
				});
			}
			MoreLinq.ForEach<Animator>((IEnumerable<>)(object)componentsInChildren, (Action<>)(object)action);
		}

		[Cpp2IlInjected.Token(Token = "0x6001B7A")]
		[Cpp2IlInjected.Address(RVA = "0x11150B0", Offset = "0x1113AB0", VA = "0x1811150B0")]
		private void ReachedDestination(object sender, EventArgs e)
		{
			CompleteMazeGameplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B7B")]
		[Cpp2IlInjected.Address(RVA = "0x1114BF0", Offset = "0x11135F0", VA = "0x181114BF0")]
		private void OnDisable()
		{
			CancelInvoke("GlowFeather");
		}

		[Cpp2IlInjected.Token(Token = "0x6001B7C")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DarkForestController()
		{
		}
	}
}
