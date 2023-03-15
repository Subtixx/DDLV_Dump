using Cpp2IlInjected;
using UnityEngine;
using ZXing;
using ZXing.QrCode;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000677")]
	public class QRGenerator
	{
		[Cpp2IlInjected.Token(Token = "0x60029C3")]
		[Cpp2IlInjected.Address(RVA = "0xE208E0", Offset = "0xE1F2E0", VA = "0x180E208E0")]
		private static Color32[] Encode(string textForEncoding, int width, int height)
		{
			//Discarded unreachable code: IL_0022
			BarcodeWriter barcodeWriter = new BarcodeWriter();
			QrCodeEncodingOptions qrCodeEncodingOptions = new QrCodeEncodingOptions();
			qrCodeEncodingOptions.Height = height;
			qrCodeEncodingOptions.Width = height;
			return (Color32[])((BarcodeWriterGeneric<TOutput>)(object)barcodeWriter).Write(textForEncoding);
		}

		[Cpp2IlInjected.Token(Token = "0x60029C4")]
		[Cpp2IlInjected.Address(RVA = "0xE209F0", Offset = "0xE1F3F0", VA = "0x180E209F0")]
		public Texture2D generateQR(string text)
		{
			//Discarded unreachable code: IL_005f
			//IL_0012: Expected I4, but got I8
			ulong num = default(ulong);
			Texture2D texture2D = new Texture2D(256, 256, TextureFormat.ARGB32, (byte)num != 0);
			int width = texture2D.width;
			int height = texture2D.height;
			BarcodeWriter barcodeWriter = new BarcodeWriter();
			QrCodeEncodingOptions qrCodeEncodingOptions = new QrCodeEncodingOptions();
			qrCodeEncodingOptions.Height = height;
			height = (qrCodeEncodingOptions.Width = width);
			Color32[] pixels = (Color32[])((BarcodeWriterGeneric<TOutput>)(object)barcodeWriter).Write(text);
			texture2D.SetPixels32(pixels);
			texture2D.Apply();
			return texture2D;
		}

		[Cpp2IlInjected.Token(Token = "0x60029C5")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public QRGenerator()
		{
		}
	}
}
