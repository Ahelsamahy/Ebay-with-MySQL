--Procedures--

CREATE DEFINER=`root`@`localhost` PROCEDURE `cartype`.`DeleteCars`(in param_Id int)
begin 
    DELETE car, rented_cars
from car 
left join rented_cars on car.carID = rented_cars.carID 
where car.carID = param_Id;
end

----------------------------------------------------------------------------

CREATE DEFINER=`root`@`localhost` PROCEDURE `cartype`.`DeleteUsers`(in param_Id int)
begin 
    DELETE users, rented_cars
from users 
left join rented_cars on users.UserID = rented_cars.userID 
where users.UserID = param_Id;
end

----------------------------------------------------------------------------

CREATE DEFINER=`root`@`localhost` PROCEDURE `cartype`.`GetCars`(IN param_ID int)
BEGIN
    SELECT * 
     FROM car
    WHERE carID = param_ID;
END

----------------------------------------------------------------------------

CREATE DEFINER=`root`@`localhost` PROCEDURE `cartype`.`GetUsers`(IN param_ID int)
BEGIN
    SELECT * 
     FROM users
    WHERE UserID = param_ID;
END

----------------------------------------------------------------------------

CREATE DEFINER=`root`@`localhost` PROCEDURE `cartype`.`SaveCars`(in param_Type varchar(100), in param_Brand varchar(100), 
					      in param_License_plate varchar(100),in param_CarID int)
begin 
    insert into  car (`Type` ,Brand ,license_plate ,carID ) 
   			values(param_Type,param_Brand,param_License_plate,param_CarID);
end

----------------------------------------------------------------------------

CREATE DEFINER=`root`@`localhost` PROCEDURE `cartype`.`SaveUsers`(in param_FirstName varchar(100), in param_SecondName varchar(100), 
					      in param_UserID int)
begin 
    insert into  users (UserID,firstName ,SecondName) 
   			values(param_UserID,param_FirstName,param_SecondName);
end
















