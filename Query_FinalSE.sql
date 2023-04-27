
use FinalProjectDB
drop table Login_Management
go

CREATE TABLE Login_Management (
    username varchar(20) primary key,
    password varchar(20),
    role varchar(10),
);



CREATE TABLE Good_Receiver (
		dateCreated date,
		receiptNo int primary key,
		DeliverName varchar(50),
		ExportReceiptNo int,
		ExportDMY date,
		ExportCompanyName varchar(50),
		exportFactory varchar(50),
		FactoryLocation varchar(50)
);

CREATE TABLE Good_Delivery_Note (
		dateCreated date,
		exportReceiptNo int primary key,
		ReceiverName varchar(50),
		issuingReason varchar(50),
		exportFactory varchar(50),
		FactoryLocation varchar(50)
);

CREATE TABLE Product (
		PID varchar(20) primary key,
		PName varchar(50),
		PMemory varchar(10),
		PColor varchar(20),
		PQuantity int
);



go

INSERT INTO Login_Management (username, password, role)
					  VALUES ('admin', 'admin', 'admin'),
							 ('agent', 'agent', 'agent');


go

INSERT INTO Product (PID, PName, PMemory, PColor, PQuantity)
VALUES
('IPXS64R', 'iPhone XS', '64 GB', 'Red', 867),
('IPXS64B', 'iPhone XS', '64 GB', 'Blue', 167),
('IPXS64GN', 'iPhone XS', '64 GB', 'Green', 0),
('IPXS64Y', 'iPhone XS', '64 GB', 'Yellow', 44),
('IPXS64P', 'iPhone XS', '64 GB', 'Purple', 413),
('IPXS64GY', 'iPhone XS', '64 GB', 'Grey', 329),
('GS20U128B', 'Galaxy S20 Ultra', '128 GB', 'Black', 573),
('GS20U128W', 'Galaxy S20 Ultra', '128 GB', 'White', 3),
('GS20U128S', 'Galaxy S20 Ultra', '128 GB', 'Silver', 302),
('HP30P128W', 'Huawei P30 Pro', '128 GB', 'White', 746),
('MMG2032B', 'Motorola Moto G20', '32 GB', 'Blue', 915),
('N10256B', 'Nokia 10', '256 GB', 'Black', 257),
('GP3A64P', 'Google Pixel 3a', '64 GB', 'Pink', 494),
('XPX3P128G', 'Xiaomi Poco X3 Pro', '128 GB', 'Gold', 628),
('RN9128G', 'Redmi Note 9', '128 GB', 'Gray', 776),
('OP8T256G', 'OnePlus 8T', '256 GB', 'Green', 310),
('SGM51128W', 'Samsung Galaxy M51', '128 GB', 'White', 987),
('IP11128R', 'iPhone 11', '128 GB', 'Red', 582),
('GP45G128B', 'Google Pixel 4a 5G', '128 GB', 'Black', 936),
('HP40P256S', 'Huawei P40 Pro', '256 GB', 'Silver', 654),
('N632PK', 'Nokia 6', '32 GB', 'Pink', 222),
('N632Y', 'Nokia 6', '32 GB', 'Yellow', 0),
('N632P', 'Nokia 6', '32 GB', 'Purple', 0),
('N664PK', 'Nokia 6', '64 GB', 'Pink', 0),
('N664Y', 'Nokia 6', '64 GB', 'Yellow', 12),
('GS20FE128G', 'Galaxy S20 FE', '128 GB', 'Green', 864),
('XRN10P64B', 'Xiaomi Redmi Note 10 Pro', '64 GB', 'Blue', 432),
('OP8T256B', 'OnePlus 8T', '256 GB', 'Blue', 779),
('IP12PM512G', 'iPhone 12 Pro Max', '512 GB', 'Gray', 239),
('MME7P64D', 'Motorola Moto E7 Plus', '64 GB', 'Denim', 512),
('GP4XL64W', 'Google Pixel 4 XL', '64 GB', 'White', 387);