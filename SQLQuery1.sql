

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

--delete from floor_spots where floorID = (select f.floor_ID from floors f where f.floor_Name = 'A' );

--select car_Spots from floors where floor_Name = 'A';


--INSERT INTO floor_spots ( floorID, carspot) 
--        SELECT floor_ID, 1 
--        FROM floors 
--        WHERE floor_name = 'A';

--        select * from floor_spots;

--INSERT INTO floor_spots (floorID, carspot) 
--        SELECT f.floor_ID, 1 
--        FROM floors f
--        WHERE f.floor_name = 'A'
--        AND NOT EXISTS (
--            SELECT 1
--            FROM floor_spots fs
--            WHERE fs.floorID = f.floor_ID);

--            select * from floor_spots;

--update fs
--set fs.carspot = 1,
--fs.floorID = (
--select f.floor_ID from floors as f 
--where f.floor_Name = 'A')from floor_spots as fs
--where fs.spot_ID = (select min(spot_ID)
--from floor_spots
--where carspot = 0 and taken = 0);
--update floor_spots 
--set carspot = 1 
--(select f.floor_ID from floors f where f.floor_Name = 'A');
--update floor_spots set carspot = 1, floorID = 1 where spot_ID = 1;
--UPDATE floor_spots SET carspot = CAST(1 AS BIT), floorID = 1, taken = cast(1 as bit);

--select f.floor_ID from floors f where f.floor_Name = 'A';
--select * from floor_spots;
--select * from floors;

