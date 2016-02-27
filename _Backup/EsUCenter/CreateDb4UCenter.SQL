/*

  创建账数据库脚本和创建账号脚本.

*/

create database UCenter;

use UCenter;
CREATE TABLE `account` (
  `AccountId` bigint NOT NULL auto_increment,
  `AccountName` varchar(64) NOT NULL,
  `Password` varchar(64) NOT NULL,
  `Token` varchar(128) NOT NULL default '',
  `LastLoginDt` datetime,
  `Name` varchar(128) NOT NULL default '',
  `Sex` int NOT NULL default '0',
  `IdentityNum` varchar(32) NOT NULL default '',
  `PhoneNum` varchar(16) NOT NULL default '',
  PRIMARY KEY  (`AccountId`,`AccountName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `app_texaspoker` (
  `AccountId` bigint NOT NULL,
  `AppData1` varchar(128) NOT NULL default '',
  `AppData2` varchar(128) NOT NULL default '',
  `AppData3` varchar(128) NOT NULL default '',
  PRIMARY KEY  (`AccountId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO UCenter.account(AccountName , Password) VALUES ('test1000', '123456');
INSERT INTO UCenter.account(AccountName , Password) VALUES ('test1001', '123456');
INSERT INTO UCenter.account(AccountName , Password) VALUES ('test1002', '123456');

DROP PROCEDURE IF EXISTS UCenter.createaccount;
DELIMITER 
CREATE PROCEDURE UCenter.createaccount
(
) SQL SECURITY INVOKER
BEGIN
  DECLARE count INTEGER;
  DECLARE acc_name VARCHAR(16);
  SET count = 1000;

   while count < 9999 DO
     SET acc_name =  concat('test', count) ;
     INSERT INTO UCenter.account(AccountName , Password) VALUES (acc_name, '123456');
     SET count = count + 1;
  end while;
END
DELIMITER;

call UCenter.createaccount();