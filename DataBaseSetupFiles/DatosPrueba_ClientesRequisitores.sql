-- -----------------------------------------------------------------------
-- Author:      Carlos Barreto
-- ScriptDate:  2012.04.11
-- Description: Pruebas funcionales para el SP Nueva Solicitud y Especificaciones Solicitud
-- -----------------------------------------------------------------------
USE migsa_;

--  Agregar los datos de apoyo
Insert into sys_seqnumber (ID, Name, Seqno, Prefix, Description)
values ('Cliente', 'Cliente', '00001', 'CLI', 'Client ID');
Insert into sys_seqnumber (ID, Name, Seqno, Prefix, Description)
values ('Requisitor', 'Requisitor', '00001', 'REQ', 'Requisitor ID');
Insert into sys_seqnumber (ID, Name, Seqno, Prefix, Description)
values ('SolCot', 'SolCot', '00001', 'SOL', 'SolicitudCotizacion');


-- Agregar Cliente
Call migsa_CatalogoCliente_Insertar('Henniges Automotive','Calle 1 # 1000', 'Col Industrial', '45180', 'Guadalajara', 'Jalisco', 'N/A', 'N/A');
Call migsa_CatalogoCliente_Insertar('Industrias Gutierrez  S.A. de C.V.','Calle 2 # 2000', 'Col Industrial', '45180', 'Guadalajara', 'Jalisco', 'N/A', 'N/A');
Call migsa_CatalogoCliente_Insertar('Effem Mexico Inc. N.C. de C.V.','Calle 3 # 3000', 'Col Industrial', '45180', 'Guadalajara', 'Jalisco', 'N/A', 'N/A');
Call migsa_CatalogoCliente_Insertar('Baldor Electric S.A. de C.V.','Calle 4 # 4000', 'Col Industrial', '45180', 'Guadalajara', 'Jalisco', 'N/A', 'N/A');
Call migsa_CatalogoCliente_Insertar('Grupo Enertec S.A de C.V.','Calle 5 # 5000', 'Col Industrial', '45180', 'Guadalajara', 'Jalisco', 'N/A', 'N/A');

-- Agregar Requisitores
Call migsa_Requisitor_Insertar ('CLI00001', 'Juan Perez', '37939100', '001', '3333629601', '**', 'correo1@live.com.mx');
Call migsa_Requisitor_Insertar ('CLI00001', 'Perengano Martinez', '37939100', '002', '3333629602', '**', 'corre2@live.com.mx');
Call migsa_Requisitor_Insertar ('CLI00002', 'Jose del Toro', '37939200', '001', '3333629603', '**', 'correo3@live.com.mx');
Call migsa_Requisitor_Insertar ('CLI00003', 'Maria Lopez', '37939300', '001', '3333629604', '**', 'correo4@live.com.mx');
Call migsa_Requisitor_Insertar ('CLI00004', 'Arnulfo de la Cruz', '37939400', '001', '3333629605', '**', 'correo5@live.com.mx');
Call migsa_Requisitor_Insertar ('CLI00004', 'Ermenegildo Lindo', '37939400', '002', '3333629606', '**', 'correo6@live.com.mx');
Call migsa_Requisitor_Insertar ('CLI00005', 'Juan de la Madrid', '37939500', '003', '3333629607', '**', 'correo7@live.com.mx');


-- Agregar Condiciones de pago 
INSERT INTO `migsa_`.`migsa_catalogocondicionespago` (`ID`, `Nombre`, `Anticipo`, `Resto`) VALUES (0, 'Anticipo 50%',50,50);
INSERT INTO `migsa_`.`migsa_catalogocondicionespago` (`ID`, `Nombre`, `Anticipo`, `Resto`) VALUES (0, 'Anticipo 100%',100,0);
INSERT INTO `migsa_`.`migsa_catalogocondicionespago` (`ID`, `Nombre`, `Anticipo`, `Resto`) VALUES (0, '100% a Contra Entrega',0,100);

-- Limpiar tablas
/*
USE migsa_;
DELETE FROM migsa_especificacionsolicitudcotizacion WHERE NumeroDeEspecificacion > 0;
DELETE FROM migsa_solicitudcotizacion WHERE NumeroSolicitud = 'SOL00001';
DELETE FROM migsa_solicitudcotizacion WHERE NumeroSolicitud = 'SOL00002';
DELETE FROM migsa_solicitudcotizacion WHERE NumeroSolicitud = 'SOL00003';

DELETE FROM migsa_requisitor WHERE id_requisitor = 'REQ00001';
DELETE FROM migsa_requisitor WHERE id_requisitor = 'REQ00002';
DELETE FROM migsa_requisitor WHERE id_requisitor = 'REQ00003';

DELETE FROM migsa_catalogocliente WHERE NumeroDeCliente = 'CLI00001' ;
DELETE FROM migsa_catalogocliente WHERE NumeroDeCliente = 'CLI00002' ;

DELETE FROM sys_seqnumber WHERE ID = 'Cliente';
DELETE FROM sys_seqnumber WHERE ID = 'Requisitor';
DELETE FROM sys_seqnumber WHERE ID = 'SolCot';
DELETE FROM sys_transactionslog WHERE TransactionID > 1;
*/