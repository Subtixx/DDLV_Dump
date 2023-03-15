using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000971")]
	public abstract class System : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000972")]
		public delegate void SystemEvent(System system);

		[Cpp2IlInjected.Token(Token = "0x2000973")]
		private enum SystemPauseStyle
		{
			[Cpp2IlInjected.Token(Token = "0x4003443")]
			Uncounted,
			[Cpp2IlInjected.Token(Token = "0x4003444")]
			ReferenceCounted
		}

		[Cpp2IlInjected.Token(Token = "0x2000974")]
		private abstract class SystemPauser
		{
			[Cpp2IlInjected.Token(Token = "0x6002BE6")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract bool Pause();

			[Cpp2IlInjected.Token(Token = "0x6002BE7")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract bool Resume();

			[Cpp2IlInjected.Token(Token = "0x6002BE8")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract bool IsPaused();

			[Cpp2IlInjected.Token(Token = "0x6002BE9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			protected SystemPauser()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000975")]
		private class UncountedSystemPauser : SystemPauser
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003445")]
			private bool isPaused;

			[Cpp2IlInjected.Token(Token = "0x6002BEA")]
			[Cpp2IlInjected.Address(RVA = "0x122D500", Offset = "0x122BF00", VA = "0x18122D500", Slot = "4")]
			public override bool Pause()
			{
				bool flag = isPaused;
				isPaused = true;
				return !flag;
			}

			[Cpp2IlInjected.Token(Token = "0x6002BEB")]
			[Cpp2IlInjected.Address(RVA = "0x122D510", Offset = "0x122BF10", VA = "0x18122D510", Slot = "5")]
			public override bool Resume()
			{
				bool result = isPaused;
				isPaused = false;
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6002BEC")]
			[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0", Slot = "6")]
			public override bool IsPaused()
			{
				return isPaused;
			}

			[Cpp2IlInjected.Token(Token = "0x6002BED")]
			[Cpp2IlInjected.Address(RVA = "0x122D520", Offset = "0x122BF20", VA = "0x18122D520", Slot = "3")]
			public override string ToString()
			{
				//IL_0012: Expected O, but got I4
				bool flag = isPaused;
				return $"{flag}";
			}

			[Cpp2IlInjected.Token(Token = "0x6002BEE")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public UncountedSystemPauser()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000976")]
		private class CountedSystemPauser : SystemPauser
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003446")]
			private CountedBool isPaused;

			[Cpp2IlInjected.Token(Token = "0x6002BEF")]
			[Cpp2IlInjected.Address(RVA = "0x1219540", Offset = "0x1217F40", VA = "0x181219540")]
			public CountedSystemPauser(string name)
			{
				int debug = default(int);
				CountedBool countedBool = new CountedBool(name, (byte)debug != 0);
				debug = 0;
				isPaused = countedBool;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6002BF0")]
			[Cpp2IlInjected.Address(RVA = "0x12194A0", Offset = "0x1217EA0", VA = "0x1812194A0", Slot = "4")]
			public override bool Pause()
			{
				//Discarded unreachable code: IL_000f
				return isPaused.AddReference() == CountedBool.RefState.FirstReference;
			}

			[Cpp2IlInjected.Token(Token = "0x6002BF1")]
			[Cpp2IlInjected.Address(RVA = "0x12194D0", Offset = "0x1217ED0", VA = "0x1812194D0", Slot = "5")]
			public override bool Resume()
			{
				//Discarded unreachable code: IL_000f
				return isPaused.ReleaseReference() == CountedBool.RefState.LastReference;
			}

			[Cpp2IlInjected.Token(Token = "0x6002BF2")]
			[Cpp2IlInjected.Address(RVA = "0x1219490", Offset = "0x1217E90", VA = "0x181219490", Slot = "6")]
			public override bool IsPaused()
			{
				return isPaused;
			}

			[Cpp2IlInjected.Token(Token = "0x6002BF3")]
			[Cpp2IlInjected.Address(RVA = "0x1219500", Offset = "0x1217F00", VA = "0x181219500", Slot = "3")]
			public override string ToString()
			{
				CountedBool arg = isPaused;
				return $"{arg}";
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4003439")]
		[SerializeField]
		private SystemPauseStyle pauseStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400343A")]
		private SystemPauser pauser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400343B")]
		protected PlayerAvatar avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400343C")]
		protected Camera playerCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400343D")]
		protected Transform playerCameraTransform;

		[Cpp2IlInjected.Token(Token = "0x17000642")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4003438")]
		public bool IsStarted
		{
			[Cpp2IlInjected.Token(Token = "0x6002BCA")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002BCB")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000643")]
		public bool IsPaused
		{
			[Cpp2IlInjected.Token(Token = "0x6002BCC")]
			[Cpp2IlInjected.Address(RVA = "0x106D4E0", Offset = "0x106BEE0", VA = "0x18106D4E0")]
			get
			{
				SystemPauser systemPauser = pauser;
				if (systemPauser == null)
				{
					int num = 0;
				}
				return systemPauser.Pause();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000066")]
		public event SystemEvent SystemStartedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6002BCD")]
			[Cpp2IlInjected.Address(RVA = "0x106D3A0", Offset = "0x106BDA0", VA = "0x18106D3A0")]
			[CompilerGenerated]
			add
			{
				SystemEvent systemStartedEvent = this.SystemStartedEvent;
				Delegate @delegate = Delegate.Combine(systemStartedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != systemStartedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002BCE")]
			[Cpp2IlInjected.Address(RVA = "0x106D640", Offset = "0x106C040", VA = "0x18106D640")]
			[CompilerGenerated]
			remove
			{
				SystemEvent systemStartedEvent = this.SystemStartedEvent;
				Delegate @delegate = Delegate.Remove(systemStartedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != systemStartedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000067")]
		public event SystemEvent SystemStoppedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6002BCF")]
			[Cpp2IlInjected.Address(RVA = "0x106D440", Offset = "0x106BE40", VA = "0x18106D440")]
			[CompilerGenerated]
			add
			{
				SystemEvent systemStoppedEvent = this.SystemStoppedEvent;
				Delegate @delegate = Delegate.Combine(systemStoppedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != systemStoppedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002BD0")]
			[Cpp2IlInjected.Address(RVA = "0x106D6E0", Offset = "0x106C0E0", VA = "0x18106D6E0")]
			[CompilerGenerated]
			remove
			{
				SystemEvent systemStoppedEvent = this.SystemStoppedEvent;
				Delegate @delegate = Delegate.Remove(systemStoppedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != systemStoppedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000068")]
		public event SystemEvent SystemPausedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6002BD1")]
			[Cpp2IlInjected.Address(RVA = "0x106D260", Offset = "0x106BC60", VA = "0x18106D260")]
			[CompilerGenerated]
			add
			{
				SystemEvent systemPausedEvent = this.SystemPausedEvent;
				Delegate @delegate = Delegate.Combine(systemPausedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != systemPausedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002BD2")]
			[Cpp2IlInjected.Address(RVA = "0x106D500", Offset = "0x106BF00", VA = "0x18106D500")]
			[CompilerGenerated]
			remove
			{
				SystemEvent systemPausedEvent = this.SystemPausedEvent;
				Delegate @delegate = Delegate.Remove(systemPausedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != systemPausedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000069")]
		public event SystemEvent SystemResumedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6002BD3")]
			[Cpp2IlInjected.Address(RVA = "0x106D300", Offset = "0x106BD00", VA = "0x18106D300")]
			[CompilerGenerated]
			add
			{
				SystemEvent systemResumedEvent = this.SystemResumedEvent;
				Delegate @delegate = Delegate.Combine(systemResumedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != systemResumedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002BD4")]
			[Cpp2IlInjected.Address(RVA = "0x106D5A0", Offset = "0x106BFA0", VA = "0x18106D5A0")]
			[CompilerGenerated]
			remove
			{
				SystemEvent systemResumedEvent = this.SystemResumedEvent;
				Delegate @delegate = Delegate.Remove(systemResumedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != systemResumedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BD5")]
		[Cpp2IlInjected.Address(RVA = "0x106CFB0", Offset = "0x106B9B0", VA = "0x18106CFB0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0039
			if (IsStarted)
			{
				IsStarted = false;
				OnSystemStop();
				GameObject gameObject = base.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				this.SystemStoppedEvent?.Invoke(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BD6")]
		[Cpp2IlInjected.Address(RVA = "0x106CF50", Offset = "0x106B950", VA = "0x18106CF50")]
		public void Init(PlayerAvatar avatar, Camera playerCamera)
		{
			this.avatar = avatar;
			this.playerCamera = playerCamera;
			Transform transform = (playerCameraTransform = playerCamera.transform);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002BD7")]
		[Cpp2IlInjected.Address(RVA = "0x106D130", Offset = "0x106BB30", VA = "0x18106D130")]
		public void StartSystem(ISystemData data)
		{
			//Discarded unreachable code: IL_005d
			if (!IsStarted)
			{
				if (pauseStyle != SystemPauseStyle.ReferenceCounted)
				{
					UncountedSystemPauser uncountedSystemPauser = new UncountedSystemPauser();
				}
				CountedSystemPauser countedSystemPauser = (CountedSystemPauser)(pauser = new CountedSystemPauser(GetType().Name));
				IsStarted = true;
				OnSystemStart(data);
				base.gameObject.SetActive(value: true);
				this.SystemStartedEvent?.Invoke(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BD8")]
		[Cpp2IlInjected.Address(RVA = "0x106CFB0", Offset = "0x106B9B0", VA = "0x18106CFB0")]
		public void StopSystem()
		{
			//Discarded unreachable code: IL_0039
			if (IsStarted)
			{
				IsStarted = false;
				OnSystemStop();
				GameObject gameObject = base.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				this.SystemStoppedEvent?.Invoke(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BD9")]
		[Cpp2IlInjected.Address(RVA = "0x106D030", Offset = "0x106BA30", VA = "0x18106D030")]
		public void PauseSystem()
		{
			//Discarded unreachable code: IL_0041
			if (IsStarted && pauser.Pause())
			{
				OnSystemPause();
				GameObject gameObject = base.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				this.SystemPausedEvent?.Invoke(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BDA")]
		[Cpp2IlInjected.Address(RVA = "0x106D0B0", Offset = "0x106BAB0", VA = "0x18106D0B0")]
		public void ResumeSystem()
		{
			//Discarded unreachable code: IL_003d
			if (IsStarted && pauser.Resume())
			{
				OnSystemResume();
				base.gameObject.SetActive(value: true);
				this.SystemResumedEvent?.Invoke(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BDB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void OnSystemStart(ISystemData data);

		[Cpp2IlInjected.Token(Token = "0x6002BDC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void OnSystemStop();

		[Cpp2IlInjected.Token(Token = "0x6002BDD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void OnSystemPause();

		[Cpp2IlInjected.Token(Token = "0x6002BDE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void OnSystemResume();

		[Cpp2IlInjected.Token(Token = "0x6002BDF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_ONSCREEN_SYSTEMS")]
		private void OnscreenDebug(string name, string value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002BE0")]
		[Cpp2IlInjected.Address(RVA = "0x106CE90", Offset = "0x106B890", VA = "0x18106CE90")]
		private SystemPauser CreatePauser()
		{
			CountedSystemPauser countedSystemPauser = new CountedSystemPauser(new UncountedSystemPauser().GetType().Name);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002BE1")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected System()
		{
		}
	}
}
