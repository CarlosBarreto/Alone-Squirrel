-- -----------------------------------------------------------------------
-- Author:      Carlos Barreto
-- ScriptDate:  2012.03.20
-- Description: Prueba funcional para ingresar un nuevo cliente 
-- -----------------------------------------------------------------------
USE migsa_;

--  Agregar los datos de apoyo
-- Insert into sys_seqnumber (ID, Name, Seqno, Prefix, Description)
-- values ('Cliente', 'Cliente', '00001', 'CLI', 'Client ID');

-- Agregar Cliente
Call migsa_CatalogoCliente_Insertar('Foxconn', 'Camino al ITESO 8900', 'Pinar de la calma', '45180', 'Tlaquepaque', 'Jalisco', '37939100', 'Electronica');

-- Revisar todos los registros
Select * from migsa_catalogocliente;
Select * from sys_seqnumber;
Select * from sys_transactionslog;

-- Limpiar tablas
-- DELETE FROM migsa_catalogocliente WHERE NumeroDeCliente = 'CLI00001' ;
-- DELETE FROM sys_seqnumber WHERE ID = 'Cliente';
-- DELETE FROM sys_transactionslog WHERE TransactionID = 1;
