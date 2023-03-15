using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20008AA")]
	public class TweenLiteArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40033B6")]
		public Vector3? Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40033B7")]
		public Vector3? Scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40033B8")]
		public Vector2? SizeDelta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40033B9")]
		public Vector3? Rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40033BA")]
		public Vector4? Offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40033BB")]
		public float? OffsetTop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40033BC")]
		public float? OffsetBot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40033BD")]
		public float? OffsetLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40033BE")]
		public float? OffsetRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40033BF")]
		public float? Alpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40033C0")]
		public float? StartAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40033C1")]
		public float Delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40033C2")]
		public int Repeat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40033C3")]
		public bool UseFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x40033C4")]
		public bool UseYoyo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
		[Cpp2IlInjected.Token(Token = "0x40033C5")]
		public bool DestroyTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
		[Cpp2IlInjected.Token(Token = "0x40033C6")]
		public eEaseType Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40033C7")]
		public TweenDelegate OnComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40033C8")]
		public object OnCompleteParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40033C9")]
		public TweenDelegate OnStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40033CA")]
		public object OnStartParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40033CB")]
		public TweenDelegate OnUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40033CC")]
		public object OnUpdateParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40033CD")]
		public TweenDelegate OnRepeat;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40033CE")]
		public object OnRepeatParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40033CF")]
		public object CancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60036D0")]
		[Cpp2IlInjected.Address(RVA = "0x3F11BD0", Offset = "0x3F105D0", VA = "0x183F11BD0")]
		public unsafe TweenLiteArgs(TweenDefinition tweenDefinition, [Optional] IHasTween owner)
		{
			//Discarded unreachable code: IL_0280
			//IL_00d6: Expected F4, but got O
			//IL_00eb: Expected I4, but got O
			//IL_0100: Expected I4, but got O
			//IL_0142: Expected O, but got I4
			//IL_0156: Expected O, but got I4
			//IL_019b: Expected O, but got I4
			//IL_01ad: Expected native int or pointer, but got O
			//IL_01d2: Expected native int or pointer, but got O
			//IL_01f4: Expected O, but got I4
			//IL_0203: Expected native int or pointer, but got O
			//IL_0217: Expected O, but got I4
			//IL_022f: Expected O, but got I4
			//IL_023e: Expected O, but got I4
			//IL_0250: Expected O, but got I4
			//IL_0274: Expected O, but got I4
			new _003C_003Ec__DisplayClass26_0().owner = owner;
			base._002Ector();
			Transform transform = tweenDefinition.Target.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			TweenParam[] @params = tweenDefinition.Params;
			int num2 = 0;
			if (num < @params.Length)
			{
				_003C_003Ec__DisplayClass26_1 _003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_1();
				_003C_003Ec__DisplayClass26_.CS_0024_003C_003E8__locals1 = (_003C_003Ec__DisplayClass26_0)(object)_003C_003Ec__DisplayClass26_;
				TweenParam tweenParam = (_003C_003Ec__DisplayClass26_.tweenParam = @params[num]);
				TweenType type = _003C_003Ec__DisplayClass26_.tweenParam.Type;
				if (type > TweenType.Size)
				{
					TweenDelegate tweenDelegate = default(TweenDelegate);
					if (type > TweenType.Alpha)
					{
						if (type > TweenType.UseYoyo)
						{
							if (type == TweenType.OnComplete)
							{
								((Delegate)tweenDelegate).method_ptr = (IntPtr)__ldftn(_003C_003Ec__DisplayClass26_1._003C_002Ector_003Eb__0);
								((Delegate)tweenDelegate).method = (IntPtr)__ldftn(_003C_003Ec__DisplayClass26_1._003C_002Ector_003Eb__0);
								((Delegate)tweenDelegate).m_target = _003C_003Ec__DisplayClass26_;
								OnComplete = tweenDelegate;
								num++;
							}
							object target = ((Delegate)tweenDelegate).m_target;
							num++;
							Delay = (float)target;
						}
						object target2 = ((Delegate)tweenDelegate).m_target;
						num++;
						Repeat = (int)target2;
						object target3 = ((Delegate)tweenDelegate).m_target;
						num++;
						UseYoyo = (byte)(int)target3 != 0;
					}
					if (owner != null)
					{
						if (owner != null)
						{
							if (owner != null)
							{
								if (owner != null)
								{
									if ((long)owner != 1)
									{
										object target4 = ((Delegate)tweenDelegate).m_target;
										num++;
										Alpha = (float?)target4;
									}
									object target5 = ((Delegate)tweenDelegate).m_target;
									num++;
									OffsetBot = (float?)(object)num;
								}
								object target6 = ((Delegate)tweenDelegate).m_target;
								num++;
								OffsetTop = (float?)(object)num;
							}
							object target7 = ((Delegate)tweenDelegate).m_target;
							num++;
							OffsetRight = (float?)target7;
						}
						object target8 = ((Delegate)tweenDelegate).m_target;
						num++;
						OffsetLeft = (float?)target8;
					}
					object target9 = ((Delegate)tweenDelegate).m_target;
					int num3 = 0;
					int num4 = 0;
					num++;
					Offset = (Vector4?)(object)num3;
					int num5 = 0;
					int has_value = 0;
					num++;
					((Nullable<>*)(IntPtr)SizeDelta)->has_value = (byte)has_value != 0;
					int num6 = 0;
					float[] values = _003C_003Ec__DisplayClass26_.tweenParam.Values;
					int has_value2 = 0;
					num++;
					((Nullable<>*)(IntPtr)SizeDelta)->has_value = (byte)has_value2 != 0;
				}
				float[] values2 = _003C_003Ec__DisplayClass26_.tweenParam.Values;
				int num7 = 0;
				num++;
				Scale = (Vector3?)(object)num7;
				int has_value3 = 0;
				num++;
				((Nullable<>*)(IntPtr)SizeDelta)->has_value = (byte)has_value3 != 0;
				int num8 = 0;
				num++;
				Scale = (Vector3?)(object)num8;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				int num9 = 0;
				num++;
				Scale = (Vector3?)(object)num9;
				int num10 = 0;
				num++;
				Position = (Vector3?)(object)num10;
				int num11 = 0;
				int num12 = 0;
				num++;
				Position = (Vector3?)(object)num12;
				if (num == 4128)
				{
					int num13 = 0;
					float[] values3 = _003C_003Ec__DisplayClass26_.tweenParam.Values;
					int num14 = 0;
					Position = (Vector3?)(object)num14;
				}
				num++;
			}
			Ease = (eEaseType)num;
		}

		[Cpp2IlInjected.Token(Token = "0x60036D1")]
		[Cpp2IlInjected.Address(RVA = "0x3F12840", Offset = "0x3F11240", VA = "0x183F12840")]
		public unsafe TweenLiteArgs([Optional] Vector3? position, [Optional] Vector3? scale, [Optional] Vector2? sizeDelta, [Optional] Vector3? rotation, [Optional] Vector4? offset, [Optional] float? offsetTop, [Optional] float? offsetBot, [Optional] float? alpha, [Optional] float? startAlpha, float delay = 0f, int repeat = 0, bool useFrame = false, bool useYoyo = false, bool destroyTarget = false, eEaseType ease = eEaseType.NONE, [Optional] TweenDelegate onComplete, [Optional] object onCompleteParam, [Optional] TweenDelegate onStart, [Optional] object onStartParam, [Optional] TweenDelegate onUpdate, [Optional] object onUpdateParam, [Optional] TweenDelegate onRepeat, [Optional] object onRepeatParam, [Optional] object cancellationToken)
		{
			//IL_0014: Expected O, but got I4
			//IL_001b: Expected native int or pointer, but got O
			//IL_0027: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			//IL_003c: Expected O, but got I4
			//IL_0066: Expected F4, but got I4
			//IL_006d: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			//IL_007b: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			//IL_0089: Expected O, but got I4
			//IL_0090: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_009e: Expected O, but got I4
			bool has_value = ((Nullable<>*)(&sizeDelta))->has_value;
			OnComplete = (TweenDelegate)0;
			((Nullable<>*)(IntPtr)SizeDelta)->has_value = has_value;
			OffsetTop = (float?)(object)0;
			OffsetBot = (float?)(object)0;
			Alpha = (float?)(object)0;
			StartAlpha = (float?)(object)0;
			Repeat = 0;
			UseFrame = false;
			UseYoyo = false;
			Ease = eEaseType.NONE;
			DestroyTarget = false;
			Delay = 0f;
			OnCompleteParam = 0;
			OnStart = (TweenDelegate)0;
			OnStartParam = 0;
			OnUpdate = (TweenDelegate)0;
			OnUpdateParam = 0;
			OnRepeat = (TweenDelegate)0;
			OnRepeatParam = 0;
			CancellationToken = 0;
			/*Error: Unexpected end of block*/;
		}
	}
}
