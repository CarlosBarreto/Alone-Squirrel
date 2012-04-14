-- -----------------------------------------------------------------------
-- Author:      Carlos Barreto
-- ScriptDate:  2012.04.14
-- Description: Datos de prueba para el catalogo de condiciones de pago
-- -----------------------------------------------------------------------
USE migsa_;

INSERT INTO `migsa_`.`migsa_catalogocondicionespago`
(`ID`, `Nombre`, `Anticipo`, `Resto`)
VALUES
(0,'50% Anticipo',50,50);

INSERT INTO `migsa_`.`migsa_catalogocondicionespago`
(`ID`, `Nombre`, `Anticipo`, `Resto`)
VALUES
(0,'100% Anticipo',100,0);

INSERT INTO `migsa_`.`migsa_catalogocondicionespago`
(`ID`, `Nombre`, `Anticipo`, `Resto`)
VALUES
(0,'100% Contra Entrega',0,100);

Select Nombre, Anticipo, Resto From `migsa_`.`migsa_catalogocondicionespago`