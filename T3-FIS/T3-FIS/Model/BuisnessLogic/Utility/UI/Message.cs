using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_FIS.Model.Common
{
    public enum MessageType
    {
        Info,
        Warning,
        Success,
        Error,
        Unknown
    }

    public class Message
    {
        private string MessageText;
        private List<Message> InnerMessages = new List<Message>();
        private MessageType MsgType;

        /// <summary>
        /// Used to separate messages when in string form.
        /// </summary>
        public static string MessageDelimiter { private get; set; } = " | ";

        #region Constructors
        /// <summary>
        /// Used to describe a single message or multiple messages defined by the message's text and its type.
        /// </summary>
        public Message(MessageType type, string messageText)
        {
            MsgType = type;
            MessageText = messageText;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds multiple inner messages.
        /// </summary>
        /// <param name="innerMessages"></param>
        public void AddInnerMessages(IEnumerable<Message> innerMessages)
        {
            InnerMessages.AddRange(innerMessages);
        }

        /// <summary>
        /// Adds an inner message.
        /// </summary>
        /// <param name="innerMessage"></param>
        public void AddInnerMessage(Message innerMessage)
        {
            InnerMessages.Add(innerMessage);
        }

        /// <summary>
        /// Returns the message text as a string.
        /// </summary>
        /// <param name="showType">If set true, the returned string also specifies the type of the message. Set to false by default. </param>
        /// <returns></returns>
        public string GetMainMessageAsString(bool showType = false)
        {
            return (showType == true ? "[" + MsgType.ToString() + "]" : "") + MessageText;
        }

        /// <summary>
        /// Returns the message text as a string alongside with the inner messages separated by the message delimiter.
        /// </summary>
        /// <param name="showType">If set true, the returned string also specifies the type of the message. Set to false by default. </param>
        /// <returns></returns>
        public string GetAllMessagesAsString(bool showType = false)
        {
            List<string> allMessages = new List<string>();

            allMessages.Add((showType == true ? MsgType.ToString() : "") + MessageText);

            foreach (Message message in InnerMessages)
            {
                allMessages.Add(message.GetAllMessagesAsString());
            }

            return string.Join(MessageDelimiter, allMessages);
        }
        #endregion
    }
}
