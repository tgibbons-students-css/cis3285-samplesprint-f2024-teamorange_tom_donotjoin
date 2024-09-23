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

            // Changes Sprint User Story 2A: I want to send markdown text that will be correctly formatted. -- Nora Peterson
        }

        /// <summary>
        ///   Tom story 2A
        /// </summary>

        public int RoomID
        {
            get;
            private set;
        }

        public string Text
        {
            get;
            private set;
            // Changes Sprint User Story 2A: I want to send markdown text that will be correctly formatted. -- Nora Peterson
        }

        public string AuthorName
        {
            get;
            private set;
        }
    }
}
