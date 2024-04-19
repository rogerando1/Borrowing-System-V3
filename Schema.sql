CREATE TABLE Person(
	personID INT,
    firstname VARCHAR(255),
    middleinitial VARCHAR(255),
    lastname VARCHAR(255),
    PRIMARY KEY (personID)
);

CREATE TABLE Student(
	personID INT,
    studentID VARCHAR(255),
    program VARCHAR(255),
    yearlevel INT,
	FOREIGN KEY(personID)
		REFERENCES Person(personID),
	PRIMARY KEY (studentID)
);

CREATE TABLE Instructor(
	personID INT,
    instructorID VARCHAR(255),
    courseID VARCHAR(255),
    FOREIGN KEY(personID)
		REFERENCES Person(personID),
    PRIMARY KEY (instructorID)    
);

CREATE TABLE Accounts(
	personID INT,
    accountID VARCHAR(255),
    username VARCHAR(255),
    password_ VARCHAR(255),
    position VARCHAR (255),
    FOREIGN KEY (personID)
		REFERENCES Person(personID),
    PRIMARY KEY (accountID)
);

CREATE TABLE Course(
	courseID VARCHAR(255),
    coursename VARCHAR(255),
    courseTIME VARCHAR (255),
    PRIMARY KEY (courseID)
);

CREATE TABLE Product(
	productID INT,
    productname VARCHAR(255),
    PRIMARY KEY (productID)
);

CREATE TABLE Part(
	productID INT,
    partID INT,
    partname VARCHAR(255),
    partdescription VARCHAR(255),
    quantity INT,
    FOREIGN KEY (productID)
		REFERENCES Product (productID),
	PRIMARY KEY (partID)
);

CREATE TABLE Transactions(
	transactionID INT,
    studentID VARCHAR(255),
    instructorID VARCHAR(255),
    accountID VARCHAR(255),
    productID INT,
    quantity INT,
    orderdate DATE,
    ordertime TIME,
    status_ VARCHAR(255),
    FOREIGN KEY (studentID)
		REFERENCES Student (studentID),
	FOREIGN KEY (instructorID)
		REFERENCES Instructor (instructorID),
	FOREIGN KEY (accountID)
		REFERENCES Accounts (accountID),
	FOREIGN KEY (productID)
		REFERENCES Product(productID),
	PRIMARY KEY (transactionID)
);

CREATE TABLE TransactionLogs(
	transactionlogID INT,
    transactionID INT,
    returndate DATE,
    returntime TIME,
    FOREIGN KEY (transactionID)
		REFERENCES Transactions(transactionID),
    PRIMARY KEY (transactionlogID)
);
