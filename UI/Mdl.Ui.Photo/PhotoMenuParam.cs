using System.Xml.Schema;
using Cpp2IlInjected;
using Definitions.Activities;
using UnityEngine;

namespace Mdl.Ui.Photo
{
	[Cpp2IlInjected.Token(Token = "0x2000943")]
	public class PhotoMenuParam : MenuParam
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003691")]
		public PhotoModeType PhotoMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4003692")]
		public bool IsAvatarCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003693")]
		public float PreFocusOutDelay = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4003694")]
		public bool IsInCharacterUnlockFlow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003695")]
		public MapCameraTransform Positions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003696")]
		public Transform FreeCamStartTransform;

		[Cpp2IlInjected.Token(Token = "0x6003A07")]
		[Cpp2IlInjected.Address(RVA = "0x9C1110", Offset = "0x9BFB10", VA = "0x1809C1110")]
		public PhotoMenuParam()
		{
			((XmlSchemaNumericFacet)(object)this)._002Ector();
		}
	}
}
