-- 1️⃣ جدول الدول
CREATE TABLE Country (
    CountryID INT IDENTITY(1,1) PRIMARY KEY,
    CountryName NVARCHAR(100) NOT NULL,
    DialingCode NVARCHAR(10) NOT NULL   -- مثل +31 ، +971
);

INSERT INTO Country (CountryName, DialingCode) VALUES
('Afghanistan', '+93'),
('Albania', '+355'),
('Algeria', '+213'),
('Andorra', '+376'),
('Angola', '+244'),
('Argentina', '+54'),
('Armenia', '+374'),
('Australia', '+61'),
('Austria', '+43'),
('Azerbaijan', '+994'),
('Bahrain', '+973'),
('Bangladesh', '+880'),
('Belarus', '+375'),
('Belgium', '+32'),
('Belize', '+501'),
('Bolivia', '+591'),
('Bosnia and Herzegovina', '+387'),
('Brazil', '+55'),
('Bulgaria', '+359'),
('Cambodia', '+855'),
('Cameroon', '+237'),
('Canada', '+1'),
('Chile', '+56'),
('China', '+86'),
('Colombia', '+57'),
('Costa Rica', '+506'),
('Croatia', '+385'),
('Cuba', '+53'),
('Cyprus', '+357'),
('Czech Republic', '+420'),
('Denmark', '+45'),
('Dominican Republic', '+1'),
('Ecuador', '+593'),
('Egypt', '+20'),
('Estonia', '+372'),
('Ethiopia', '+251'),
('Finland', '+358'),
('France', '+33'),
('Georgia', '+995'),
('Germany', '+49'),
('Ghana', '+233'),
('Greece', '+30'),
('Hungary', '+36'),
('Iceland', '+354'),
('India', '+91'),
('Indonesia', '+62'),
('Iran', '+98'),
('Iraq', '+964'),
('Ireland', '+353'),
('Italy', '+39'),
('Japan', '+81'),
('Jordan', '+962'),
('Kazakhstan', '+7'),
('Kenya', '+254'),
('Kuwait', '+965'),
('Latvia', '+371'),
('Lebanon', '+961'),
('Libya', '+218'),
('Lithuania', '+370'),
('Luxembourg', '+352'),
('Malaysia', '+60'),
('Malta', '+356'),
('Mexico', '+52'),
('Morocco', '+212'),
('Netherlands', '+31'),
('New Zealand', '+64'),
('Nigeria', '+234'),
('Norway', '+47'),
('Oman', '+968'),
('Pakistan', '+92'),
('Palestine', '+970'),
('Peru', '+51'),
('Philippines', '+63'),
('Poland', '+48'),
('Portugal', '+351'),
('Qatar', '+974'),
('Romania', '+40'),
('Russia', '+7'),
('Saudi Arabia', '+966'),
('Serbia', '+381'),
('Singapore', '+65'),
('Slovakia', '+421'),
('Slovenia', '+386'),
('Somalia', '+252'),
('South Africa', '+27'),
('South Korea', '+82'),
('Spain', '+34'),
('Sri Lanka', '+94'),
('Sudan', '+249'),
('Sweden', '+46'),
('Switzerland', '+41'),
('Syria', '+963'),
('Thailand', '+66'),
('Tunisia', '+216'),
('Turkey', '+90'),
('Ukraine', '+380'),
('United Arab Emirates', '+971'),
('United Kingdom', '+44'),
('United States', '+1'),
('Uruguay', '+598'),
('Uzbekistan', '+998'),
('Venezuela', '+58'),
('Vietnam', '+84'),
('Yemen', '+967');

--------------------------------------------------

-- 2️⃣ جدول معلومات الاتصال
CREATE TABLE ContactInformation (
    CInfoID INT IDENTITY(1,1) PRIMARY KEY,
    Phone NVARCHAR(20),
    Email NVARCHAR(150),
    AlternativePhone NVARCHAR(20),   -- رقم احتياطي
   
);
INSERT INTO ContactInformation
(Phone, Email, AlternativePhone)
VALUES
('0612345678','ahmad@gmail.com','0688888888')
,
('0622222222','sara@yahoo.com','0622222222'),

('0633333333','john@gmail.com','0699999999');
--------------------------------------------------

