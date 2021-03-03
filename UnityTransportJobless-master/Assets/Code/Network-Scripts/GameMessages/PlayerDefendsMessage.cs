using Unity.Networking.Transport;
namespace Assets.Code
{
	public class PlayerDefendsMessage : MessageHeader
	{
		public override MessageType Type => MessageType.PlayerDefends;
		public int PlayerID;
		public override void SerializeObject(ref DataStreamWriter writer)
		{
			base.SerializeObject(ref writer);
			writer.WriteInt(PlayerID);
		}
		public override void DeserializeObject(ref DataStreamReader reader)
		{
			base.DeserializeObject(ref reader);
			PlayerID = reader.ReadInt();
		}
	}
}