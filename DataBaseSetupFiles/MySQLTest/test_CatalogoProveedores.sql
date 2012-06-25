-- 2012-06-15 Pruebas alas funciones del catalogo de proovedores
-- --------------------------------------------------------------
USE migsa_;

-- SELECT * FROM `migsa_`.`sys_seqnumber`;

-- INSERT INTO `migsa_`.`sys_seqnumber`
-- (`ID`, `Name`, `Seqno`, `Prefix`, `Description`)
-- VALUES ('Proveedor', 'Proveedor', '00001', 'PRV', 'Proveedor ID');

UPDATE `migsa_`.`sys_seqnumber`
SET `Seqno` = '00001' WHERE `ID` = 'Proveedor';

-- Agregar a los proveedores
CALL `migsa_CatalogoProveedor_Insertar`
('Foxconn', 'Av empresarios', 'Puerta de hierro', '45000', 'Zapopan', 'Jalisco', '80000600', 'ECMS5454654',
'Carlos Barreto', 'IT Developer', 'carlos.barreto@live.com.mx');

CALL `migsa_CatalogoProveedor_Insertar`
('ECMM Solution', 'Camino al ITESO 8900', 'La calma', '45080', 'Tlaquepaque', 'Jalisco', '37939100', 'ECMS5454654',
'Carlos Barreto', 'IT Developer', 'carlos.barreto@live.com.mx');

SELECT * from migsa_catalogoproveedores;

-- Modificar proveedores
CALL `migsa_CatalogoProveedor_Editar`
('PRV00002', 'ECMM Solution', 'Camino al ITESO 8900', 'La calma', '45080', 'Tlaquepaque', 'Jalisco', '37939100', 'ECMS5454654',
'Elizabeth Adana', 'IT Developer', 'carlos.barreto@live.com.mx');

SELECT * from migsa_catalogoproveedores;

-- Elimnar proveedores
CALL `migsa_CatalogoProveedor_Eliminar` ('PRV00001');
CALL `migsa_CatalogoProveedor_Eliminar` ('PRV00002');

SELECT * from migsa_catalogoproveedores;