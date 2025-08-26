CREATE TABLE EmployeeManager (
    Emp_Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100) NOT NULL,
    Salary DECIMAL(10, 2) NOT NULL,
    ManagerId INT ,
   
);


INSERT INTO EmployeeManager(Name, Salary, ManagerID) VALUES
('John', 60000.00, Null),      
('Jane', 55000.00, 1),      
('Mike', 50000.00, 2),      
('vinod',25000.00, 4);  
SELECT Name, ManagerId FROM EmployeeManager ORDER BY Name;