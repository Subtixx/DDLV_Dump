using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Activities;
using Mdl.Systems;
using Mdl.Ui;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C4F")]
	public class InteractPreview
	{
		[Cpp2IlInjected.Token(Token = "0x2000C50")]
		public class InteractPreviewEventArgs : EventArgs
		{
			[Cpp2IlInjected.Token(Token = "0x40044AC")]
			private static InteractPreviewEventArgs _cleared;

			[Cpp2IlInjected.Token(Token = "0x17000799")]
			public GameObject GameObject
			{
				[Cpp2IlInjected.Token(Token = "0x600388D")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CGameObject_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600388E")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				private set
				{
					_003CGameObject_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700079A")]
			public GameObject InteractionPosition
			{
				[Cpp2IlInjected.Token(Token = "0x600388F")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CInteractionPosition_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6003890")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				private set
				{
					_003CInteractionPosition_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700079B")]
			public bool IsValid
			{
				[Cpp2IlInjected.Token(Token = "0x6003891")]
				[Cpp2IlInjected.Address(RVA = "0xE5FD40", Offset = "0xE5E740", VA = "0x180E5FD40")]
				get
				{
					//IL_0010: Expected O, but got I4
					GameObject gameObject = GameObject;
					int num = 0;
					bool flag = gameObject != (UnityEngine.Object)num;
					if (!flag)
					{
						return flag;
					}
					return Enumerable.Any<InteractPreviewData>((IEnumerable<>)(object)PreviewData);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700079C")]
			public object[] PreviewArgs
			{
				[Cpp2IlInjected.Token(Token = "0x6003892")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CPreviewArgs_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6003893")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				private set
				{
					_003CPreviewArgs_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700079D")]
			public InteractPreviewData[] PreviewData
			{
				[Cpp2IlInjected.Token(Token = "0x6003894")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003CPreviewData_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6003895")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				private set
				{
					_003CPreviewData_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700079E")]
			public bool ShowOutline
			{
				[Cpp2IlInjected.Token(Token = "0x6003896")]
				[Cpp2IlInjected.Address(RVA = "0xE5FDD0", Offset = "0xE5E7D0", VA = "0x180E5FDD0")]
				get
				{
					//Discarded unreachable code: IL_001f
					InteractPreviewData[] array = PreviewData;
					if (array.Length == 0)
					{
						int num = 0;
					}
					return array[0]._showOutline;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700079F")]
			public static InteractPreviewEventArgs Cleared
			{
				[Cpp2IlInjected.Token(Token = "0x6003897")]
				[Cpp2IlInjected.Address(RVA = "0xE5FCE0", Offset = "0xE5E6E0", VA = "0x180E5FCE0")]
				get
				{
					return _cleared;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6003898")]
			[Cpp2IlInjected.Address(RVA = "0xE5F8B0", Offset = "0xE5E2B0", VA = "0x180E5F8B0")]
			internal unsafe InteractPreviewEventArgs(GameObject gameObject, IEnumerable<PlayerTaskDefinition> possibleTasks, WeakReference<IPlayerInteraction> possibleObject)
			{
				//Discarded unreachable code: IL_00ca
				//IL_0039: Expected O, but got I4
				//IL_009c: Expected O, but got I4
				//IL_009c: Expected O, but got I4
				//IL_00a7: Expected O, but got I4
				int num = 0;
				PreviewArgs = Array.Empty<object>();
				PreviewData = Array.Empty<InteractPreviewData>();
				base._002Ector();
				GameObject = gameObject;
				InteractionPosition = gameObject;
				int num2 = 0;
				if (!(gameObject != (UnityEngine.Object)num2))
				{
					return;
				}
				bool flag = default(bool);
				if (gameObject.TryGetComponent<PlayerTaskCollider>(out *(PlayerTaskCollider*)num) && flag)
				{
					GameObject gameObject2 = default(GameObject);
					InteractionPosition = gameObject2;
				}
				uint capacity = default(uint);
				List<InteractPreviewData> list = (List<InteractPreviewData>)(object)new List<T>((int)capacity);
				int capacity2 = default(int);
				List<object> list2 = (List<object>)(object)new List<T>(capacity2);
				capacity2 = 0;
				InteractPreviewEventArgs.FillPreviewDataFromPlayerTaskDefinitions((List<>)(object)list, (List<>)(object)list2, gameObject, (IEnumerable<>)possibleTasks);
				if (possibleObject != null && ((WeakReference<T>)(object)possibleObject).TryGetTarget(out *(T*)num))
				{
					uint num3 = default(uint);
					if (num < (int)num3)
					{
						num += num;
						num++;
					}
					int num4 = 0;
					if ((UnityEngine.Object)num != (UnityEngine.Object)num4)
					{
						((List<T>)(object)list).Add((T)num);
					}
				}
				InteractPreviewData[] array = (PreviewData = (InteractPreviewData[])(object)((List<T>)(object)list).ToArray());
				object[] array2 = (PreviewArgs = (object[])(object)((List<T>)(object)list2).ToArray());
			}

			[Cpp2IlInjected.Token(Token = "0x6003899")]
			[Cpp2IlInjected.Address(RVA = "0xE5F490", Offset = "0xE5DE90", VA = "0x180E5F490")]
			private static void FillPreviewDataFromPlayerTaskDefinitions(List<InteractPreviewData> interactPreviewDatas, List<object> interactionPreviewArgs, GameObject gameObject, IEnumerable<PlayerTaskDefinition> interactionDefinitions)
			{
				//Discarded unreachable code: IL_0065
				//IL_0016: Expected O, but got I4
				//IL_0016: Expected O, but got I4
				//IL_0052: Expected O, but got I4
				bool flag = default(bool);
				bool flag2 = default(bool);
				int num3 = default(int);
				bool flag3 = default(bool);
				bool flag4 = default(bool);
				while (true)
				{
					int num = 0;
					if (interactionDefinitions != null)
					{
						PlayerTaskDefinition playerTaskDefinition = Enumerable.FirstOrDefault<PlayerTaskDefinition>((IEnumerable<>)interactionDefinitions);
					}
					int num2 = 0;
					if (!((UnityEngine.Object)num != (UnityEngine.Object)num2) || !flag)
					{
						break;
					}
					if (flag2)
					{
						object[] array = new object[2];
						if (array != null && array == null)
						{
							continue;
						}
						array[0] = array;
						if (num3 != 0 && num3 == 0)
						{
							continue;
						}
						array[1] = num3;
						((List<T>)(object)interactionPreviewArgs).AddRange((IEnumerable<>)(object)array);
					}
					if (flag3 && !flag4)
					{
					}
					break;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600389A")]
			[Cpp2IlInjected.Address(RVA = "0xE5F330", Offset = "0xE5DD30", VA = "0x180E5F330")]
			private unsafe static void FillPreviewDataFromPlayerInteraction(List<InteractPreviewData> interactPreviewDatas, WeakReference<IPlayerInteraction> possibleInteractionObject)
			{
				//Discarded unreachable code: IL_0021
				int num = 0;
				if (possibleInteractionObject != null && ((WeakReference<T>)(object)possibleInteractionObject).TryGetTarget(out *(T*)num))
				{
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
					bool flag = default(bool);
					if (!flag)
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600389B")]
			[Cpp2IlInjected.Address(RVA = "0xE5F840", Offset = "0xE5E240", VA = "0x180E5F840")]
			static InteractPreviewEventArgs()
			{
				//IL_0009: Expected O, but got I4
				//IL_0009: Expected O, but got I4
				//IL_0009: Expected O, but got I4
				int num3 = default(int);
				int num2 = default(int);
				int num = default(int);
				InteractPreviewEventArgs cleared = new InteractPreviewEventArgs((GameObject)num, (IEnumerable<>)num2, (WeakReference<>)num3);
				num3 = 0;
				num2 = 0;
				num = 0;
				_cleared = cleared;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40044A3")]
		private List<PlayerTaskDefinition> possibleInteractionTasks = (List<PlayerTaskDefinition>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40044A4")]
		private WeakReference<IPlayerInteraction> possibleInteractionInterface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40044A5")]
		private WeakReference<GameObject> interactionObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40044A6")]
		private WeakReference<GameObject> outlinedInteractionObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40044A7")]
		private CountedBool IsDisabled;

		[Cpp2IlInjected.Token(Token = "0x17000798")]
		private bool AnyPossibleInteractions
		{
			[Cpp2IlInjected.Token(Token = "0x6003881")]
			[Cpp2IlInjected.Address(RVA = "0x11B8380", Offset = "0x11B6D80", VA = "0x1811B8380")]
			get
			{
				bool flag = Enumerable.Any<PlayerTaskDefinition>((IEnumerable<>)possibleInteractionTasks);
				if (flag)
				{
					return true;
				}
				return flag;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000097")]
		public event EventHandler<InteractPreviewEventArgs> OnInteractPreviewChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600387F")]
			[Cpp2IlInjected.Address(RVA = "0x11B82E0", Offset = "0x11B6CE0", VA = "0x1811B82E0")]
			[CompilerGenerated]
			add
			{
				EventHandler<InteractPreviewEventArgs> onInteractPreviewChanged = this.OnInteractPreviewChanged;
				Delegate @delegate = Delegate.Combine(onInteractPreviewChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onInteractPreviewChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003880")]
			[Cpp2IlInjected.Address(RVA = "0x11B83D0", Offset = "0x11B6DD0", VA = "0x1811B83D0")]
			[CompilerGenerated]
			remove
			{
				EventHandler<InteractPreviewEventArgs> onInteractPreviewChanged = this.OnInteractPreviewChanged;
				Delegate @delegate = Delegate.Remove(onInteractPreviewChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onInteractPreviewChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003882")]
		[Cpp2IlInjected.Address(RVA = "0x11B8130", Offset = "0x11B6B30", VA = "0x1811B8130")]
		internal InteractPreview()
		{
			//IL_0013: Expected O, but got I4
			//IL_0024: Expected O, but got I4
			int num = default(int);
			WeakReference<GameObject> weakReference = (WeakReference<GameObject>)(object)new WeakReference<T>((T)num);
			num = 0;
			interactionObject = weakReference;
			int num2 = default(int);
			WeakReference<GameObject> weakReference2 = (WeakReference<GameObject>)(object)new WeakReference<T>((T)num2);
			num2 = 0;
			outlinedInteractionObject = weakReference2;
			int debug = default(int);
			CountedBool isDisabled = new CountedBool("InteractPreview.IsDisabled", (byte)debug != 0);
			debug = 0;
			IsDisabled = isDisabled;
			base._002Ector();
			EventHandler<InteractPreviewEventArgs> eventHandler = (EventHandler<InteractPreviewEventArgs>)(object)(EventHandler<TEventArgs>)delegate(object o, InteractPreviewEventArgs e)
			{
				//Discarded unreachable code: IL_0054
				//IL_0023: Expected O, but got I4
				//IL_0053: Expected O, but got I4
				WeakReference<GameObject> weakReference3 = outlinedInteractionObject;
				bool flag = default(bool);
				bool flag2 = default(bool);
				if (!flag || flag2)
				{
				}
				WeakReference<GameObject> weakReference4 = outlinedInteractionObject;
				int num3 = 0;
				((WeakReference<T>)(object)weakReference4).SetTarget((T)num3);
				if (!e.IsValid)
				{
					BaseUiRoot.Instance.DestroyInteractionPreview();
				}
				else
				{
					BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
					int num4 = 0;
					bool flag3 = default(bool);
					while (!flag3)
					{
					}
					((WeakReference<T>)(object)outlinedInteractionObject).SetTarget((T)num4);
				}
			};
			this.add_OnInteractPreviewChanged((EventHandler<>)(object)eventHandler);
		}

		[Cpp2IlInjected.Token(Token = "0x6003883")]
		[Cpp2IlInjected.Address(RVA = "0x11B75A0", Offset = "0x11B5FA0", VA = "0x1811B75A0")]
		internal void Disable()
		{
			//Discarded unreachable code: IL_0037
			CountedBool.RefState refState = IsDisabled.AddReference();
			if (Enumerable.Any<PlayerTaskDefinition>((IEnumerable<>)possibleInteractionTasks) || (long)possibleInteractionInterface > 0)
			{
				WeakReference<GameObject> weakReference = interactionObject;
				bool flag = default(bool);
				if (flag)
				{
					FireInteractionObjectCleared();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003884")]
		[Cpp2IlInjected.Address(RVA = "0x11B7650", Offset = "0x11B6050", VA = "0x1811B7650")]
		internal void Enable()
		{
			//Discarded unreachable code: IL_0031
			CountedBool.RefState refState = IsDisabled.ReleaseReference();
			if (Enumerable.Any<PlayerTaskDefinition>((IEnumerable<>)possibleInteractionTasks) || (long)possibleInteractionInterface > 0)
			{
				WeakReference<GameObject> weakReference = interactionObject;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003885")]
		[Cpp2IlInjected.Address(RVA = "0x11B7A70", Offset = "0x11B6470", VA = "0x1811B7A70")]
		internal void SetCurrentInteractible(GameObject gameObject, bool actionsLocked)
		{
			//Discarded unreachable code: IL_00c3
			//IL_0014: Expected O, but got I8
			//IL_0024: Expected O, but got I4
			//IL_004a: Expected O, but got I4
			((List<T>)(object)possibleInteractionTasks).Clear();
			possibleInteractionInterface = (WeakReference<IPlayerInteraction>)0;
			AutomaticPickup component = gameObject.GetComponent<AutomaticPickup>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				return;
			}
			((WeakReference<T>)(object)interactionObject).SetTarget((T)(object)gameObject);
			if (!actionsLocked)
			{
				PlayerTaskCollider component2 = gameObject.GetComponent<PlayerTaskCollider>();
				int num2 = 0;
				if (component2 != (UnityEngine.Object)num2)
				{
					List<PlayerTaskDefinition> list = possibleInteractionTasks;
					IEnumerable<PlayerTaskDefinition> allTasks = (IEnumerable<PlayerTaskDefinition>)component2.GetAllTasks();
					Func<PlayerTaskDefinition, bool> _003C_003E9__13_ = _003C_003Ec._003C_003E9__13_0;
					if (_003C_003E9__13_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(PlayerTaskDefinition t)
						{
							//Discarded unreachable code: IL_0011
							//IL_0010: Expected O, but got I4
							InteractPreviewData interactPreviewData = t.InteractPreviewData;
							int num3 = 0;
							return interactPreviewData != (UnityEngine.Object)num3;
						};
					}
					IEnumerable<PlayerTaskDefinition> enumerable = (IEnumerable<PlayerTaskDefinition>)Enumerable.Where<PlayerTaskDefinition>((IEnumerable<>)allTasks, (Func<, >)(object)_003C_003E9__13_);
					((List<T>)(object)list).AddRange((IEnumerable<>)enumerable);
				}
				WeakReference<IPlayerInteraction> weakReference = (possibleInteractionInterface = (WeakReference<IPlayerInteraction>)(object)new WeakReference<T>((T)gameObject.GetComponent<IPlayerInteraction>()));
			}
			WeakReference<IPlayerInteraction> weakReference2 = possibleInteractionInterface;
			List<PlayerTaskDefinition> list2 = possibleInteractionTasks;
			this.FireInteractionObjectChanged(gameObject, (IEnumerable<>)list2, (WeakReference<>)(object)weakReference2);
		}

		[Cpp2IlInjected.Token(Token = "0x6003886")]
		[Cpp2IlInjected.Address(RVA = "0x11B7DD0", Offset = "0x11B67D0", VA = "0x1811B7DD0")]
		private bool ShouldShowPreviewFor(GameObject gameObject)
		{
			//Discarded unreachable code: IL_0014
			//IL_0010: Expected O, but got I4
			AutomaticPickup component = gameObject.GetComponent<AutomaticPickup>();
			int num = 0;
			return !(component != (UnityEngine.Object)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6003887")]
		[Cpp2IlInjected.Address(RVA = "0x11B7540", Offset = "0x11B5F40", VA = "0x1811B7540")]
		internal void ClearCurrentInteractible()
		{
			//Discarded unreachable code: IL_0017
			//IL_0010: Expected O, but got I4
			WeakReference<GameObject> weakReference = interactionObject;
			int num = 0;
			((WeakReference<T>)(object)weakReference).SetTarget((T)num);
			FireInteractionObjectCleared();
		}

		[Cpp2IlInjected.Token(Token = "0x6003888")]
		[Cpp2IlInjected.Address(RVA = "0x11B7720", Offset = "0x11B6120", VA = "0x1811B7720")]
		private void FireInteractionObjectChanged(GameObject gameObject, IEnumerable<PlayerTaskDefinition> possibleInteractions, WeakReference<IPlayerInteraction> possibleInteractionObject)
		{
			if (!IsDisabled)
			{
				EventHandler<InteractPreviewEventArgs> onInteractPreviewChanged = this.OnInteractPreviewChanged;
				if (onInteractPreviewChanged != null)
				{
					InteractPreviewEventArgs e = new InteractPreviewEventArgs(gameObject, (IEnumerable<>)possibleInteractions, (WeakReference<>)(object)possibleInteractionObject);
					onInteractPreviewChanged(this, (TEventArgs)e);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003889")]
		[Cpp2IlInjected.Address(RVA = "0x11B77E0", Offset = "0x11B61E0", VA = "0x1811B77E0")]
		private void FireInteractionObjectCleared()
		{
			EventHandler<InteractPreviewEventArgs> onInteractPreviewChanged = this.OnInteractPreviewChanged;
			if (onInteractPreviewChanged != null)
			{
				InteractPreviewEventArgs cleared = InteractPreviewEventArgs._cleared;
				onInteractPreviewChanged(this, (TEventArgs)cleared);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600388A")]
		[Cpp2IlInjected.Address(RVA = "0x11B79E0", Offset = "0x11B63E0", VA = "0x1811B79E0")]
		private void RegisterEventHandler()
		{
			EventHandler<InteractPreviewEventArgs> eventHandler = (EventHandler<InteractPreviewEventArgs>)(object)(EventHandler<TEventArgs>)delegate(object o, InteractPreviewEventArgs e)
			{
				//Discarded unreachable code: IL_0054
				//IL_0023: Expected O, but got I4
				//IL_0053: Expected O, but got I4
				WeakReference<GameObject> weakReference = outlinedInteractionObject;
				bool flag = default(bool);
				bool flag2 = default(bool);
				if (!flag || flag2)
				{
				}
				WeakReference<GameObject> weakReference2 = outlinedInteractionObject;
				int num = 0;
				((WeakReference<T>)(object)weakReference2).SetTarget((T)num);
				if (!e.IsValid)
				{
					BaseUiRoot.Instance.DestroyInteractionPreview();
				}
				else
				{
					BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
					int num2 = 0;
					bool flag3 = default(bool);
					while (!flag3)
					{
					}
					((WeakReference<T>)(object)outlinedInteractionObject).SetTarget((T)num2);
				}
			};
			this.add_OnInteractPreviewChanged((EventHandler<>)(object)eventHandler);
		}

		[Cpp2IlInjected.Token(Token = "0x600388B")]
		[Cpp2IlInjected.Address(RVA = "0x11B78C0", Offset = "0x11B62C0", VA = "0x1811B78C0")]
		[Conditional("DebugInteractionPreview")]
		private void RegisterDebugEventHandler()
		{
			//Discarded unreachable code: IL_0027
			EventHandler<InteractPreviewEventArgs> _003C_003E9__20_ = _003C_003Ec._003C_003E9__20_0;
			if (_003C_003E9__20_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(EventHandler<TEventArgs>)delegate(object o, InteractPreviewEventArgs e)
				{
					//Discarded unreachable code: IL_00b3
					//IL_0010: Expected O, but got I4
					//IL_008c: Expected O, but got F4
					GameObject _003CGameObject_003Ek__BackingField = e.GameObject;
					int num = 0;
					if (_003CGameObject_003Ek__BackingField != (UnityEngine.Object)num && Enumerable.Any<InteractPreviewData>((IEnumerable<>)(object)e.PreviewData))
					{
						GameObject _003CGameObject_003Ek__BackingField2 = e.GameObject;
						Transform transform = _003CGameObject_003Ek__BackingField2.transform;
						Vector3 vector = default(Vector3);
						float z = vector.z;
						InteractPreviewData[] _003CPreviewData_003Ek__BackingField = e.PreviewData;
						Func<InteractPreviewData, string> _003C_003E9__20_2 = _003C_003Ec._003C_003E9__20_1;
						if (_003C_003E9__20_2 == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((InteractPreviewData pi) => pi._text);
						}
						IEnumerable<InteractPreviewData> enumerable = (IEnumerable<InteractPreviewData>)Enumerable.Select<InteractPreviewData, string>((IEnumerable<>)(object)_003CPreviewData_003Ek__BackingField, (Func<, >)(object)_003C_003E9__20_2);
						string arg = string.Join(", ", (IEnumerable<>)enumerable);
						string msg = $"Possible interactions for {_003CGameObject_003Ek__BackingField2} at position {z} are: {arg}";
						object[] args = Array.Empty<object>();
						GameLog.Info(msg, args);
					}
					else
					{
						object[] args2 = Array.Empty<object>();
						GameLog.Info("No possible interactions!", args2);
					}
				};
			}
			this.add_OnInteractPreviewChanged((EventHandler<>)(object)_003C_003E9__20_);
		}
	}
}
