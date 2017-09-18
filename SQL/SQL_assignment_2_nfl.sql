CREATE DATABASE nfl;

CREATE TABLE nfl.team (
  id INT(32) NOT NULL AUTO_INCREMENT COMMENT 'Unique Primary ID',
  teamname VARCHAR(32) NOT NULL DEFAULT '',
  PRIMARY KEY (id)
);

CREATE TABLE nfl.players (
  id INT(32) NOT NULL AUTO_INCREMENT COMMENT 'Unique Primary ID',
  playersname VARCHAR(32) NOT NULL DEFAULT '',
  teamid INT(32),
  PRIMARY KEY (id),
  FOREIGN KEY (teamid) REFERENCES nfl.team (id)
);



INSERT INTO nfl.team (teamname) VALUE ('Miami Dolphins');
INSERT INTO nfl.team (teamname) VALUE ('Dallas Cowboys');
INSERT INTO nfl.team (teamname) VALUE ('Seattle Seahawks');
INSERT INTO nfl.team (teamname) VALUE ('Oakland Raiders');


INSERT INTO nfl.players(playersname, teamid) VALUES ('Tony Dorsett', 4);
INSERT INTO nfl.players(playersname, teamid) VALUES ('Michael Irvin', 4);
INSERT INTO nfl.players(playersname, teamid) VALUES ('Troy Aikman', 4);
INSERT INTO nfl.players(playersname, teamid) VALUES ('Larry Allen', 4);
INSERT INTO nfl.players(playersname, teamid) VALUES ('Mel Renfro', 4);
INSERT INTO nfl.players(playersname, teamid) VALUES ('Dan Marino', 1);
INSERT INTO nfl.players(playersname, teamid) VALUES ('Earl Morrall', 1);
INSERT INTO nfl.players(playersname, teamid) VALUES ('Paul Warfield', 1);
INSERT INTO nfl.players(playersname, teamid) VALUES ('Mark Duper', 1);
INSERT INTO nfl.players(playersname, teamid) VALUES ('Bob Griese', 1);
INSERT INTO nfl.players(playersname, teamid) VALUES ('Russell Wilson', 3);
INSERT INTO nfl.players(playersname, teamid) VALUES ('Tarvaris Jackson', 3);
INSERT INTO nfl.players(playersname, teamid) VALUES ('Matt Hasselbeck', 3);
INSERT INTO nfl.players(playersname, teamid) VALUES ('Warren Moon', 3);
INSERT INTO nfl.players(playersname, teamid) VALUES ('Jim Zorn', 3);

UPDATE nfl.players SET playersname='John Smith';

UPDATE nfl.players SET teamid=2 WHERE nfl.players.teamid=4;

DELETE FROM nfl.team WHERE teamname='Oakland Raiders';

SELECT * FROM nfl.team;
SELECT * FROM nfl.players;


