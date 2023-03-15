using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200046C")]
	[ExecuteInEditMode]
	public class EventProgressNodeConnection : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001672")]
		public SpriteAtlasImage BackgroundImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001673")]
		[Space]
		public EventProgressNodeBase From;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001674")]
		public EventProgressNodeBase To;

		[Cpp2IlInjected.Token(Token = "0x6001C8C")]
		[Cpp2IlInjected.Address(RVA = "0x1401D20", Offset = "0x1400720", VA = "0x181401D20")]
		internal void RefreshDisplay()
		{
			//IL_0010: Expected O, but got I4
			//IL_0026: Expected O, but got I4
			//IL_00ba: Expected F4, but got I4
			//IL_00ba: Expected F4, but got I4
			//IL_0106: Expected O, but got I4
			EventProgressNodeBase to = To;
			int num = 0;
			if (!(to != (UnityEngine.Object)num))
			{
				return;
			}
			EventProgressNodeBase from = From;
			int num2 = 0;
			if (!(from != (UnityEngine.Object)num2))
			{
				return;
			}
			EventProgressNodeBase to2 = To;
			EventProgressNodeBase from2 = From;
			if (!(to2 != from2))
			{
				return;
			}
			Transform transform = From.transform;
			int num3 = 0;
			if ((object)transform != null)
			{
			}
			Transform transform2 = To.transform;
			Transform transform3 = base.transform;
			EventProgressNodeBase from3 = From;
			if ((object)transform3 != null)
			{
			}
			if ((object)from3 != null)
			{
				int num4 = 0;
				if ((object)from3 != null && (object)transform3 == null)
				{
				}
			}
			EventProgressNodeBase to3 = To;
			if ((object)to3 != null)
			{
				int num5 = 0;
				if ((object)to3 != null)
				{
				}
			}
			int num6 = 0;
			int num7 = 0;
			float x = default(float);
			Quaternion quaternion = Quaternion.Euler(x, num7, num6);
			if (From.GetStateValue() > 0 && To.GetStateValue() > 0)
			{
				Image image = BackgroundImage.Image;
				Color white = Color.white;
				return;
			}
			Image image2 = BackgroundImage.Image;
			int num8 = 0;
			image2.color = (Color)num8;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C8D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public EventProgressNodeConnection()
		{
		}
	}
}
