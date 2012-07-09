-- 2012-07-06 -- pruabas funcionales para el grupo NuevaCotizacion
-- ----------------------------------
USE migsa_;

-- Agregar el registro para obtener el numero de cotización
 -- -- -- USAR SOLO UNA VEZ -- --- -- 
 
 INSERT INTO `migsa_`.`sys_seqnumber`
(`ID`, `Name`, `Seqno`, `Prefix`, `Description`)
VALUES ('Cotizacion', 'Cotizacion', '00001', 'COT', 'Cotización');

-- ----------------------------------------------------------------
-- Probar el modulo para agregar una nueva cotizacion

CALL `migsa_Cotizacion_Insertar` ('CLI00001', 'REQ0001','Engranes','Efectivo','45Dias','Av Las Fuentes #1321');

-- Probar el modulo para especificaciones de cotizacion
CALL `migsa_EspecificacionCotizacion_Insertar` ('COT00001','Engrane 10','Engrane 10x10 20 pines','Acero','Torno','Pulir','10','120','1200');
CALL `migsa_EspecificacionCotizacion_Insertar` ('COT00001','Engrane 20','Engrane 20x20 40 pines','Acero','Torno','Pulir','10','160','1600');

/*
`migsa_Cotizacion_Insertar`
( IN `_NumeroDeCliente` VARCHAR(10),
  IN `_idRequisitor` INT,
  IN `_Servicio` VARCHAR(45),
  IN `_FormaPago` VARCHAR(45),
  IN `_TiempoEntrega` VARCHAR(45),
  IN `_DomicilioEntrega` VARCHAR(45)
*/

/*
`migsa_EspecificacionCotizacion_Insertar`
( IN `_NumeroCotizacion` VARCHAR(10),
  IN `_Nombre` VARCHAR(45),
  IN `_Descripcion` VARCHAR(45),
  IN `_Material` VARCHAR(45),
  IN `_Proceso` VARCHAR(45),
  IN `_Tratamiento` VARCHAR(45),
  IN `_Cantidad` INT,
  IN `_PrecioUnitario` INT,
  IN `_SubTotal` INT
  */