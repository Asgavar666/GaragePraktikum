

--create table floors(
--floor_ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
--floor_Name varchar(48),
--car_Spots int,
--motorbike_Spots int);

--create table floor_spots(
--spot_ID int identity(1,1) not null primary key,
--floorID int foreign key references floors(floor_ID),
--carspot bit default 0 not null,
--motorspot bit default 0 not null,
--taken bit default 0 not null
--);

--create table vehicle(
--plate_No varchar(255) primary key,
--spotID int foreign key references floor_spots(spot_ID),
--isCar bit default 0 not null
--);

--DECLARE @maxFloorID INT
--SELECT @maxFloorID = MAX(floor_ID) FROM floors

--DECLARE @currentFloorID INT
--SET @currentFloorID = 1

--WHILE @currentFloorID <= @maxFloorID
--BEGIN
--    DECLARE @carSpots INT
--    DECLARE @motorbikeSpots INT

--    SELECT @carSpots = car_Spots, @motorbikeSpots = motorbike_Spots FROM floors WHERE floor_ID = @currentFloorID

--    DECLARE @counter INT
--    SET @counter = 1

--    WHILE @counter <= @carSpots
--    BEGIN
--        INSERT INTO floor_spots (floorID, carspot, motorspot, taken)
--        VALUES (@currentFloorID, 1, 0, 0)
--        SET @counter = @counter + 1
--    END

--    SET @counter = 1

--    WHILE @counter <= @motorbikeSpots
--    BEGIN
--        INSERT INTO floor_spots (floorID, carspot, motorspot, taken)
--        VALUES (@currentFloorID, 0, 1, 0)
--        SET @counter = @counter + 1
--    END

--    SET @currentFloorID = @currentFloorID + 1
--END




----SELECT floor_Name 
----FROM floors 
----WHERE floor_ID IN (
----    SELECT floor_ID 
----    FROM floor_spots 
----    WHERE taken = 0 
----)
----ORDER BY floor_ID 
----OFFSET 0 ROWS 
----FETCH FIRST 1 ROW ONLY;

-- select spot_ID from floor_spots where carspot = 0

--select * from floors;
--select * from floor_spots;
--SELECT TOP 1 f.floor_Name FROM floors f JOIN floor_spots fs ON f.floor_ID = fs.floorID WHERE fs.taken = 0 ORDER BY f.floor_ID;
--select top 1 s.spot_ID from floor_spots s join  floors f on s.floorID = f.floor_ID where s.taken = 0 and s.carspot = 1  order by s.spot_ID;
-- select top 1 s.spot_ID from floor_spots s join floors f on s.floorID = (select f.floor_ID where f.floor_Name = 'A') where s.taken = 0 and s.carspot = 1  order by s.spot_ID;