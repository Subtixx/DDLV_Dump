using Cpp2IlInjected;
using Mdl.Grid;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000277")]
	[ExecuteInEditMode]
	public class RadialMenuNavItem : CustomButton
	{
		[Cpp2IlInjected.Token(Token = "0x2000278")]
		public enum ExposureType
		{
			[Cpp2IlInjected.Token(Token = "0x4000B31")]
			All,
			[Cpp2IlInjected.Token(Token = "0x4000B32")]
			VillageOnly,
			[Cpp2IlInjected.Token(Token = "0x4000B33")]
			GridEditableOnly
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000B2A")]
		private bool _isAvailable = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000B2B")]
		[Range(-360f, 360f)]
		public int AngleRangeMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000B2C")]
		[Range(0f, 360f)]
		public int AngleRangeMax = 360;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000B2D")]
		public ShortcutDefinition ShortcutDefinition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000B2E")]
		public ExposureType Exposure;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4000B2F")]
		public HudApparitionPhases HudApparitionPhases;

		[Cpp2IlInjected.Token(Token = "0x170002EA")]
		internal bool IsAvailabe
		{
			[Cpp2IlInjected.Token(Token = "0x6000FB1")]
			[Cpp2IlInjected.Address(RVA = "0xF32FF0", Offset = "0xF319F0", VA = "0x180F32FF0")]
			get
			{
				return _isAvailable;
			}
			[Cpp2IlInjected.Token(Token = "0x6000FB2")]
			[Cpp2IlInjected.Address(RVA = "0xF33000", Offset = "0xF31A00", VA = "0x180F33000")]
			set
			{
				_isAvailable = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB3")]
		[Cpp2IlInjected.Address(RVA = "0xF32E10", Offset = "0xF31810", VA = "0x180F32E10", Slot = "19")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0077
			int num = 0;
			if (Application.isPlaying)
			{
				ExposureType exposure = Exposure;
				if (exposure == ExposureType.VillageOnly)
				{
				}
				if (exposure == ExposureType.GridEditableOnly)
				{
					GridEditMode gridEditMode = default(GridEditMode);
					bool canStartEditMode = gridEditMode.CanStartEditMode;
				}
				int num2 = 0;
				if (Application.isPlaying && _isAvailable)
				{
					Client client = default(Client);
					ProfilePlayer player_ = client.profile.player_;
					HudApparitionPhases hudApparitionPhases = HudApparitionPhases;
					bool flag = (_isAvailable = player_.HasHudApparition(hudApparitionPhases));
				}
				bool isActivated = (base.IsInteractable = _isAvailable);
				base.IsActivated = isActivated;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB4")]
		[Cpp2IlInjected.Address(RVA = "0xF32DA0", Offset = "0xF317A0", VA = "0x180F32DA0")]
		public bool IsInRange(int degree)
		{
			if (_isAvailable)
			{
				int angleRangeMin = AngleRangeMin;
				int num = 0;
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB5")]
		[Cpp2IlInjected.Address(RVA = "0xF32FD0", Offset = "0xF319D0", VA = "0x180F32FD0")]
		public RadialMenuNavItem()
		{
		}//IL_0014: Expected I4, but got I8

	}
}
