create table Usuarios(
UsuarioId int identity(1,1) primary key,
Nombre varchar(50),
Clave varchar(50)
);

create table Categorias(
CategoriaId int identity(1,1) primary key,
Descripcion varchar(50)
);

create table Peliculas(
PeliculaId int identity(1,1) primary key,
Estreno date,
Descripcion varchar(50),
CategoriaId int
);