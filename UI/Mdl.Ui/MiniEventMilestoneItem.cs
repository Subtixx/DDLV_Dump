using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Meta;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000478")]
	public class MiniEventMilestoneItem : MonoBehaviour, IHasText, IHasSpriteURI, IHasProgress
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40016B1")]
		public UnityEvent OnStateNotStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40016B2")]
		public UnityEvent OnStateOngoing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40016B3")]
		public UnityEvent OnStateCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40016B4")]
		public UnityEvent OnStateClaimed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40016B5")]
		public UnityEvent OnDisplayRefresh;

		[Cpp2IlInjected.Token(Token = "0x170004C7")]
		public MiniEventMilestoneModel Model
		{
			[Cpp2IlInjected.Token(Token = "0x6001CF1")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CModel_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CF2")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			set
			{
				_003CModel_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CF3")]
		[Cpp2IlInjected.Address(RVA = "0x1292640", Offset = "0x1291040", VA = "0x181292640")]
		public void RefreshDisplay()
		{
			MiniEventMilestoneModel miniEventMilestoneModel = Model;
			if (miniEventMilestoneModel != null)
			{
				MilestoneState _003CMilestoneState_003Ek__BackingField = miniEventMilestoneModel.MilestoneState;
				if (_003CMilestoneState_003Ek__BackingField == MilestoneState.None || _003CMilestoneState_003Ek__BackingField == MilestoneState.None || _003CMilestoneState_003Ek__BackingField == MilestoneState.None || _003CMilestoneState_003Ek__BackingField == MilestoneState.None || _003CMilestoneState_003Ek__BackingField == MilestoneState.NotStarted)
				{
					OnStateNotStarted?.Invoke();
				}
			}
			OnDisplayRefresh?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6001CF4")]
		[Cpp2IlInjected.Address(RVA = "0x1292520", Offset = "0x1290F20", VA = "0x181292520", Slot = "4")]
		public string GetText(TextType textType)
		{
			MiniEventMilestoneModel miniEventMilestoneModel = Model;
			string empty = string.Empty;
			if (miniEventMilestoneModel == null || miniEventMilestoneModel.TextDict != null)
			{
			}
			return empty;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CF5")]
		[Cpp2IlInjected.Address(RVA = "0x12924E0", Offset = "0x1290EE0", VA = "0x1812924E0", Slot = "6")]
		public float GetProgress()
		{
			while (true)
			{
				MiniEventMilestoneModel miniEventMilestoneModel = Model;
				if (miniEventMilestoneModel != null)
				{
				}
				if (miniEventMilestoneModel != null)
				{
					/*Error: Could not find block for branch target IL_000f*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CF6")]
		[Cpp2IlInjected.Address(RVA = "0x12925B0", Offset = "0x1290FB0", VA = "0x1812925B0", Slot = "5")]
		public string GetURI(SpriteType spriteType)
		{
			MiniEventMilestoneModel miniEventMilestoneModel = Model;
			string empty = string.Empty;
			if (miniEventMilestoneModel == null || miniEventMilestoneModel.ImageAddressDict != null)
			{
			}
			return empty;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CF7")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public MiniEventMilestoneItem()
		{
		}
	}
}