-- 3️⃣ جدول العملاء
CREATE TABLE Client (
    ClientID INT IDENTITY(1,1) PRIMARY KEY,
    NationalNo NVARCHAR(50) UNIQUE,
    FullName NVARCHAR(150) NOT NULL,
    DateOfBirth DATE,
    Address NVARCHAR(250),
    Gender NVARCHAR(10),

    NationalityID INT,
    ContactInfoID INT,

    CONSTRAINT FK_Client_Country
        FOREIGN KEY (NationalityID)
        REFERENCES Country(CountryID),

    CONSTRAINT FK_Client_Contact
        FOREIGN KEY (ContactInfoID)
        REFERENCES ContactInformation(CInfoID)
);

INSERT INTO Client
(NationalNo, FullName, DateOfBirth, Address, Gender, NationalityID, ContactInfoID)
VALUES
('NL123456','Ahmad Ali','1990-05-10','Amsterdam',1,70,1),

('NL654321','Sara Hassan','1995-09-21','Rotterdam',0,70,2),

('US999888','John Smith','1988-12-01','Utrecht',1,95,3);
delete from Client Where ClientID>=1;

alter table Client 
alter Column Gender bit not null;



select Client.ClientID,Client.NationalNo,Client.FullName,Client.DateOfBirth,
GenderCaption=
Case
when Gender = 1 then 'Male'
when Gender =0 then 'Female'
end,
Country.CountryName from Client 
inner join Country
 oN Client.NationalityID=Country.CountryID;

 select*from Client;
 delete from Client Where ClientID=18;
 delete from ContactInformation where CInfoID>10;
 select*from ContactInformation;



 CREATE TABLE [User] (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    ClientID INT NOT NULL,
    UserName NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL,
    IsActive BIT NOT NULL DEFAULT 1,
    IsAdmin BIT NOT NULL DEFAULT 0,

    CONSTRAINT FK_User_Client
    FOREIGN KEY (ClientID)
    REFERENCES Client(ClientID)
);

select*from Client;
select*from Users;

INSERT INTO Users (ClientID, UserName, Password, IsActive, IsAdmin)
VALUES
(10, 'mohammed', '123456', 1, 1),
(22, 'mahmoud', '123456', 1, 0),
(25, 'ahmad', '123456', 1, 0),
(26, 'hadeel', '123456', 1, 0);


select U.UserID ,C.FullName, U.UserName,U.IsActive,U.IsAdmin From Users as U
inner join Client as C
on U.ClientID=C.ClientID


select*from Users;
SELECT 
    U.UserID,
    C.FullName, 
    U.UserName,
    U.IsActive,
    RoleName=
    CASE U.Permission
        WHEN 6 THEN 'Admin User'
        WHEN 2 THEN 'Regular User'
        WHEN 3 THEN 'Regular User'
        WHEN 5 THEN 'Regular User'
        ELSE 'Unknown Role'
    END 
FROM Users AS U
INNER JOIN Client AS C ON U.ClientID = C.ClientID;




select*from AccountType
CREATE TABLE AccountType(
    AccountID INT IDENTITY(1,1) PRIMARY KEY,

    Name NVARCHAR(50) NOT NULL UNIQUE, -- اسم نوع الحساب

    Description NVARCHAR(MAX), -- وصف الحساب

    MinBalance DECIMAL(15,2) NOT NULL, -- الحد الأدنى للرصيد
   
   InterestRate DECIMAL(5,2) NOT NULL, -- نسبة الفائدة (%)
  
  --InterestPeriod NVARCHAR(10) NOT NULL check (InterestPeriod IN ('WEEKLY', 'MONTHLY', 'YEARLY')), 
 InterestPeriod int  NOT NULL check (InterestPeriod IN (1,2,3)), 
 
   
  MaxDailyWithDrawAmount DECIMAL(15,2) NOT NULL, 
  NumberDailyWithDrawals INT NOT NULL, -- عدد مرات السحب اليومية

);
INSERT into AccountType
(Name, Description, MinBalance, InterestRate, InterestPeriod,MaxDailyWithDrawAmount, NumberDailyWithDrawals)
VALUES

-- 1. Basic Savings
(N'Basic Savings',
 N'حساب توفير أساسي مناسب للاستخدام اليومي مع حد أدنى منخفض وفائدة سنوية بسيطة',
 100.00,
 1.25,
 3,
 500.00,3),

-- 2. Premium Savings
(N'Premium Savings',
 N'حساب توفير متوسط يقدم فائدة أعلى تُصرف شهرياً مع مرونة أكبر في السحب',
 2500.00,
 2.80,
 2,
 3000.00,5),

