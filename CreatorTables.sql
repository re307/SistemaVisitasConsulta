create table Encuestas (
	id int identity(1,1) primary key
	,Nombre varchar(max)
	,ApellidoPaterno varchar(max)
	,ApellidoMaterno varchar(max)
	,IsActive bit
	,Encuestadores_Id int
	,AsingEncuestor datetime
	,CreateRow datetime
	,ActiveCount datetime
	,DesactiveCount datetime
	,UpdateCount datetime
	
)
create table Encuestas_Log (
	id int identity(1,1) primary key
	,Encuestas_Id int
	,Nombre varchar(max)
	,ApellidoPaterno varchar(max)
	,ApellidoMaterno varchar(max)
	,IsActive bit
	,Encuestadores_Id int
	,AsingEncuestor datetime
	,ActiveCount datetime
	,DesactiveCount datetime
	,UpdateCount datetime
)