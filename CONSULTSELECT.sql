-- Para recuperar una factura y todos los productos que posee:
SELECT cf.numero, p.nombre, df.cantidad, df.precio, df.total
FROM cabecera_factura cf
JOIN detalle_factura df ON cf.numero = df.numero_factura
JOIN producto p ON df.codigo_producto = p.codigo;

-- Para recuperar todas las facturas y el nombre de los clientes:
SELECT cf.numero, cl.primer_nombre, cl.primer_apellido
FROM cabecera_factura cf
JOIN cliente cl ON cf.codigo_cliente = cl.codigo;