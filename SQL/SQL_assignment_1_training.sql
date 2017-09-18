CREATE DATABASE training;

CREATE TABLE training.training_parent (
  id INT(32) NOT NULL AUTO_INCREMENT COMMENT 'Unique Primary ID',
  firstname VARCHAR(32) NOT NULL DEFAULT '',
  lastname VARCHAR(32) NOT NULL DEFAULT '',
  PRIMARY KEY (id)
);

CREATE TABLE training.training_child (
  id INT(32) NOT NULL AUTO_INCREMENT COMMENT 'Unique Primary ID',
  firstname VARCHAR(32) NOT NULL DEFAULT '',
  lastname VARCHAR(32) NOT NULL DEFAULT '',
  parent INT(32),
  PRIMARY KEY (id),
  FOREIGN KEY (parent) REFERENCES training_parent (id)
);

INSERT INTO training.training_parent (firstname, lastname) VALUES ('Bob', 'Stone');
INSERT INTO training.training_parent (firstname, lastname) VALUES ('Gary', 'Busey');
INSERT INTO training.training_parent (firstname, lastname) VALUES ('Tom', 'Handy');
INSERT INTO training.training_parent (firstname, lastname) VALUES ('Phil', 'Smith');
INSERT INTO training.training_parent (firstname, lastname) VALUES ('Jeff', 'Johnson');

INSERT INTO training.training_child (firstname, lastname, parent) VALUES ('Timmy', 'Stone', 1);
INSERT INTO training.training_child (firstname, lastname, parent) VALUES ('Todd', 'Johnson', 5);
INSERT INTO training.training_child (firstname, lastname, parent) VALUES ('Brandy', 'Handy', 3);
INSERT INTO training.training_child (firstname, lastname, parent) VALUES ('Jackson', 'Smith', 4);
INSERT INTO training.training_child (firstname, lastname, parent) VALUES ('Harold', 'Busey', 2);
INSERT INTO training.training_child (firstname, lastname, parent) VALUES ('Bobby', 'Stone', 1);

DELETE FROM training.training_child WHERE id=5;

CREATE TABLE training.new_parents LIKE training.training_parent;

DROP TABLE training.new_parents;

SELECT * FROM training.training_parent;
SELECT * FROM training.training_child;
