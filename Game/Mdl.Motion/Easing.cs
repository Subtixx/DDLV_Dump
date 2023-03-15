using System;
using Cpp2IlInjected;

namespace Mdl.Motion
{
	[Cpp2IlInjected.Token(Token = "0x20003AB")]
	public class Easing
	{
		[Cpp2IlInjected.Token(Token = "0x6000FA6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public static float Linear(float progress)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000FA7")]
		[Cpp2IlInjected.Address(RVA = "0x19DA8E0", Offset = "0x19D92E0", VA = "0x1819DA8E0")]
		public static float ElasticEaseIn(float progress)
		{
			//IL_000f: Expected F8, but got I4
			int num = 0;
			double num2 = Math.Pow(progress * 10f, num);
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FA8")]
		[Cpp2IlInjected.Address(RVA = "0x19DA9C0", Offset = "0x19D93C0", VA = "0x1819DA9C0")]
		public static float ElasticEaseOut(float progress)
		{
			//IL_0009: Expected F8, but got I4
			int num = 0;
			float num2 = default(float);
			double num3 = Math.Pow(num2, num);
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FA9")]
		[Cpp2IlInjected.Address(RVA = "0x19DA740", Offset = "0x19D9140", VA = "0x1819DA740")]
		public static float ElasticEaseInOut(float progress)
		{
			//IL_0009: Expected F8, but got I4
			//IL_0018: Expected F8, but got I4
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected F4, but got Unknown
			int num = 0;
			float num2 = default(float);
			double num3 = Math.Pow(num2, num);
			int num4 = 0;
			int num5 = 0;
			float num6 = default(float);
			double num7 = Math.Pow(num6, num5);
			return 0 * -0.5f;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FAA")]
		[Cpp2IlInjected.Address(RVA = "0x19DA3A0", Offset = "0x19D8DA0", VA = "0x1819DA3A0")]
		public static float BounceEaseIn(float progress)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000FAB")]
		[Cpp2IlInjected.Address(RVA = "0x19DA470", Offset = "0x19D8E70", VA = "0x1819DA470")]
		public static float BounceEaseOut(float progress)
		{
			//Discarded unreachable code: IL_000a, IL_0016, IL_0022
			return progress * 7.5625f;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FAC")]
		[Cpp2IlInjected.Address(RVA = "0x19DA1F0", Offset = "0x19D8BF0", VA = "0x1819DA1F0")]
		public static float BounceEaseInOut(float progress)
		{
			//Discarded unreachable code: IL_000a, IL_0016, IL_0022, IL_002e, IL_0036, IL_003c, IL_0042, IL_0048
			return progress * 7.5625f;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FAD")]
		[Cpp2IlInjected.Address(RVA = "0x11066D0", Offset = "0x11050D0", VA = "0x1811066D0")]
		public static float QuadEaseIn(float progress)
		{
			return progress;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FAE")]
		[Cpp2IlInjected.Address(RVA = "0x19DAD40", Offset = "0x19D9740", VA = "0x1819DAD40")]
		public static float QuadEaseOut(float progress)
		{
			return progress;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FAF")]
		[Cpp2IlInjected.Address(RVA = "0x19DACF0", Offset = "0x19D96F0", VA = "0x1819DACF0")]
		public static float QuadEaseInOut(float progress)
		{
			//Discarded unreachable code: IL_000a
			return progress * -0.5f;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB0")]
		[Cpp2IlInjected.Address(RVA = "0x19DA1A0", Offset = "0x19D8BA0", VA = "0x1819DA1A0")]
		public static float BackEaseIn(float progress)
		{
			return progress * 2.70158f;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB1")]
		[Cpp2IlInjected.Address(RVA = "0x19DA1C0", Offset = "0x19D8BC0", VA = "0x1819DA1C0")]
		public static float BackEaseOut(float progress)
		{
			return progress;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB2")]
		[Cpp2IlInjected.Address(RVA = "0x19DA130", Offset = "0x19D8B30", VA = "0x1819DA130")]
		public static float BackEaseInOut(float progress)
		{
			//Discarded unreachable code: IL_0010
			return progress * 3.5949094f * 0.5f;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB3")]
		[Cpp2IlInjected.Address(RVA = "0x19DABC0", Offset = "0x19D95C0", VA = "0x1819DABC0")]
		public static float ExpoEaseIn(float progress)
		{
			//IL_000b: Expected F8, but got I4
			//IL_000b: Expected F8, but got I4
			int num = 0;
			int num2 = 0;
			double num3 = Math.Pow(num, num2);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB4")]
		[Cpp2IlInjected.Address(RVA = "0x19DAC50", Offset = "0x19D9650", VA = "0x1819DAC50")]
		public static float ExpoEaseOut(float progress)
		{
			//IL_0011: Expected F8, but got I4
			int num = 0;
			double num2 = Math.Pow(512.0001211166382, num);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB5")]
		[Cpp2IlInjected.Address(RVA = "0x19DAAB0", Offset = "0x19D94B0", VA = "0x1819DAAB0")]
		public static float ExpoEaseInOut(float progress)
		{
			//Discarded unreachable code: IL_000a
			//IL_001b: Expected F8, but got I4
			//IL_002d: Expected F8, but got I4
			return 512.0001f;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB6")]
		[Cpp2IlInjected.Address(RVA = "0x19DA620", Offset = "0x19D9020", VA = "0x1819DA620")]
		public static float CircEaseIn(float progress)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB7")]
		[Cpp2IlInjected.Address(RVA = "0x19DA6B0", Offset = "0x19D90B0", VA = "0x1819DA6B0")]
		public static float CircEaseOut(float progress)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB8")]
		[Cpp2IlInjected.Address(RVA = "0x19DA510", Offset = "0x19D8F10", VA = "0x1819DA510")]
		public static float CircEaseInOut(float progress)
		{
			//Discarded unreachable code: IL_0008
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Expected F4, but got Unknown
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected F4, but got Unknown
			return 0 * 0.5f;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FB9")]
		[Cpp2IlInjected.Address(RVA = "0x19DAD90", Offset = "0x19D9790", VA = "0x1819DAD90")]
		public static float QuartEaseIn(float progress)
		{
			return progress;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBA")]
		[Cpp2IlInjected.Address(RVA = "0x19DAD60", Offset = "0x19D9760", VA = "0x1819DAD60")]
		public static float QuartEaseOut(float progress)
		{
			return progress;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBB")]
		[Cpp2IlInjected.Address(RVA = "0x19DAD60", Offset = "0x19D9760", VA = "0x1819DAD60")]
		public static float QuartEaseInOut(float progress)
		{
			return progress;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBC")]
		[Cpp2IlInjected.Address(RVA = "0x19DAE00", Offset = "0x19D9800", VA = "0x1819DAE00")]
		public static float QuintEaseIn(float progress)
		{
			return progress;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBD")]
		[Cpp2IlInjected.Address(RVA = "0x19DAE20", Offset = "0x19D9820", VA = "0x1819DAE20")]
		public static float QuintEaseOut(float progress)
		{
			return progress;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBE")]
		[Cpp2IlInjected.Address(RVA = "0x19DADA0", Offset = "0x19D97A0", VA = "0x1819DADA0")]
		public static float QuintEaseInOut(float progress)
		{
			//Discarded unreachable code: IL_000a
			return progress * 0.5f;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBF")]
		[Cpp2IlInjected.Address(RVA = "0x19DAED0", Offset = "0x19D98D0", VA = "0x1819DAED0")]
		public static float SineEaseIn(float progress)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FC0")]
		[Cpp2IlInjected.Address(RVA = "0x19DAF50", Offset = "0x19D9950", VA = "0x1819DAF50")]
		public static float SineEaseOut(float progress)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FC1")]
		[Cpp2IlInjected.Address(RVA = "0x19DAE50", Offset = "0x19D9850", VA = "0x1819DAE50")]
		public static float SineEaseInOut(float progress)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Expected F4, but got Unknown
			return 0 * -0.5f;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FC2")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public Easing()
		{
		}
	}
}
