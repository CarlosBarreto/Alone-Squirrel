-- -----------------------------------------------------------------------------------------------
-- Author:      Carlos Barreto
-- Date:        2012.07.27
-- Descripcion: Limpieza y datos de prueba del sistema
-- -----------------------------------------------------------------------------------------------
USE appmigsa;



-- Limpiar datos sys_seqnumber
UPDATE sys_seqnumber SET SeqNo = '00001' WHERE ID = 'Cliente';
-- UPDATE sys_seqnumber SET SeqNo = '00001' WHERE ID = 'Condicion';
-- UPDATE sys_seqnumber SET SeqNo = '00001' WHERE ID = 'Material';
-- UPDATE sys_seqnumber SET SeqNo = '00001' WHERE ID = 'Proceso';
UPDATE sys_seqnumber SET SeqNo = '00001' WHERE ID = 'Requisitor';
UPDATE sys_seqnumber SET SeqNo = '00001' WHERE ID = 'Solicitud';
-- UPDATE sys_seqnumber SET SeqNo = '00001' WHERE ID = 'Tratamiento';

Select * from sys_seqnumber;

-- Limpiar datos de Solicitud
DELETE FROM especificacionsolicitud WHERE NumeroDeEspecificacion <> 100;
DELETE FROM solicitudcotizacion WHERE NumeroSolicitud <> 'SOL99999';

Select * from especificacionsolicitud;
Select * from solicitudcotizacion;

-- Limpiar Condiciones de pago
Select * from condiciones_pago;

-- Limpiar requisitores
DELETE FROM Requisitor WHERE RequisitorID <> 'REQ99999';
Select * from Requisitor;

-- Limpiar datos de Cliente
DELETE FROM Cliente WHERE NumeroDeCliente <> 'CLI00000';
Select * from Cliente;
