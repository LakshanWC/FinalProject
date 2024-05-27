CREATE TABLE employee (
    Eid VARCHAR(20) PRIMARY KEY,
    Ename VARCHAR(50),
    Enic VARCHAR(13),
    Eaddress VARCHAR(100),
    Edob DATE,
    Etel INT,
    Eusername VARCHAR(30),
    Epassword VARCHAR(20),
    OtHours INT
);

CREATE TABLE attendance (
    Eno VARCHAR(20),
    todays DATE,
    PRIMARY KEY (Eno, todays),
    FOREIGN KEY (Eno) REFERENCES employee (Eid)
);


CREATE TABLE manager (
    Mid VARCHAR(20) PRIMARY KEY,
    FOREIGN KEY (Mid) REFERENCES employee (Eid)
);

CREATE TABLE chef (
    CHid VARCHAR(20) PRIMARY KEY,
	FOREIGN KEY (CHid) REFERENCES employee (Eid)
);

CREATE TABLE cashier (
    CAid VARCHAR(20) PRIMARY KEY,
	FOREIGN KEY (CAid) REFERENCES employee(Eid)
);

CREATE TABLE deliveryman (
    Did VARCHAR(20) PRIMARY KEY,
	FOREIGN KEY (Did) REFERENCES employee (Eid)
);

CREATE TABLE salesAndFinance (
    SFMid VARCHAR(20) PRIMARY KEY,
	SFMemail VARCHAR(30),
	FOREIGN KEY (SFMid) REFERENCES employee (Eid)
);

CREATE TABLE customer (
    Cid VARCHAR(20) PRIMARY KEY,
    Cname VARCHAR(50),
    Cnic VARCHAR(13),
    Caddress VARCHAR(100),
    Cdob DATE,
	Cemail VARCHAR(30),
    Ctel INT,
    Cusername VARCHAR(30),
    Cpassword VARCHAR(20),
);

CREATE TABLE tblorder (
    Oid VARCHAR(20) PRIMARY KEY,
	Oquantity int,
	Odate date,
	OrderStatus BIT,
	Cno VARCHAR (20),
	FOREIGN KEY (Cno) REFERENCES customer (Cid)
);

CREATE TABLE delivery (
    deliveryNo VARCHAR(20),
    ODeliveryteamID VARCHAR(20),
    ODeliveryStatus VARCHAR(50),
    PRIMARY KEY (deliveryNo, ODeliveryteamID),

    FOREIGN KEY (deliveryNo) REFERENCES deliveryman (Did),
    FOREIGN KEY (ODeliveryteamID) REFERENCES tblorder (Oid)
);

CREATE TABLE item (
    Iid VARCHAR(20) PRIMARY KEY,
	Iname VARCHAR(30),
	IQuantity int,
	Iprice int,
);

CREATE TABLE ingredient (
    Inid VARCHAR(20) PRIMARY KEY,
    InName VARCHAR(200),
    Inquantity int,
);

CREATE TABLE ingredientRequest (
    ReqID VARCHAR(20) PRIMARY KEY,
    Iname VARCHAR(20),
    ReqQuantity INT,
    FOREIGN KEY (Iname) REFERENCES ingredient (Inid)
);

CREATE TABLE specialOrderRequest (
    SORid VARCHAR(20) PRIMARY KEY,
	quantity int,
	ItemNo VARCHAR(20),
	extraItem1 VARCHAR(20),
	extraItem2 VARCHAR(20),
	extraItem3 VARCHAR(20),
	SORdetails VARCHAR(200),
	FOREIGN KEY (ItemNo) REFERENCES item (Iid)
);

CREATE TABLE review (
    Rid VARCHAR(20) PRIMARY KEY,
    RComment VARCHAR(200),
    Rpoint INT,
    Rrate VARCHAR(10),
    Cid VARCHAR(20), 
    FOREIGN KEY (Cid) REFERENCES customer (Cid) 
);

CREATE TABLE supplier (
    supid VARCHAR(20) PRIMARY KEY,
    supName VARCHAR(200),
    supEmail VARCHAR(30),
	supAddress VARCHAR(100),
	supTel VARCHAR(10),
);



CREATE TABLE userRequest (
    URid INT PRIMARY KEY IDENTITY,
    PasswordReset BIT DEFAULT 0,
    requestedUser VARCHAR(30)
);


ALTER TABLE userRequest
ADD newpassword VARCHAR(20);


INSERT INTO employee (Eid, Ename, Enic, Eaddress, Edob, Etel, Eusername, Epassword, OtHours)
VALUES 
    ('a001', 'Admin', 'NIC123456789', 'Admin Address', '2000-01-01', 123456789, 'admin', '1234', 0),
    ('e001', 'Test Employee', 'NIC987654321', 'Test Employee Address', '1995-05-15', 987654321, 'testemp', '1234', 0);

delete from userRequest;
select * from userRequest;
