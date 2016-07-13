
namespace David
{
	public class CreateMsgItm2Params
	{

		#region public members

		public DvApi32.MessageItem2 MessageItem2Object;
		public string Filename = string.Empty;
		public System.Guid UID;

		#endregion

		#region ### .ctor ###

		public CreateMsgItm2Params(DvApi32.MessageItem2 msgItem2, string filename, System.Guid itemUid)
		{
			this.MessageItem2Object = msgItem2;
			this.Filename = filename;
			this.UID = itemUid;
		}

		#endregion

	}
}
