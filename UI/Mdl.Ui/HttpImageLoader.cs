using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Gameloft.FileSystem.Abstraction;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	public class HttpImageLoader : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		[SerializeField]
		protected ThrobberIcon _throbber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		[SerializeField]
		protected Image _mcImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		[SerializeField]
		protected bool _showThrobber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		[SerializeField]
		protected Sprite _defauldImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public Color startColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public Color loadedColor;

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public Image ImageAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000968")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _mcImage;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		private CancellationToken _cancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x6000969")]
			[Cpp2IlInjected.Address(RVA = "0xAF2E80", Offset = "0xAF1880", VA = "0x180AF2E80")]
			get
			{
				//Discarded unreachable code: IL_000c
				return cancellationTokenSource.Token;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0xAF2DB0", Offset = "0xAF17B0", VA = "0x180AF2DB0")]
		private void OnDestroy()
		{
			CancellationTokenSource cancellationTokenSource = this.cancellationTokenSource;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				this.cancellationTokenSource?.Dispose();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0xAF25B0", Offset = "0xAF0FB0", VA = "0x180AF25B0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0016
			Image mcImage = _mcImage;
			Color color2 = (mcImage.color = startColor);
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0xAF2B10", Offset = "0xAF1510", VA = "0x180AF2B10")]
		public void LoadImage(string imageAddress, [Optional] Action callBack)
		{
			//IL_0017: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			Image mcImage = _mcImage;
			Image mcImage2 = _mcImage;
			int num = 0;
			mcImage2.sprite = (Sprite)num;
			Sprite defauldImage = _defauldImage;
			int num2 = 0;
			bool flag = defauldImage != (UnityEngine.Object)num2;
			if (flag && flag)
			{
				Image mcImage3 = _mcImage;
				Sprite sprite = (mcImage3.sprite = _defauldImage);
				Image mcImage4 = _mcImage;
				callBack?.Invoke();
				return;
			}
			CancellationToken token = cancellationTokenSource.Token;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0xAF29C0", Offset = "0xAF13C0", VA = "0x180AF29C0")]
		[AsyncStateMachine(typeof(_003CGetImageRequest_003Ed__14))]
		private Task GetImageRequest(string url, CancellationToken ct, [Optional] Action callBack)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0xAF2850", Offset = "0xAF1250", VA = "0x180AF2850")]
		private static Texture2D CreateTextureFromFile(IFileSystem fs, string filePath)
		{
			//Discarded unreachable code: IL_0040
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			if ((object)typeof(Texture2D).TypeHandle == null)
			{
				int num3 = 0;
				num3 += 344;
			}
			uint num4 = default(uint);
			Texture2D texture2D = new Texture2D((int)num4, (int)num4);
			texture2D.name = filePath;
			byte[] data = default(byte[]);
			bool flag = texture2D.LoadImage(data);
			return texture2D;
		}

		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(RVA = "0xAF25F0", Offset = "0xAF0FF0", VA = "0x180AF25F0")]
		private static Sprite CreateSpriteFromFile(IFileSystem fs, string filePath)
		{
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			if ((object)typeof(Texture2D).TypeHandle == null)
			{
			}
			byte[] data = fs.ReadAllBytes(filePath);
			uint num3 = default(uint);
			Texture2D texture2D = new Texture2D((int)num3, (int)num3);
			texture2D.name = filePath;
			bool flag = texture2D.LoadImage(data);
			if ((bool)texture2D)
			{
				int width = texture2D.width;
				int height = texture2D.height;
				int num4 = 0;
				Sprite result = default(Sprite);
				return result;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000970")]
		[Cpp2IlInjected.Address(RVA = "0xAF2DF0", Offset = "0xAF17F0", VA = "0x180AF2DF0")]
		public HttpImageLoader()
		{
			Color white = Color.white;
			base._002Ector();
		}
	}
}
