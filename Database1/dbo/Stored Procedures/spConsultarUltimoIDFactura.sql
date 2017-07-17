CREATE proc spConsultarUltimoIDFactura
as
begin
  SELECT IDENT_CURRENT('Factura')
end