-- 3. Gold Savings
(N'Gold Savings',
 N'حساب مميز للعملاء ذوي الأرصدة المرتفعة مع فائدة عالية وسقوف سحب كبيرة',
 20000.00,
 4.75,
 1,
 15000.00,10);


 select*from Client;
select*from Account;

CREATE TABLE Account (
    AccountID INT PRIMARY KEY,
    ClientID int not null ,
    AccountNumber VARCHAR(50) UNIQUE,
    AccountTypeID INT not null,
    Balance DECIMAL(18, 2),
    AccountState int,
    UpdatedAt DATETIME2 DEFAULT GETDATE(),
    FOREIGN KEY (AccountTypeID) REFERENCES AccountType(AccountTypeID),
    Foreign key (ClientID) References Client (ClientID)
);
INSERT INTO Account 
(AccountID, ClientID, AccountNumber, AccountTypeID, Balance, AccountState)
VALUES

-- Client 1 (Basic)
(1, 10, 'ACC1001', 1, 200.00, 1),

-- Client 2 (Basic)
(2, 22, 'ACC1002', 1, 500.00, 1),

-- Client 3 (Premium)
(3, 25, 'ACC2001', 2, 3000.00, 1),

-- Client 4 (Premium)
(4, 26, 'ACC2002', 2, 7000.00, 1),

-- Client 5 (Gold)
(5, 29, 'ACC3001', 3, 25000.00, 1),

-- Client 6 (Gold)
(6, 30, 'ACC3002', 3, 50000.00, 1);



CREATE TABLE Application (
    ApplicationID INT IDENTITY(1,1) PRIMARY KEY,
    ClientID INT NOT NULL,
    ApplicationTypeID INT NOT NULL,
    ApplicationStatus INT NOT NULL,
    ApplicationDate DATE NOT NULL,
    PaidFees DECIMAL(18, 2) NOT NULL,
    UserID INT NOT NULL,
    
    CONSTRAINT FK_Application_Client FOREIGN KEY (ClientID) 
        REFERENCES Client(ClientID),
  
  CONSTRAINT FK_Application_ApplicationType FOREIGN KEY (ApplicationTypeID) 
        REFERENCES ApplicationType(ApplicationTypeId),
 
 CONSTRAINT FK_Application_User FOREIGN KEY (UserID) 
        REFERENCES Users(UserID)
);

ALTER TABLE Account
ADD ApplicationID INT  NULL; 

ALTER TABLE Account
ADD CONSTRAINT FK_Account_Application 
FOREIGN KEY (ApplicationID) REFERENCES Application(ApplicationID);


select*from AccountType;

select Account.AccountID,Account.AccountNumber , AccountName=
    CASE Account.AccountTypeID
        WHEN 1 THEN 'Basic Savings'
        WHEN 2 THEN 'Premium Savings'
        WHEN 3 THEN 'Gold Savings'
        ELSE 'Unknown Role'
    END,
     Client.FullName ClientName,Account.Balance,AccountState=
    CASE Account.AccountState 
        WHEN 1 THEN 'Active'
        WHEN 2 THEN 'Forzen'
        WHEN 3 THEN 'Closed'
        ELSE 'Unknown'
    END,Account.UpdatedAt
    From Account 
    inner join Application on Account.ApplicationID=Application.ApplicationID
    inner join  Client on Application.ClientID=Client.ClientID




    CREATE TABLE [Transaction] (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    AccountID INT NOT NULL,
    Amount DECIMAL(18, 2) NOT NULL,
    TransactionDate DATETIME NOT NULL DEFAULT GETDATE(),
    ApplicationID INT NOT NULL,
    UserID INT NOT NULL,
    CONSTRAINT FK_Transaction_Account FOREIGN KEY (AccountID) REFERENCES Account(AccountID),
    CONSTRAINT FK_Transaction_Application FOREIGN KEY (ApplicationID) REFERENCES Application(ApplicationID),
    CONSTRAINT FK_Transaction_User FOREIGN KEY (UserID) REFERENCES [Users](UserID)
);

INSERT INTO [Transaction] (AccountID, ApplicationID, UserID, Amount, TransactionDate)
VALUES 
    ( 1, 18, 2500.00, '2026-04-15 00:00:00'),
    ( 2, 33, 60000.00, '2026-04-15 13:09:46.903'),
    ( 2, 34, 89898.00, '2026-04-15 12:36:18.140'),
    ( 3, 25, 12500.00, '2026-04-16 10:30:00'); -- الصف الرابع (مثال)

