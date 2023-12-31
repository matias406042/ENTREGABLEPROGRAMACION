USE [Entregable_Prog2]
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_DETALLE]    Script Date: 7/9/2023 01:39:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[SP_INSERTAR_DETALLE]
    @FACTURA_NRO int,   
    @ID_ARTICULO int,
    @CANTIDAD int
AS
BEGIN
    -- Insertar los datos en la tabla DetallesFactura (o el nombre de tu tabla)
    INSERT INTO Detalles_Factura(id_factura, id_articulo, cantidad)
    VALUES (@FACTURA_NRO,  @ID_ARTICULO, @CANTIDAD)
END