drop table History

CREATE TABLE [dbo].[History](
idTest int primary key identity(0,1),
Userpassword int FOREIGN KEY REFERENCES [dbo].[Users](Userpassword),
TestDate date,
Mark int
);
