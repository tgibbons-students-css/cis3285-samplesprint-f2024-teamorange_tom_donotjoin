namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
        /// <summary>
        /// Added comment for story 1
        /// </summary>
        /// <param name="roomID"></param>
        /// <param name="authorName"></param>
        /// <param name="text"></param>
        public MessageRecord(int roomID, string authorName, string text)
        {
            RoomID = roomID;
            Text = text;
            AuthorName = authorName;
        }

        public int RoomID
        {
            get;
            private set;
        }

        public string Text
        {
            get;
            private set;
        }

        public string AuthorName
        {
            get;
            private set;
        }
    }
}
