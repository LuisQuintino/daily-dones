create table Usuario (
	Codigo CHAR(38) PRIMARY KEY,
    Email VARCHAR(50) UNIQUE NOT NULL,
    Senha VARCHAR(9999) NOT NULL
);

create table Tarefa (
	Codigo CHAR(38) PRIMARY KEY,
    Descricao VARCHAR(200) NOT NULL,
    DtInclusao DATETIME NOT NULL,
    Situacao INT NOT NULL,
    DtSituacao DATETIME NULL,
    CodigoUsuario CHAR(38) NOT NULL,
    FOREIGN KEY (CodigoUsuario) REFERENCES Usuario(Codigo)
);

create table tag(
	Codigo CHAR(38) PRIMARY KEY,
    Descricao VARCHAR(100) NOT NULL,
    IdentificadorCorHex VARCHAR(500),
    CodigoUsuario CHAR(38) NOT NULL,
    FOREIGN KEY (CodigoUsuario) REFERENCES Usuario(Codigo)
);

create table TagTarefa(
    CodigoTag CHAR(38) NOT NULL,
    CodigoTarefa CHAR(38) NOT NULL,
    PRIMARY KEY (CodigoTag, CodigoTarefa),
    FOREIGN KEY (CodigoTarefa) REFERENCES Tarefa(Codigo),
    FOREIGN KEY (CodigoTag) REFERENCES Tag(Codigo)
);