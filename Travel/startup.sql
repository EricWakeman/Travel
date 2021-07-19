CREATE TABLE trips(  
    id int NOT NULL primary key AUTO_INCREMENT comment 'primary key',
    createAt DATETIME COMMENT 'create time',
    updateAt DATETIME COMMENT 'update time',
    descript varchar(255) comment 'Trip Description',
    flightTime varchar(255) comment 'Total flight time',
    price DECIMAL COMMENT 'Cost of Trip'
) default charset utf8 comment '';
CREATE TABLE cruises(  
    id int NOT NULL primary key AUTO_INCREMENT comment 'primary key',
    createAt DATETIME COMMENT 'create time',
    updateAt DATETIME COMMENT 'update time',
    descript varchar(255) comment 'Trip Description',
    shipSize varchar(255) comment 'Class of Cruise Ship',
    price DECIMAL COMMENT 'Cost of Cruise'
) default charset utf8 comment '';