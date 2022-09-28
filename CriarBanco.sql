create database Banco
use Banco
drop table cadastrar
create table cadastrar(
idCadastro int identity(1,1) not null,
Nome varchar(50)  null,
Cpf char(15) not null,
Sexo varchar(12) null,
Telefone char(14) not null,
Celular char(16) not null,
Senha char(4) not null,
numeroConta char (4) not null,
saldoConta int null,
constraint pk_Id primary key(idCadastro),
constraint uq_cpf_ unique (Cpf)
)
set identity_insert dbo.cadastrar off
select * from cadastrar

insert into cadastrar(saldoConta) values (100)
