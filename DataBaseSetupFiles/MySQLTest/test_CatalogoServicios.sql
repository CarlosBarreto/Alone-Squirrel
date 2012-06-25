-- 2012-06-25 Pruebas alas funciones del catalogo de servicios
-- --------------------------------------------------------------
USE migsa_;

/* SELECT * FROM `migsa_`.`sys_seqnumber`;

  INSERT INTO `migsa_`.`sys_seqnumber`
  (`ID`, `Name`, `Seqno`, `Prefix`, `Description`)
  VALUES ('Servicio', 'Servicio', '00001', 'SRV', 'Servicio ID');
*/

UPDATE `migsa_`.`sys_seqnumber`
SET `Seqno` = '00001' WHERE `ID` = 'Servicio';

-- Agregar servicios
CALL `migsa_CatalogoServicios_Insertar` ('Maquinado', 'Maquinados');
CALL `migsa_CatalogoServicios_Insertar` ('Diseño','Diseño industrial');
CALL `migsa_CatalogoServicios_Insertar` ('Soldadura','Soldadura');
CALL `migsa_CatalogoServicios_Insertar` ('Mantenimiento','Mantenimiento Industrial');

SELECT * FROM migsa_CatalogoServicios;

-- Editar servicios
CALL `migsa_CatalogoServicios_Editar` ('SRV00001','Maquinado','Muchos maquinados');
CALL `migsa_CatalogoServicios_Editar` ('SRV00002','Diseño','Diseño industrial perron');

SELECT * FROM migsa_CatalogoServicios;

-- Eliminar servicios
CALL `migsa_CatalogoServicios_Eliminar` ('SRV00001');
CALL `migsa_CatalogoServicios_Eliminar` ('SRV00002');
CALL `migsa_CatalogoServicios_Eliminar` ('SRV00003');
CALL `migsa_CatalogoServicios_Eliminar` ('SRV00004');

SELECT * FROM migsa_CatalogoServicios;