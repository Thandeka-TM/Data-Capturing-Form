CREATE DATABASE BelgiumCampusDatabase
GO
USE BelgiumCampusDatabase
GO

CREATE TABLE Students(
studentNumber INT PRIMARY KEY,
studentName VARCHAR(50) NOT NULL,
studentSurname VARCHAR(50) NOT NULL,
studentImage VARCHAR(80) NOT NULL,
studentDOB DATE NOT NULL,
gender VARCHAR(30),
phone VARCHAR(20),
studentAddress VARCHAR(50) NOT NULL,
studentModuleCodes VARCHAR(50) NOT NULL
);

GO
INSERT INTO Students VALUES
(0001, 'Larry', 'Smith', 'larrysmith.png', '2000-01-18', 'Male', '222-123-4561', '12 Brookpale str, Ninapark, Pretoria', 'MAT281, STA281, PRG281, PRG282'),
(0002, 'Susan', 'Wilson', 'susanwilson.png', '2001-10-04', 'Female', '222-234-1256', '45 Patlane str, Amandasig, Pretoria', 'LPR281, INF281, WPR281, MAT281'),
(0003, 'Lauren', 'Martin', 'laurenmartin.png', '2002-06-20', 'Female', '222-111-8937', '23 Kleinn str, Midrand, Johanesburg', 'STA281, DBD281, IOT281, MAT281'),
(0004, 'Joe', 'Johnson', 'joejohnson.png', '2003-09-25', 'Male', '222-778-1223', '4th Avenue, Fauren, Pretoria', 'SAD281, SWT281, MAT281, PRG281'),
(0005, 'Scott', 'McKnight', 'scottmcknight.png', '2002-11-17', 'Male', '222-567-8888', '81 Stoolpan str, Dallen, Pretoria', 'PMM281, MAT281, IOT281, LPR281')
;

GO
CREATE TABLE Module(
moduleCode VARCHAR(50) NOT NULL,
moduleName VARCHAR(50) NOT NULL,
moduleDescription VARCHAR(60),
moduleResourceLink VARCHAR(70),
);

GO
INSERT INTO Module VALUES
('MAT281','Mathematics','Mathematics module for second years.','www.youtube/moduleslearning/maths.com'),
('PRG281','Programming','Programming module for second years.','www.youtube/moduleslearning/prg.com'),
('PRG282','Programming','Programming module for second years part2 continuation.','www.youtube/moduleslearning/prg_part2.com'),
('IOT281','Internet Of Things','Internet Of Things module for second years.','www.youtube/moduleslearning/iot.com'),
('STA281','Statistics','Statistics module for second years.','www.youtube/moduleslearning/statistics.com')
;