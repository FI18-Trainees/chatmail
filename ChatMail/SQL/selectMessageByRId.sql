SELECT message.mId, content, timestamp, senderId FROM chatmail.message INNER JOIN chatmail.messagereceiver ON (message.mId = messagereceiver.mId AND messagereceiver.rId = @RID);