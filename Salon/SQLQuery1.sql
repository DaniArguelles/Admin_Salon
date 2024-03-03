select * from Usuarios

select @@SERVERNAME

drop table Usuarios

create table Usuarios(
id_usuario int identity,
usuario varchar(50),
contra  varchar(50)
constraint pk_id primary key (id_usuario)
)

insert into Usuarios values ('daniel','reyes')

alter table usuarios
add rol varchar(50)

update Usuarios
set rol= 'empleado'
where id_usuario = 2

