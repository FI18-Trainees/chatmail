using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChatMail.Database;
using ChatMail.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace ChatMail.UnitTests
{
    [TestClass]
    public class DBHandlerTests
    {
        DBHandler handler = new DBHandler();
        [TestMethod]
        public void InsertUser_UserValid_ReturnsTrue()
        {
            User validUser = new User("foo", "bar", "name");

            var result = handler.InsertUser(validUser);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InsertUser_UserInvalid_ReturnsTrue()
        {
            User invalidUser = new User();

            var result = handler.InsertUser(invalidUser);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void InsertMessage_MessageValid_ReturnsTrue()
        {
            User validUser = new User(1, "foo", "bar", "name");
            List<User> validReceivers = new List<User>() { validUser };
            Message validMessage = new Message("nice message!", DateTime.Now, validUser, validReceivers);

            var result = handler.InsertMessage(validMessage);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InsertMessage_MessageInValid_ReturnsFalse()
        {
            User validUser = new User(1, "foo", "bar", "name");
            List<User> validReceivers = new List<User>() { validUser };
            Message validMessage = new Message(null, DateTime.Now, validUser, validReceivers);

            var result = handler.InsertMessage(validMessage);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void InsertMessage_MessageValidSenderInvalid_ReturnsFalse()
        {
            User validUser = new User(-1, "foo", "bar", "name");
            List<User> validReceivers = new List<User>() { new User(1, "foo", "bar", "name") };
            Message validMessage = new Message(null, DateTime.Now, validUser, validReceivers);

            var result = handler.InsertMessage(validMessage);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void InsertMessage_MessageValidReceiverInvalid_ReturnsFalse()
        {
            User validUser = new User(1, "foo", "bar", "name");
            List<User> validReceivers = new List<User>() { new User(-1, "foo", "bar", "name") };
            Message validMessage = new Message(null, DateTime.Now, validUser, validReceivers);

            var result = handler.InsertMessage(validMessage);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void InsertMessage_MessageValidReceiverEmpty_ReturnsFalse()
        {
            User validUser = new User(1, "foo", "bar", "name");
            List<User> validReceivers = new List<User>();
            Message validMessage = new Message(null, DateTime.Now, validUser, validReceivers);

            var result = handler.InsertMessage(validMessage);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetAllUsers_ValidConfig_ReturnsUserList()
        {
            var result = handler.GetAllUsers();

            Assert.IsInstanceOfType(result, typeof(List<User>));
        }

        [TestMethod]
        public void GetUserByUserId_ValidUId_ReturnsUser()
        {
            int userID = 1;

            var result = handler.GetUserByUserId(uId: userID);

            Assert.IsInstanceOfType(result, typeof(User));
        }

        [TestMethod]
        public void GetUserByUserId_InvalidUId_ReturnsNull()
        {
            int userId = 0;

            var result = handler.GetUserByUserId(uId: userId);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetMessagesByReceiverId_ValidRId_ReturnsMessageList()
        {
            int receiverId = 1;

            var result = handler.GetMessagesByReceiverId(rId: receiverId);

            Assert.IsInstanceOfType(result, typeof(List<Message>));
            Assert.AreNotEqual(0, result.Count);
        }

        [TestMethod]
        public void GetMessagesByReceiverId_InvalidRId_ReturnsEmptyMessageList()
        {
            int receiverId = 0;

            var result = handler.GetMessagesByReceiverId(rId: receiverId);

            Assert.IsInstanceOfType(result, typeof(List<Message>));
            Assert.AreEqual(0, result.Count);
        }
        
        [TestMethod]
        public void GetMessageByMessageId_ValidMId_ReturnsMessageList()
        {
            int messageId = 1;

            var result = handler.GetMessageByMessageId(mId: messageId);

            Assert.IsInstanceOfType(result, typeof(Message));
        }

        [TestMethod]
        public void GetMessageByMessageId_InvalidMId_ReturnsNull()
        {
            int messageId = 0;

            var result = handler.GetMessageByMessageId(mId: messageId);

            Assert.IsNull(result);
        }
        
        [TestMethod]
        public void GetReceiversByMessageId_ValidMId_ReturnsMessageList()
        {
            int messageId = 1;

            var result = handler.GetReceiversByMessageId(mId: messageId);

            Assert.IsInstanceOfType(result, typeof(List<User>));
            Assert.AreNotEqual(0, result.Count);
        }

        [TestMethod]
        public void GetReceiversByMessageId_InvalidMId_ReturnsNull()
        {
            int messageId = 0;

            var result = handler.GetReceiversByMessageId(mId: messageId);

            Assert.IsInstanceOfType(result, typeof(List<User>));
            Assert.AreEqual(0, result.Count);
        }
    }
}
