using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Grid;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200079F")]
	public class RelaxingBehaviour : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002B6F")]
		private Dictionary<RelaxingBehaviourData, bool> canRelaxByBehaviour = (Dictionary<RelaxingBehaviourData, bool>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002B72")]
		private Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002B73")]
		private IRelaxer relaxer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002B74")]
		public List<string> triggersToReset = (List<string>)(object)new List<T>
		{
			(T)"Celebrate",
			(T)"Hello",
			(T)"Interact",
			(T)"Collect",
			(T)"Give",
			(T)"Discussion",
			(T)"Happy",
			(T)"Laughing",
			(T)"Confused",
			(T)"Sad",
			(T)"Angry"
		};

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002B76")]
		private TaskCompletionSource<bool> sharedEndRelaxTask;

		[Cpp2IlInjected.Token(Token = "0x170004B2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4002B70")]
		public bool Relaxing
		{
			[Cpp2IlInjected.Token(Token = "0x60021E0")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60021E1")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004B3")]
		public RelaxingPosition CurrentRelaxingPosition
		{
			[Cpp2IlInjected.Token(Token = "0x60021E2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CCurrentRelaxingPosition_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60021E3")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CCurrentRelaxingPosition_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400004D")]
		public event EventHandler RelaxingStateChangedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60021E4")]
			[Cpp2IlInjected.Address(RVA = "0xCBFC70", Offset = "0xCBE670", VA = "0x180CBFC70")]
			[CompilerGenerated]
			add
			{
				EventHandler relaxingStateChangedEvent = this.RelaxingStateChangedEvent;
				Delegate @delegate = Delegate.Combine(relaxingStateChangedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != relaxingStateChangedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60021E5")]
			[Cpp2IlInjected.Address(RVA = "0xCBFD10", Offset = "0xCBE710", VA = "0x180CBFD10")]
			[CompilerGenerated]
			remove
			{
				EventHandler relaxingStateChangedEvent = this.RelaxingStateChangedEvent;
				Delegate @delegate = Delegate.Remove(relaxingStateChangedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != relaxingStateChangedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60021DF")]
		[Cpp2IlInjected.Address(RVA = "0xCBE940", Offset = "0xCBD340", VA = "0x180CBE940")]
		internal bool CanRelax(RelaxingBehaviourData relaxingBehaviourData)
		{
			//IL_006c: Expected O, but got I4
			Dictionary<RelaxingBehaviourData, bool> dictionary = canRelaxByBehaviour;
			bool flag = default(bool);
			if (!flag)
			{
				IRelaxer relaxer = this.relaxer;
				if (relaxer != null)
				{
					int num = 0;
					if (relaxer != null)
					{
						Animator animator = this.animator;
						int num2 = 0;
						RuntimeAnimatorController runtimeAnimatorController = animator.runtimeAnimatorController;
						if ((object)runtimeAnimatorController != null)
						{
							int num3 = 0;
							if ((object)runtimeAnimatorController != null)
							{
								List<KeyValuePair<AnimationClip, AnimationClip>> cpp2il__autoParamName__idx_ = (List<KeyValuePair<AnimationClip, AnimationClip>>)(object)new List<T>();
								RelaxingBehaviourData relaxingBehaviourData2 = relaxingBehaviourData;
								int num4 = 0;
								AnimationClip animationClip = default(AnimationClip);
								if (!(animationClip != (UnityEngine.Object)num4))
								{
									int num5 = 0;
								}
								Func<KeyValuePair<AnimationClip, AnimationClip>, bool> cpp2il__autoParamName__idx_2 = (Func<KeyValuePair<AnimationClip, AnimationClip>, bool>)(object)(Func<T, TResult>)delegate
								{
									throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
								};
								bool flag2 = ((IEnumerable<>)cpp2il__autoParamName__idx_).Any<KeyValuePair<AnimationClip, AnimationClip>>((Func<, >)(object)cpp2il__autoParamName__idx_2);
							}
						}
					}
				}
				Dictionary<RelaxingBehaviourData, bool> dictionary2 = canRelaxByBehaviour;
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021E6")]
		[Cpp2IlInjected.Address(RVA = "0xCBF780", Offset = "0xCBE180", VA = "0x180CBF780")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_002f
			//IL_0019: Expected O, but got I4
			if (Relaxing)
			{
				RelaxingPosition relaxingPosition = CurrentRelaxingPosition;
				int num = 0;
				if (relaxingPosition != (UnityEngine.Object)num)
				{
					animator.SetBool("IsSitting", value: true);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60021E7")]
		[Cpp2IlInjected.Address(RVA = "0xCBF970", Offset = "0xCBE370", VA = "0x180CBF970")]
		private void Start()
		{
			Animator animator = (this.animator = GetComponentInChildren<Animator>());
			IRelaxer relaxer = (this.relaxer = GetComponent<IRelaxer>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60021E8")]
		[Cpp2IlInjected.Address(RVA = "0xCBF820", Offset = "0xCBE220", VA = "0x180CBF820")]
		[AsyncStateMachine(typeof(_003CRelax_003Ed__18))]
		public Task Relax(RelaxingPosition relaxingPosition, int destinationIndex, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60021E9")]
		[Cpp2IlInjected.Address(RVA = "0xCBF290", Offset = "0xCBDC90", VA = "0x180CBF290")]
		public void ForceRelax(RelaxingPosition relaxingPosition, int destinationIndex)
		{
			//Discarded unreachable code: IL_0170
			//IL_0010: Expected O, but got I4
			//IL_0085: Expected O, but got I4
			RelaxingPosition relaxingPosition2 = CurrentRelaxingPosition;
			int num = 0;
			if (!(relaxingPosition2 == (UnityEngine.Object)num))
			{
				return;
			}
			RelaxingBehaviourData behaviourData = relaxingPosition.BehaviourData;
			if (CanRelax(behaviourData))
			{
				CurrentRelaxingPosition = relaxingPosition;
				RelaxingPosition relaxingPosition3 = CurrentRelaxingPosition;
				EventHandler b = CurrentRelaxingPositionDestroyedEvent;
				EventHandler relaxingPositionDestroyedEvent = relaxingPosition3.RelaxingPositionDestroyedEvent;
				Delegate @delegate = Delegate.Combine(relaxingPositionDestroyedEvent, b);
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				while ((object)@delegate != relaxingPositionDestroyedEvent)
				{
				}
				GridObjectScript component = CurrentRelaxingPosition.GetComponent<GridObjectScript>();
				int num2 = 0;
				if (component != (UnityEngine.Object)num2)
				{
					EventHandler value = CurrentRelaxingPositionTransformUpdate;
					component.OnTransformUpdate += value;
				}
				if (destinationIndex != 0)
				{
					Transform[] additionalDestinations = relaxingPosition.additionalDestinations;
					int num3 = destinationIndex - 1;
				}
				Transform characterDestination = relaxingPosition.characterDestination;
				Transform transform = base.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Transform transform2 = base.transform;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				float z3 = Vector3.up.z;
				if (relaxer != null)
				{
				}
				this.animator.ResetTrigger("Exit");
				List<RelaxingPosition.AdditionalData> additionalDatas = CurrentRelaxingPosition.AdditionalDatas;
				Action<RelaxingPosition.AdditionalData> action = (Action<RelaxingPosition.AdditionalData>)(object)(Action<T>)delegate(RelaxingPosition.AdditionalData x)
				{
					//Discarded unreachable code: IL_001e
					Animator animator2 = this.animator;
					float value2 = x.Value;
					string key = x.Key;
					animator2.SetFloat(key, value2);
				};
				((List<T>)(object)additionalDatas).ForEach((Action<>)(object)action);
				this.animator.SetBool("IsSitting", value: true);
				RelaxingBehaviourData behaviourData2 = CurrentRelaxingPosition.BehaviourData;
				Animator animator = this.animator;
				string forceTrigger = behaviourData2._forceTrigger;
				animator.SetTrigger(forceTrigger);
				EventHandler relaxingStateChangedEvent = this.RelaxingStateChangedEvent;
				Relaxing = true;
				if (relaxingStateChangedEvent == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60021EA")]
		[Cpp2IlInjected.Address(RVA = "0xCBED20", Offset = "0xCBD720", VA = "0x180CBED20")]
		[AsyncStateMachine(typeof(_003CEndRelax_003Ed__21))]
		public Task EndRelax()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60021EB")]
		[Cpp2IlInjected.Address(RVA = "0xCBEE20", Offset = "0xCBD820", VA = "0x180CBEE20")]
		public void ForceEndRelax()
		{
			//Discarded unreachable code: IL_00eb, IL_00f1
			//IL_0018: Expected O, but got I4
			//IL_008d: Expected O, but got I4
			//IL_00ae: Expected O, but got I4
			//IL_00c7: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			RelaxingPosition relaxingPosition = CurrentRelaxingPosition;
			int num4 = 0;
			if (!(relaxingPosition != (UnityEngine.Object)num4))
			{
				return;
			}
			RelaxingPosition relaxingPosition2 = CurrentRelaxingPosition;
			GameObject gameObject = base.gameObject;
			relaxingPosition2.Free(gameObject);
			RelaxingPosition relaxingPosition3 = CurrentRelaxingPosition;
			EventHandler eventHandler = CurrentRelaxingPositionDestroyedEvent;
			EventHandler relaxingPositionDestroyedEvent = relaxingPosition3.RelaxingPositionDestroyedEvent;
			Delegate @delegate = Delegate.Remove(relaxingPositionDestroyedEvent, eventHandler);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != relaxingPositionDestroyedEvent)
				{
				}
				GridObjectScript component = CurrentRelaxingPosition.GetComponent<GridObjectScript>();
				int num5 = 0;
				if (component != (UnityEngine.Object)num5)
				{
					EventHandler value = CurrentRelaxingPositionTransformUpdate;
					component.OnTransformUpdate -= value;
				}
				CurrentRelaxingPosition = (RelaxingPosition)num3;
				List<string> list = triggersToReset;
				bool flag = default(bool);
				if (flag)
				{
					animator.ResetTrigger((string)num2);
				}
				if (eventHandler == null)
				{
					RelaxingBehaviourData behaviourData = relaxingPosition2.BehaviourData;
					RelaxingBehaviourData behaviourData2 = relaxingPosition2.BehaviourData;
					int num6 = 0;
					if ((object)component != null)
					{
					}
					if (0 == 0)
					{
					}
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021EC")]
		[Cpp2IlInjected.Address(RVA = "0xCBEC20", Offset = "0xCBD620", VA = "0x180CBEC20")]
		[AsyncStateMachine(typeof(_003CEndRelaxImplementation_003Ed__23))]
		private Task EndRelaxImplementation()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60021ED")]
		[Cpp2IlInjected.Address(RVA = "0xCBEC10", Offset = "0xCBD610", VA = "0x180CBEC10")]
		private void CurrentRelaxingPositionDestroyedEvent(object sender, EventArgs e)
		{
			ForceEndRelax();
		}

		[Cpp2IlInjected.Token(Token = "0x60021EE")]
		[Cpp2IlInjected.Address(RVA = "0xCBEC10", Offset = "0xCBD610", VA = "0x180CBEC10")]
		private void CurrentRelaxingPositionTransformUpdate(object sender, EventArgs e)
		{
			ForceEndRelax();
		}

		[Cpp2IlInjected.Token(Token = "0x60021EF")]
		[Cpp2IlInjected.Address(RVA = "0xCBFA20", Offset = "0xCBE420", VA = "0x180CBFA20")]
		public RelaxingBehaviour()
		{
		}//Discarded unreachable code: IL_009a

	}
}
