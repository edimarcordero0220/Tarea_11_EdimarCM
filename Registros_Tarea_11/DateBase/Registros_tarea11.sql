use Re

create table Usuarios(
UsuarioId int identity (1,1) primary key,
Nombre varchar(20),
Clave varchar(20)
);

create table Peliculas(
IdPelicula int identity (1,1) primary key,
Estreno datetime,
Descripcion varchar(20),
CategoriId int
);

create table Categorias(
CategoriaId int identity (1,1) primary key,
Descripcion varchar(20),

);