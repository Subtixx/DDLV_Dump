using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200045F")]
	public class EventLeaderboardRecordItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400161C")]
		private EventLeaderboardRecordModel _model;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400161D")]
		[SerializeField]
		private TextBase _tfRank;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400161E")]
		[SerializeField]
		private TextBase _tfLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400161F")]
		[SerializeField]
		private TextBase _tfName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001620")]
		[SerializeField]
		private TextBase _tfScore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001621")]
		[SerializeField]
		private GameObject _mcHighlight;

		[Cpp2IlInjected.Token(Token = "0x170004A3")]
		public EventLeaderboardRecordModel Model
		{
			[Cpp2IlInjected.Token(Token = "0x6001C3B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _model;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C3C")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				_model = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A4")]
		public bool IsCurrentPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6001C3D")]
			[Cpp2IlInjected.Address(RVA = "0x13FC960", Offset = "0x13FB360", VA = "0x1813FC960")]
			set
			{
				//Discarded unreachable code: IL_000d
				_mcHighlight.SetActive(value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C3E")]
		[Cpp2IlInjected.Address(RVA = "0x13FC870", Offset = "0x13FB270", VA = "0x1813FC870")]
		public void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0061
			TextBase tfRank = _tfRank;
			EventLeaderboardRecordModel model = _model;
			string text = default(string);
			tfRank.Text = text;
			EventLeaderboardRecordModel model2 = _model;
			string text2 = default(string);
			_tfLevel.Text = text2;
			EventLeaderboardRecordModel model3 = _model;
			TextBase tfName = _tfName;
			string text3 = (tfName.Text = model3.PlayerName);
			EventLeaderboardRecordModel model4 = _model;
			string text4 = default(string);
			_tfScore.Text = text4;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C3F")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public EventLeaderboardRecordItem()
		{
		}
	}
}
