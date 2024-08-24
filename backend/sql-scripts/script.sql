create table Complaint
(
    Id          uniqueidentifier not null,
    Title       varchar(255)     not null,
    Description varchar(520)
);

alter table Complaint
    add primary key (Id);

create table GarbageDisposal
(
    Id             uniqueidentifier not null,
    GarbageType    varchar(50)      not null,
    DateOfDisposal date
);

alter table GarbageDisposal
    add primary key (Id);

create table HousingTask
(
    Id          uniqueidentifier not null,
    Title       varchar(255)     not null,
    Description varchar(520),
    State       smallint         not null,
    Student_Id  uniqueidentifier
);

alter table HousingTask
    add primary key (Id);

create table [Identity]
(
    Id        uniqueidentifier   not null,
    Username  varchar(255)       not null,
    Email     varchar(255)       not null,
    Password  varchar(255)       not null,
    Birthdate date               not null,
    Role      smallint default 0 not null
);

alter table [Identity]
    add primary key (Id);

alter table [Identity]
    add unique (Email);

alter table [Identity]
    add constraint DF__Identity__Role__49E3F248 default 0 for Role;


create table Room
(
    Id         uniqueidentifier not null,
    Floor      int,
    RoomNumber int,
    Student_Id uniqueidentifier
);

alter table Room
    add primary key (Id);

create table Student
(
    Id        uniqueidentifier not null,
    Username  varchar(255)     not null,
    Birthdate date,
    Email     varchar(255),
    Room_Id   uniqueidentifier
);

alter table Student
    add primary key (Id);

alter table Room
    add constraint FK_Room_Student
        foreign key (Student_Id) references Student;

alter table Student
    add constraint FK_Student_Room
        foreign key (Room_Id) references Room;

create procedure spAssignStudentToTheRoom(@StudentId uniqueidentifier, @RoomId uniqueidentifier) as
BEGIN
    UPDATE Room
    SET Student_Id = @StudentId
    WHERE Id = @RoomId;

    UPDATE Student
    SET Room_Id = @RoomId
    WHERE Id = @StudentId;
END;

create procedure spCreateComplaint(@Id uniqueidentifier, @Title varchar(255), @Description varchar(520)) as
BEGIN
                                        INSERT INTO Complaint (Id, Title, Description)
                                        VALUES (@Id, @Title, @Description);
                                    END;

create procedure spCreateHousingTask(@Id uniqueidentifier, @Title varchar(255), @Description varchar(520),
                                     @State varchar(100), @StudentId uniqueidentifier) as
BEGIN
                            INSERT INTO HousingTask (Id, Title, Description,State, Student_Id)
                            VALUES (@Id, @Title, @Description, @State,@StudentId);
                        END;

create procedure spCreateRoom(@Id uniqueidentifier, @Floor int, @RoomNumber int) as
BEGIN
                                                            INSERT INTO Room (Id, Floor, RoomNumber)
                                                            VALUES (@Id, @Floor, @RoomNumber);
                                                        END;

create procedure spCreateStudent(@Id uniqueidentifier, @Username varchar(255), @Birthdate date, @Email varchar(255),
                                 @RoomId uniqueidentifier) as
BEGIN
                        INSERT INTO Student (Id, Username, Birthdate, Email)
                        VALUES (@Id, @Username, @Birthdate, @Email);
                        
                        EXEC spAssignStudentToTheRoom @Id, @RoomId
                    END;

create procedure spDeleteHousingTaskById(@Id uniqueidentifier) as
BEGIN
                                DELETE
                                FROM HousingTask
                                WHERE Id = @Id;
                            END;

create procedure spGetAllComplaints() as
BEGIN
                                            SELECT *
                                            FROM Complaint;
                                        END;

create procedure spGetAllRooms() as
BEGIN
                                                SELECT *, r.Id as RoomId
                                                FROM Room r;
                                            END;

create procedure spGetAvailableRooms() as
BEGIN
                                                    SELECT *, r.Id as RoomId
                                                    FROM Room r
                                                    WHERE Student_Id IS NULL;
                                                END;

create procedure spGetIdentityByEmail(@Email varchar(255)) as
BEGIN
            SELECT *
            FROM [Identity]
            WHERE Email = @Email;
        END;

create procedure spGetRoomById(@Id uniqueidentifier) as
BEGIN
                                                        SELECT *, r.id as RoomId
                                                        FROM Room r
                                                        WHERE Id = @Id;
                                                    END;

create procedure spGetStudentById(@Id uniqueidentifier) as
BEGIN
    SELECT s.Id, s.Username, s.Email, s.Birthdate,
           r.Id as RoomId, r.Floor, r.RoomNumber,
           ht.Id as HousingTaskId, ht.Title, ht.Description, ht.State
    FROM Student s
             LEFT JOIN Room r ON s.Room_Id = r.Id
             LEFT JOIN HousingTask ht ON s.Id = ht.Student_Id
    WHERE s.Id = @Id;
END;

create procedure spGetStudentByUsername(@Username varchar(255)) as
BEGIN
    SELECT s.Id as Id, s.Username, s.Email, s.Birthdate,
           r.Id as RoomId, r.Floor, r.RoomNumber,
           ht.Id as HousingTaskId, ht.Title, ht.Description, ht.State
    FROM Student s
             LEFT JOIN Room r ON s.Room_Id = r.Id
             LEFT JOIN HousingTask ht ON s.Id = ht.Student_Id
    WHERE s.Username = @Username;
END;

create procedure spGetIdentityByUsername(@Username varchar(255)) as
BEGIN
    SELECT *
    FROM [Identity]
    WHERE Username = @Username;
END;

create procedure spRegister(@Id uniqueidentifier, @Username varchar(255), @Email varchar(255), @Password varchar(255),
                            @Role smallint, @Birthdate date) as
BEGIN
        INSERT INTO [Identity] (Id, Username, Email, Password, Birthdate, Role)
        VALUES (@Id, @Username, @Email, @Password, @Birthdate, @Role);
    END;

create procedure spUpdateHousingTaskState(@Id uniqueidentifier, @State varchar(255)) as
BEGIN
                                    UPDATE HousingTask
                                    SET State = @State
                                    WHERE Id = @Id;
                                END;
