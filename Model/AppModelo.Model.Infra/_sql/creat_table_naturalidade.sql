	CREATE TABLE naturalidade (
	id int NOT NULL AUTO_INCREMENT, 
	descricao VARCHAR(100) NOT NULL,
	dataCriacao datetime NOT NULL, 
	dataAlteracao datetime NOT NULL,
	ativo boolean NOT NULL,
	CONSTRAINT pk_naturalidade_id PRIMARY KEY (id))
	

