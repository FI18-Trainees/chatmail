SELECT uId, firstname, lastname, displayname FROM chatmail.user INNER JOIN chatmail.messagereceiver ON user.uId = messagereceiver.rId 