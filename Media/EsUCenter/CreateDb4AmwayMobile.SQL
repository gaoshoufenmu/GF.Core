/*

  创建账数据库脚本和创建账号脚本.

*/

create database AmwayMobile;

use AmwayMobile;
CREATE TABLE `account` (
  `AccountId` bigint NOT NULL auto_increment,
  `AccountName` varchar(64) NOT NULL,
  `Password` varchar(64) NOT NULL,
  `LoginStatus` varchar(16) NOT NULL default 'offline',
  `LoginLoginId` varchar(16) NOT NULL default '',
  PRIMARY KEY  (`AccountId`,`AccountName`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;



DROP PROCEDURE IF EXISTS AmwayMobile.createaccount;
DELIMITER //
CREATE PROCEDURE AmwayMobile.createaccount
(
) SQL SECURITY INVOKER
BEGIN
  DECLARE iCount INTEGER;
  DECLARE actName VARCHAR(16);
  SET iCount = 1000;

   while iCount < 9999 DO
     SET actName =  concat('test',iCount) ;
     INSERT INTO AmwayMobile.account(AccountName , Password) VALUES (actName, '123456');
     SET iCount = iCount + 1;
  end while;

END
//
DELIMITER ;

call createaccount();