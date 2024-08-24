CREATE TABLE [Identity]
(
    Id        UNIQUEIDENTIFIER PRIMARY KEY,
    Username  VARCHAR(255) NOT NULL,
    Email     VARCHAR(255) NOT NULL UNIQUE,
    Password  VARCHAR(255) NOT NULL,
    Birthdate DATE         NOT NULL
);

CREATE TABLE Student
(
    Id        UNIQUEIDENTIFIER PRIMARY KEY,
    Username  VARCHAR(255) NOT NULL,
    Birthdate DATE,
    Email     VARCHAR(255),
    Room_Id   UNIQUEIDENTIFIER,
    FOREIGN KEY (Room_Id) REFERENCES Room (Id)
);

CREATE TABLE Room
(
    Id         UNIQUEIDENTIFIER PRIMARY KEY,
    Floor      INT,
    RoomNumber INT,
    Student_Id UNIQUEIDENTIFIER,
    FOREIGN KEY (Student_Id) REFERENCES Student (Id)
);

CREATE TABLE HousingTask
(
    Id          UNIQUEIDENTIFIER PRIMARY KEY,
    Title       VARCHAR(255) NOT NULL,
    Description varchar(520),
    State       varchar(125),
    Student_Id  UNIQUEIDENTIFIER,
    FOREIGN KEY (Student_Id) REFERENCES Student (Id)
);

CREATE TABLE GarbageDisposal
(
    Id             UNIQUEIDENTIFIER PRIMARY KEY,
    GarbageType    VARCHAR(50) NOT NULL,
    DateOfDisposal DATE
);

CREATE TABLE Complaint
(
    Id          UNIQUEIDENTIFIER PRIMARY KEY,
    Title       VARCHAR(255) NOT NULL,
    Description varchar(520)
);

-- Auth Procedures
CREATE PROCEDURE spLoginWithUsernameAndPassword(
    @Username VARCHAR(255),
    @Password VARCHAR(255)
)
AS
BEGIN
    SELECT *
    FROM [Identity]
    WHERE Username = @Username
      AND Password = @Password;
END;

CREATE PROCEDURE spRegister(
    @Id UNIQUEIDENTIFIER,
    @Username VARCHAR(255),
    @Email VARCHAR(255),
    @Password VARCHAR(255),
    @Birthdate DATE
)
AS
BEGIN
    INSERT INTO [Identity] (Id, Username, Email, Password, Birthdate)
    VALUES (@Id, @Username, @Email, @Password, @Birthdate);
END;

CREATE PROCEDURE spGetIdentityByEmail(
    @Email VARCHAR(255)
)
AS
BEGIN
    SELECT *
    FROM [Identity]
    WHERE Email = @Email;
END;

-- Student Procedures
CREATE PROCEDURE spGetStudentById(@Id UNIQUEIDENTIFIER)
AS
BEGIN
    SELECT *
    FROM Student
    WHERE Id = @Id;
END;

CREATE PROCEDURE spGetStudentByUsername(@Username VARCHAR(255))
AS
BEGIN
    SELECT *
    FROM Student
    WHERE Username = @Username;
END;

CREATE PROCEDURE spCreateStudent(
    @Id UNIQUEIDENTIFIER,
    @Username VARCHAR(255),
    @Birthdate DATE,
    @Email VARCHAR(255),
    @RoomId UNIQUEIDENTIFIER
)
AS
BEGIN
    INSERT INTO Student (Id, Username, Birthdate, Email, Room_Id)
    VALUES (@Id, @Username, @Birthdate, @Email, @RoomId);
END;

-- HousingTasks Procedures
CREATE PROCEDURE spCreateHousingTask(
    @Id UNIQUEIDENTIFIER,
    @Title VARCHAR(255),
    @Description varchar(520),
    @StudentId UNIQUEIDENTIFIER
)
AS
BEGIN
    INSERT INTO HousingTask (Id, Title, Description, Student_Id)
    VALUES (@Id, @Title, @Description, @StudentId);
END;

CREATE PROCEDURE spDeleteHousingTaskById(@Id UNIQUEIDENTIFIER)
AS
BEGIN
    DELETE
    FROM HousingTask
    WHERE Id = @Id;
END;

CREATE PROCEDURE spUpdateHousingTaskState(
    @Id UNIQUEIDENTIFIER,
    @State VARCHAR(255)
)
AS
BEGIN
    UPDATE HousingTask
    SET State = @State
    WHERE Id = @Id;
END;

-- Complaints Procedures
CREATE PROCEDURE spCreateComplaint(
    @Id UNIQUEIDENTIFIER,
    @Title VARCHAR(255),
    @Description varchar(520)
)
AS
BEGIN
    INSERT INTO Complaint (Id, Title, Description)
    VALUES (@Id, @Title, @Description);
END;

CREATE PROCEDURE spGetAllComplaints
AS
BEGIN
    SELECT *
    FROM Complaint;
END;

-- Rooms Procedures
CREATE PROCEDURE spGetAllRooms
AS
BEGIN
    SELECT *
    FROM Room;
END;

CREATE PROCEDURE spGetAvailableRooms
AS
BEGIN
    SELECT *
    FROM Room
    WHERE Student_Id IS NULL;
END;

CREATE PROCEDURE spGetRoomById(@Id UNIQUEIDENTIFIER)
AS
BEGIN
    SELECT *
    FROM Room
    WHERE Id = @Id;
END;

CREATE PROCEDURE spCreateRoom(
    @Id UNIQUEIDENTIFIER,
    @Floor INT,
    @RoomNumber INT
)
AS
BEGIN
    INSERT INTO Room (Id, Floor, RoomNumber)
    VALUES (@Id, @Floor, @RoomNumber);
END;

CREATE PROCEDURE spAssignStudentToTheRoom(
    @StudentId UNIQUEIDENTIFIER,
    @RoomId UNIQUEIDENTIFIER
)
AS
BEGIN
    UPDATE Room
    SET Student_Id = @StudentId
    WHERE Id = @RoomId;

    UPDATE Student
    SET Room_Id = @RoomId
    WHERE Id = @StudentId;
END;
