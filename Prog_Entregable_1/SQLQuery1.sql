use Entregable_Prog2
create table Articulos(
id_articulo int identity(1,1),
nombre varchar (40),
precio_unitario float 
constraint PK_ARTICULOS primary key(id_articulo) 

)


create table Formas_pago(
id_forma int identity ,
nombre varchar(40),
constraint PK_FORMAS_PAGO primary key (id_forma) 
)

create table Facturas(
id_factura int identity ,
fecha datetime,
id_forma_pago int ,
cliente varchar(40)
constraint PK_FACTURA primary key(id_factura)
constraint FK_FACTURA_FORMA_PAGO foreign key (id_forma_pago) references Formas_pago(id_forma),
)
create table Detalles_Factura(
id_detalle int identity,
id_articulo int,
id_factura int ,
cantidad int 
constraint PK_DETALLES primary key (id_detalle)
constraint FK_DETALLES_ARTICULO foreign key (id_articulo)references Articulos(id_articulo),
constraint FK_DETALLLE_FACTURA foreign key (id_factura) references Facturas(id_factura)
)




GO
-- Crear el procedimiento almacenado
CREATE PROCEDURE SP_INSERTAR_FACTURA
    @FECHA datetime,
    @ID_FORMA_PAGO int,
    @ID_FACTURA int OUTPUT
AS
BEGIN
    -- Insertar los datos en la tabla Facturas
    INSERT INTO Facturas (fecha, id_forma_pago)
    VALUES (@FECHA, @ID_FORMA_PAGO)

    -- Obtener el ID de la factura recién insertada
    SET @ID_FACTURA = SCOPE_IDENTITY()
END
go




ALTER TABLE Detalles_Factura
DROP CONSTRAINT PK_DETALLES;

-- Luego, quita la propiedad identity de la columna id_detalle
-- Esto se hace cambiando el tipo de datos de la columna a uno que no sea identity
ALTER TABLE Detalles_Factura
ALTER COLUMN id_detalle int  ;

-- A continuación, vuelve a agregar la clave primaria sin la propiedad identity
ALTER TABLE Detalles_Factura
ADD CONSTRAINT PK_DETALLES PRIMARY KEY (id_detalle);

