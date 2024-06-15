CREATE TABLE event (
    Eid INT IDENTITY(1,1) PRIMARY KEY,
    Ename VARCHAR(100) NOT NULL,
    EstartDate DATE NOT NULL,
    EendDate DATE,
    EstartTime TIME NOT NULL,
    EendTime TIME,
    Edescription TEXT,
    Eorganizer VARCHAR(100),
    Etype INT,
    Estatus INT DEFAULT 0
);

