BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "Books" (
	"Id"	INTEGER NOT NULL,
	"Barcod"	bigint NOT NULL,
	"Name"	nvarchar(50) NOT NULL,
	"Author"	nvarchar(50) NOT NULL,
	"RCount"	INTEGER DEFAULT 0,
	"Statu"	INTEGER DEFAULT 0,
	PRIMARY KEY("Id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Branchs" (
	"Id"	INTEGER NOT NULL,
	"Name"	nvarchar(50),
	PRIMARY KEY("Id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Users" (
	"Id"	INTEGER NOT NULL,
	"Name"	nvarchar(50) NOT NULL,
	"ReadBooks"	TEXT,
	"BranchId"	INTEGER NOT NULL,
	PRIMARY KEY("Id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Assigments" (
	"Id"	INTEGER NOT NULL,
	"UserId"	INTEGER NOT NULL,
	"AssignDate"	INTEGER NOT NULL DEFAULT 0,
	"ReturnDate"	INTEGER DEFAULT 0,
	"DealedDate"	INTEGER NOT NULL DEFAULT 0,
	"Notes"	TEXT,
	"Barcod"	bigint,
	"Statu"	INTEGER NOT NULL DEFAULT 0,
	PRIMARY KEY("Id" AUTOINCREMENT)
);
INSERT INTO "Books" VALUES (1,23123123,'test','test',2,0);
INSERT INTO "Branchs" VALUES (1,'test');
INSERT INTO "Users" VALUES (1,'tetst',NULL,1);
INSERT INTO "Assigments" VALUES (1,1,1595189752,1595189759,1595189749,'adasd',23123123,0);
COMMIT;