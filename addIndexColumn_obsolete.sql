ALTER TABLE importexcel.excel 
ADD id INT NOT NULL;
ALTER TABLE importexcel.excel ADD PRIMARY KEY ( id );
ALTER TABLE importexcel.excel MODIFY COLUMN id INT auto_increment;