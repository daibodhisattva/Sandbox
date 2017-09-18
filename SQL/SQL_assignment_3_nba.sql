CREATE DATABASE nba;

CREATE TABLE nba.city (
  id INT(32) NOT NULL AUTO_INCREMENT COMMENT 'Unique Primary ID',
  cityname VARCHAR(32) NOT NULL DEFAULT '',
  PRIMARY KEY (id)
);

CREATE TABLE nba.team (
  id INT(32) NOT NULL AUTO_INCREMENT COMMENT 'Unique Primary ID',
  teamname VARCHAR(32) NOT NULL DEFAULT '',
  city INT(32),
  PRIMARY KEY (id),
  FOREIGN KEY (city) REFERENCES nba.city (id)
);

CREATE TABLE nba.players (
  id INT(32) NOT NULL AUTO_INCREMENT COMMENT 'Unique Primary ID',
  playersname VARCHAR(32) NOT NULL DEFAULT '',
  teamid INT(32),
  PRIMARY KEY (id),
  FOREIGN KEY (teamid) REFERENCES nba.team (id)
);

INSERT INTO nba.city (cityname) VALUE ('Oklahoma City');
INSERT INTO nba.city (cityname) VALUE ('Chicago');
INSERT INTO nba.city ( cityname) VALUE ('Los Angeles');
INSERT INTO nba.city ( cityname) VALUE ('Dallas');
INSERT INTO nba.city ( cityname) VALUE ('San Antonio');
INSERT INTO nba.city ( cityname) VALUE ('Miami');
INSERT INTO nba.city ( cityname) VALUE ('Sacramento');
INSERT INTO nba.city ( cityname) VALUE ('Houston');
INSERT INTO nba.city ( cityname) VALUE ('San Diego');
INSERT INTO nba.city ( cityname) VALUE ('Las Vegas');

INSERT INTO nba.team (teamname,city) VALUES ('Thunder',1);
INSERT INTO nba.team (teamname,city) VALUES ('Bulls',2);
INSERT INTO nba.team (teamname,city) VALUES ('Lakers', 3);

INSERT INTO nba.players(playersname, teamid) VALUES ('Westbrook',1);
INSERT INTO nba.players(playersname, teamid) VALUES ('Jordan',2);
INSERT INTO nba.players(playersname, teamid) VALUES ('Johnson', 3);
INSERT INTO nba.players(playersname, teamid) VALUES ('Player 1', 3);
INSERT INTO nba.players(playersname, teamid) VALUES ('Player 2', 3);
INSERT INTO nba.players(playersname, teamid) VALUES ('Player 3', 3);
INSERT INTO nba.players(playersname, teamid) VALUES ('Player 4', 3);
INSERT INTO nba.players(playersname, teamid) VALUES ('Player 5', 3);
INSERT INTO nba.players(playersname, teamid) VALUES ('Player 6', 3);
INSERT INTO nba.players(playersname, teamid) VALUES ('Player 7', 3);
INSERT INTO nba.players(playersname, teamid) VALUES ('Player 8', 3);
INSERT INTO nba.players(playersname, teamid) VALUES ('Player 9', 3);
INSERT INTO nba.players(playersname, teamid) VALUES ('Player 10', 3);
INSERT INTO nba.players(playersname, teamid) VALUES ('Player 11', 3);
INSERT INTO nba.players(playersname, teamid) VALUES ('Player 12', 3);


UPDATE nba.players SET playersname='John Smith';

UPDATE nba.players SET teamid=2 WHERE nba.players.teamid=3;

DELETE FROM nba.team WHERE teamname='Lakers';

SELECT * FROM nba.team;
SELECT * FROM nba.players;
SELECT * FROM nba.city;



