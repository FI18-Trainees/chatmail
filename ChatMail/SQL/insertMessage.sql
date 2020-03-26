INSERT INTO chatmail.message (content, timestamp, senderId) VALUES (@CONTENT, @TIMESTAMP, @SENDERID);
SELECT LAST_INSERT_ID() AS "ID";