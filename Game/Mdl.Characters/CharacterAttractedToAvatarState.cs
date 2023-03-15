using System.Diagnostics;
using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x200085C")]
	public class CharacterAttractedToAvatarState : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002F03")]
		private float InitialNavMeshSamplingMaxDistance = 6f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002F04")]
		[SerializeField]
		private bool enableDebugging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002F05")]
		[SerializeField]
		private float AttractionDuration = 20f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002F06")]
		[SerializeField]
		private float AttractionCooldown = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002F07")]
		[SerializeField]
		private bool UseQuery = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4002F08")]
		[SerializeField]
		private float QueryInnerRadius = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002F09")]
		[SerializeField]
		private float QueryOuterRadius = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4002F0A")]
		[SerializeField]
		private int QueryCirclePoints = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002F0B")]
		[SerializeField]
		private int QueryCircleRings = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4002F0C")]
		private float EndAttractionTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002F0D")]
		private float EndCooldownTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4002F0E")]
		private Vector3? attractionPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4002F0F")]
		private int attractionCount;

		[Cpp2IlInjected.Token(Token = "0x170005BE")]
		protected GameObject Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x600269B")]
			[Cpp2IlInjected.Address(RVA = "0x12DB230", Offset = "0x12D9C30", VA = "0x1812DB230")]
			get
			{
				//Discarded unreachable code: IL_0010
				return SystemRoot.Instance._avatar.gameObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005BF")]
		public bool IsAttracted
		{
			[Cpp2IlInjected.Token(Token = "0x600269C")]
			[Cpp2IlInjected.Address(RVA = "0x12DB2F0", Offset = "0x12D9CF0", VA = "0x1812DB2F0")]
			get
			{
				return attractionCount > 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C0")]
		public bool IsInCooldown
		{
			[Cpp2IlInjected.Token(Token = "0x600269D")]
			[Cpp2IlInjected.Address(RVA = "0x12DB300", Offset = "0x12D9D00", VA = "0x1812DB300")]
			get
			{
				float endAttractionTime = EndAttractionTime;
				int num = 0;
				float time = Time.time;
				if (false)
				{
				}
				int num2 = 0;
				float endCooldownTime = EndCooldownTime;
				float time2 = Time.time;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005C1")]
		public bool IsWithinAttractionTime
		{
			[Cpp2IlInjected.Token(Token = "0x600269E")]
			[Cpp2IlInjected.Address(RVA = "0x12DB380", Offset = "0x12D9D80", VA = "0x1812DB380")]
			get
			{
				float endAttractionTime = EndAttractionTime;
				int num = 0;
				float time = Time.time;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600269F")]
		[Cpp2IlInjected.Address(RVA = "0x12DAC30", Offset = "0x12D9630", VA = "0x1812DAC30")]
		public void StartAttraction()
		{
			int num = 0;
			float endAttractionTime = EndAttractionTime;
			float time = Time.time;
			float endCooldownTime = EndCooldownTime;
			int num2 = 0;
			float time2 = Time.time;
			UpdateAttractionPosition();
			int num3 = 0;
			float time3 = Time.time;
			int num4 = 0;
			EndAttractionTime = time3;
			float num5 = (EndCooldownTime = Time.time);
		}

		[Cpp2IlInjected.Token(Token = "0x60026A0")]
		[Cpp2IlInjected.Address(RVA = "0x12DACF0", Offset = "0x12D96F0", VA = "0x1812DACF0")]
		private void UpdateAttractionPosition()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60026A1")]
		[Cpp2IlInjected.Address(RVA = "0x12DAB50", Offset = "0x12D9550", VA = "0x1812DAB50")]
		public void EndAttraction()
		{
			int num = attractionCount;
			int min = 0;
			int num2 = (attractionCount = Mathf.Clamp(num, min, num));
		}

		[Cpp2IlInjected.Token(Token = "0x60026A2")]
		[Cpp2IlInjected.Address(RVA = "0x12DAB80", Offset = "0x12D9580", VA = "0x1812DAB80")]
		public Vector3 GetAttractionPosition()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60026A3")]
		[Cpp2IlInjected.Address(RVA = "0x12DAB30", Offset = "0x12D9530", VA = "0x1812DAB30")]
		public static bool CanEverBeAttractedToAvatar(Character characterComponent)
		{
			//Discarded unreachable code: IL_0007
			return characterComponent.IsAquatic;
		}

		[Cpp2IlInjected.Token(Token = "0x60026A4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_ONSCREEN_ATTRACT")]
		private void OnscreenDebug(string key, bool value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60026A5")]
		[Cpp2IlInjected.Address(RVA = "0x12DAC00", Offset = "0x12D9600", VA = "0x1812DAC00")]
		[Conditional("DEBUG_ONSCREEN_ATTRACT")]
		private void OnscreenDebug(string key, Vector3? maybeValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60026A6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_ONSCREEN_ATTRACT")]
		private void OnscreenDebug(string key, float value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60026A7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_ONSCREEN_ATTRACT")]
		private void OnscreenDebug(string key, string value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60026A8")]
		[Cpp2IlInjected.Address(RVA = "0x12DB1F0", Offset = "0x12D9BF0", VA = "0x1812DB1F0")]
		public CharacterAttractedToAvatarState()
		{
		}//IL_0047: Expected I4, but got I8
		//IL_0050: Expected I4, but got I8

	}
}
