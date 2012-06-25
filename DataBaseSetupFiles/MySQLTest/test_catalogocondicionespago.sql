-- 2012-06-25 Pruebas a las funciones del catalogo de condiciones de pago
-- --------------------------------------------------------------

USE migsa_;


-- Agregar una nueva condicion de pago
CALL `migsa_catalogocondicionespago_Insertar` ('Anticipo 75%', 75, 25);
CALL `migsa_catalogocondicionespago_Insertar` ('Anticipo 25%', 25, 75);

Select * from migsa_catalogocondicionespago;

-- Editar una condicion de pago
CALL `migsa_catalogocondicionespago_Editar` (10, 'Anticipo 70%', 70, 30);
CALL `migsa_catalogocondicionespago_Editar` (11, 'Anticipo 30%', 30, 70);

Select * from migsa_catalogocondicionespago;

-- Borrar condiciones de pago
CALL migsa_catalogocondicionespago_Eliminar (10);
CALL migsa_catalogocondicionespago_Eliminar (11);

Select * from migsa_catalogocondicionespago;
