using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C97")]
	public class TrailSystem : Mdl.Systems.System
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400468D")]
		[SerializeField]
		private Trail trail;

		[Cpp2IlInjected.Token(Token = "0x170007D2")]
		public Transform Target
		{
			[Cpp2IlInjected.Token(Token = "0x6003A4B")]
			[Cpp2IlInjected.Address(RVA = "0x13DCC60", Offset = "0x13DB660", VA = "0x1813DCC60")]
			get
			{
				//Discarded unreachable code: IL_000c
				return trail._target;
			}
			[Cpp2IlInjected.Token(Token = "0x6003A4C")]
			[Cpp2IlInjected.Address(RVA = "0x13DCF80", Offset = "0x13DB980", VA = "0x1813DCF80")]
			set
			{
				//Discarded unreachable code: IL_000d
				trail.Target = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007D3")]
		public Vector3? TargetPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6003A4D")]
			[Cpp2IlInjected.Address(RVA = "0x13DCC20", Offset = "0x13DB620", VA = "0x1813DCC20")]
			get
			{
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003A4E")]
			[Cpp2IlInjected.Address(RVA = "0x13DCDC0", Offset = "0x13DB7C0", VA = "0x1813DCDC0")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x140000A5")]
		public event EventHandler TrailSystemTargetChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6003A47")]
			[Cpp2IlInjected.Address(RVA = "0x13DCB80", Offset = "0x13DB580", VA = "0x1813DCB80")]
			[CompilerGenerated]
			add
			{
				EventHandler trailSystemTargetChanged = this.TrailSystemTargetChanged;
				Delegate @delegate = Delegate.Combine(trailSystemTargetChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != trailSystemTargetChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003A48")]
			[Cpp2IlInjected.Address(RVA = "0x13DCD20", Offset = "0x13DB720", VA = "0x1813DCD20")]
			[CompilerGenerated]
			remove
			{
				EventHandler trailSystemTargetChanged = this.TrailSystemTargetChanged;
				Delegate @delegate = Delegate.Remove(trailSystemTargetChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != trailSystemTargetChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x140000A6")]
		public event EventHandler TrailSystemAutoCancelled
		{
			[Cpp2IlInjected.Token(Token = "0x6003A49")]
			[Cpp2IlInjected.Address(RVA = "0x13DCAE0", Offset = "0x13DB4E0", VA = "0x1813DCAE0")]
			[CompilerGenerated]
			add
			{
				EventHandler trailSystemAutoCancelled = this.TrailSystemAutoCancelled;
				Delegate @delegate = Delegate.Combine(trailSystemAutoCancelled, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != trailSystemAutoCancelled)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003A4A")]
			[Cpp2IlInjected.Address(RVA = "0x13DCC80", Offset = "0x13DB680", VA = "0x1813DCC80")]
			[CompilerGenerated]
			remove
			{
				EventHandler trailSystemAutoCancelled = this.TrailSystemAutoCancelled;
				Delegate @delegate = Delegate.Remove(trailSystemAutoCancelled, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != trailSystemAutoCancelled)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A4F")]
		[Cpp2IlInjected.Address(RVA = "0x13DC640", Offset = "0x13DB040", VA = "0x1813DC640", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			//Discarded unreachable code: IL_0086
			Trail trail = this.trail;
			PlayerAvatar playerAvatar = avatar;
			trail.Init(playerAvatar);
			Trail trail2 = this.trail;
			EventHandler b = Trail_TargetChanged;
			EventHandler targetChanged = trail2.TargetChanged;
			Delegate @delegate = Delegate.Combine(targetChanged, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != targetChanged)
				{
				}
				Trail trail3 = this.trail;
				EventHandler b2 = Trail_AutoCancelled;
				EventHandler autoCancelled = trail3.AutoCancelled;
				Delegate delegate2 = Delegate.Combine(autoCancelled, b2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					while ((object)delegate2 != autoCancelled)
					{
					}
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A50")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnSystemPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003A51")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003A52")]
		[Cpp2IlInjected.Address(RVA = "0x13DC810", Offset = "0x13DB210", VA = "0x1813DC810", Slot = "5")]
		public override void OnSystemStop()
		{
			//Discarded unreachable code: IL_0075
			Trail trail = this.trail;
			EventHandler value = Trail_TargetChanged;
			EventHandler targetChanged = trail.TargetChanged;
			Delegate @delegate = Delegate.Remove(targetChanged, value);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != targetChanged)
				{
				}
				Trail trail2 = this.trail;
				EventHandler value2 = Trail_AutoCancelled;
				EventHandler autoCancelled = trail2.AutoCancelled;
				Delegate delegate2 = Delegate.Remove(autoCancelled, value2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					while ((object)delegate2 != autoCancelled)
					{
					}
					this.trail.Stop();
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A53")]
		[Cpp2IlInjected.Address(RVA = "0x13DCA60", Offset = "0x13DB460", VA = "0x1813DCA60")]
		private void Trail_TargetChanged(object sender, EventArgs e)
		{
			if (this.TrailSystemTargetChanged == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A54")]
		[Cpp2IlInjected.Address(RVA = "0x13DC9E0", Offset = "0x13DB3E0", VA = "0x1813DC9E0")]
		private void Trail_AutoCancelled(object sender, EventArgs e)
		{
			if (this.TrailSystemAutoCancelled == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A55")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public TrailSystem()
		{
		}
	}
}
