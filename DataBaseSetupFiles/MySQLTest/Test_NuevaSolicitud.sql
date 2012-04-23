-- -----------------------------------------------------------------------
-- Author:      Carlos Barreto
-- ScriptDate:  2012.03.20
-- Description: Prueba funcional para ingresar un nuevo requisitor 
-- -----------------------------------------------------------------------
USE migsa_;

--  Agregar los datos de apoyo
Insert into sys_seqnumber (ID, Name, Seqno, Prefix, Description)
values ('Cliente', 'Cliente', '00001', 'CLI', 'Client ID');
Insert into sys_seqnumber (ID, Name, Seqno, Prefix, Description)
values ('Requisitor', 'Requisitor', '00001', 'REQ', 'Requisitor ID');

-- Agregar Clientes
Call migsa_CatalogoCliente_Insertar('Foxconn', 'Camino al ITESO 8900', 'Pinar de la calma', '45180', 'Tlaquepaque', 'Jalisco', '37939100', 'Electronica');
Call migsa_CatalogoCliente_Insertar('ECMM', 'Camino al ITESO 8900', 'Pinar de la calma', '45180', 'Tlaquepaque', 'Jalisco', '37939100', 'Electronica');

-- Agregar Requisitores
Call migsa_Requisitor_Insertar ('CLI00001', 'Carlos Barreto', '37939100', '6138', '3333629696', '**', 'carlos.barreto@live.com.mx');
Call migsa_Requisitor_Insertar ('CLI00001', 'Elizabeth Aldana', '37939100', '6125', '**', '**', 'elizabeth.aldana@live.com.mx') ;
Call migsa_Requisitor_Insertar ('CLI00002', 'Elizabeth Aldana', '37939100', '6125', '**', '**', 'elizabeth.aldana@live.com.mx') ;

-- Revisar todos los registros
Select * from migsa_catalogocliente;
Select * from migsa_requisitor;
Select * from sys_seqnumber;
Select * from sys_transactionslog;

-- Limpiar tablas
DELETE FROM migsa_requisitor WHERE id_requisitor = 'REQ00001';
DELETE FROM migsa_requisitor WHERE id_requisitor = 'REQ00002';
DELETE FROM migsa_requisitor WHERE id_requisitor = 'REQ00003';

DELETE FROM migsa_catalogocliente WHERE NumeroDeCliente = 'CLI00001' ;
DELETE FROM migsa_catalogocliente WHERE NumeroDeCliente = 'CLI00002' ;

DELETE FROM sys_seqnumber WHERE ID = 'Cliente';
DELETE FROM sys_seqnumber WHERE ID = 'Requisitor';
DELETE FROM sys_transactionslog WHERE TransactionID > 1;