select*from Account;


CREATE TABLE WithDrawalTransaction (
    WTransactionID INT IDENTITY(1,1) PRIMARY KEY,
    TransactionID INT NOT NULL,
    CONSTRAINT FK_WithDrawalTransaction_Transaction FOREIGN KEY (TransactionID) 
        REFERENCES [Transaction](TransactionID)
);
select*from [Transaction];
select*from WithDrawalTransaction;

SELECT COUNT(T.TransactionID)

FROM [Transaction] T 
INNER JOIN WithDrawalTransaction W ON T.TransactionID = W.TransactionID
inner join Account A ON T.AccountID=A.AccountID
WHERE YEAR(T.TransactionDate) = YEAR(GETDATE()) 
  AND MONTH(T.TransactionDate) = MONTH(GETDATE())
  AND DAY(T.TransactionDate) = DAY(GETDATE()) and A.AccountID=1


CREATE TABLE DepositTransaction (
    DTransactionID INT IDENTITY(1,1) PRIMARY KEY,
    TransactionID INT NOT NULL,
    CONSTRAINT FKDepositTransaction FOREIGN KEY (TransactionID) 
        REFERENCES [Transaction](TransactionID)
);

Create Table InternalTransfer(
DInternalTransferID int identity(1,1) primary key,
RecipientAccount int not null,
TransactionID int not null,

Constraint FKRecipientAccount Foreign key (RecipientAccount) 
References Account(AccountID),

CONSTRAINT FKDepositTransaction FOREIGN KEY (TransactionID) 
        REFERENCES [Transaction](TransactionID)
);


Create Table InternalTansfer(
DInternalTransferID int identity(1,1) primary key,
RecipientAccount int not null,
TransactionID int not null,

Constraint FKRecipientAccount Foreign key (RecipientAccount) 
References Account(AccountID),

CONSTRAINT FKExternalTransfer FOREIGN KEY (TransactionID) 
        REFERENCES [Transaction](TransactionID)
);



Create Table ExternalTransfer(

ID int identity(1,1) primary key,
IBAN int not null,
BankName  VARCHAR(50),
RecipientAccountID int not null,
TransactionID int not null,--FK


CONSTRAINT FKExternalTransfer FOREIGN KEY (TransactionID) 
        REFERENCES [Transaction](TransactionID)
);




SELECT COLUMN_NAME, DATA_TYPE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = '';   

select*from AccountType

Basic Savings
Premium Savings
Gold Savings
select*from Account;
select found=1 from Account 
                             where AccountNumber=1010


select*from ExternalTransfer
select*from InternalTransfer;
                               SELECT COUNT(T.TransactionID)
FROM [Transaction] T INNER JOIN InternalTransfer I ON T.TransactionID = I.TransactionID
inner join Account A ON T.AccountID=A.AccountID
WHERE YEAR(T.TransactionDate) = YEAR(GETDATE()) 
AND MONTH(T.TransactionDate) = MONTH(GETDATE())
AND DAY(T.TransactionDate) = DAY(GETDATE()) and A.AccountID=20


select*from Account;

delete from Application Where ApplicationID >60
delete from [Transaction] where TransactionID>=14
delete from WithDrawalTransaction where WTransactionID>=7



select*from Account
select*from Application
select*from [Transaction]
select*from WithDrawalTransaction
select*from DepositTransaction;
select*from ExternalTransfer;
select*from InternalTransfer;

delete from [Transaction] where TransactionID>=17
delete from InternalTransfer where ID>=1
delete from DepositTransaction where DTransactionID=1

select*from Account;

select Account.AccountID,AccountType.AccountTypeID,
Application.ApplicationDate
,AccountType.InterestPeriod,AccountType.InterestRate 
from Account inner join Application on Account.ApplicationID = Application.ApplicationID
inner join AccountType on Account.AccountTypeID = AccountType.AccountTypeID
select*from Account


select Account.AccountID,Account.LastInterestDate,AccountType.AccountTypeID,
Application.ApplicationDate
,AccountType.InterestPeriod,AccountType.InterestRate 
from Account inner join Application on Account.ApplicationID = Application.ApplicationID
inner join AccountType on Account.AccountTypeID = AccountType.AccountTypeID



select*from Users