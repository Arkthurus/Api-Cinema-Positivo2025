-- Tabela Ator (corrigida de 'Rtor')
CREATE TABLE Ator(
    id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    nome VARCHAR(28) NOT NULL,  -- Corrigido de 'none'
    dataNasc DATE NOT NULL       -- Corrigido de 'database'
);

-- Tabela Director
CREATE TABLE Director(
    id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    nome VARCHAR(28) NOT NULL,
    dataNasc DATE NOT NULL,
    biografia VARCHAR(150) NOT NULL
);

-- Tabela Avaliacao (corrigida de 'Availableaso')
CREATE TABLE Avaliacao(
    id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,  -- Adicionado PK
    autor VARCHAR(28),
    estrelas DECIMAL,
    resenha VARCHAR(150)
);

-- Tabela Filme (com FKs corretas)
CREATE TABLE Filme(
    id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    titulo VARCHAR(35) NOT NULL,
    anoLancamento INT UNSIGNED NOT NULL,  -- Corrigido de 'anolanoanento'
    genero VARCHAR(28),
    sinopse VARCHAR(128) NOT NULL,
    posterURL VARCHAR(129) NOT NULL,      -- Corrigido de 'posterURLs'
    notaIMDB DECIMAL NOT NULL,            -- Corrigido de 'notalIND'
    idDirector INTEGER NOT NULL,
    idAvaliacao INTEGER NOT NULL,
    FOREIGN KEY (idDirector) REFERENCES Director(id),
    FOREIGN KEY (idAvaliacao) REFERENCES Avaliacao(id)
);
CREATE TABLE Filme_Ator (
    filme_id INTEGER NOT NULL,
    ator_id INTEGER NOT NULL,
    papel VARCHAR(50),  -- Exemplo: papel do ator no filme (opcional)
    PRIMARY KEY (filme_id, ator_id),
    FOREIGN KEY (filme_id) REFERENCES Filme(id),
    FOREIGN KEY (ator_id) REFERENCES Ator(id)
);