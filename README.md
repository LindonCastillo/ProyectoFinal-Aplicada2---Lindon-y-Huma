# COOASAR PROJECT - Compra y venta

## Comenzando 🚀
Este sistema está basado en las operaciones de Corporación de Servicios Múltiples de la Provincia Sánchez Ramírez (COOASAR). Esta es una empresa dedicada a la venta y compra de productos agropecuarios y ganaderos con sede en Cotuí, Provincia Sánchez Ramírez, República Dominicana.  

Cuenta con Menú con todos los registros:
![Captura - Menu de Registros](https://user-images.githubusercontent.com/50345256/77560086-572c7280-6e93-11ea-82d0-4f6bc7035c66.PNG)

y un menú con todas las consultas:
![Captura - Menu de Consultas](https://user-images.githubusercontent.com/50345256/77573693-6d442e00-6ea7-11ea-9615-b3cd0c5bd617.PNG)


En caso de intentar entrar a un registro sin estar loguedo o sin los permiso previos saltara este mensaje:
![Captura - Aleta de Control de Usuarios](https://user-images.githubusercontent.com/50345256/77560520-f8b3c400-6e93-11ea-8571-42bb59b50721.PNG)


## Registros:
En este sistema se implementarion los registros de Usuarios, Productos, Proveedores, Compras, Ventas y Pagos, descristos a contuniación. 
### Usuarios
El registro de Usuarios conHsiste en crear, modificar, eliminar y leer Usuarios. En este sistema se maneja tres tipos de Usuarios, que son Administrador, Cajero y Contador. El Administrador es el tipo de usuario que posee los mayores privilegios, este tiene acceso a todos los registros y consultas que ofrece el sistema. El Contador tiene acceso a todos los registros y consultas, excepto a al Registro de Usuarios. Por último, el cajero tendrá acceso al registro y consulta de Productos, Proveedores y Ventas.

![Captura - Registro de Usuario 2](https://user-images.githubusercontent.com/50345256/77574084-f6f3fb80-6ea7-11ea-9ebc-973403d58aa6.PNG)

### Productos
El registro de Productos representa la entrada de mercancía a la empresa, aquí se tendrá la libertad de elegir el porciento de ganancia para cada producto.

![Captura - Registro de Productos](https://user-images.githubusercontent.com/50345256/77363694-8d4de300-6d29-11ea-93cd-bcabc941b044.PNG)

### Proveedores
El registro de Proveedores se encarga de Introducir todos aquellos suplidores con los que negocia la empresa.
![Captura - Registro de Proveedores](https://user-images.githubusercontent.com/50345256/77363695-8d4de300-6d29-11ea-91b5-d561eddd467b.PNG)
 
### Compras
El registro de Compras representa la adquisición de bienes a la empresa.
![Captura - Registro de Compras (Detalle)](https://user-images.githubusercontent.com/50345256/77363775-b40c1980-6d29-11ea-8998-9d03e6c32204.PNG)

### Ventas
El registro de Ventas representa el despacho de productos por parte de la empresa, este registro, al igual que el Compras, afecta el campo Cantidad de Productos. 

![Captura - Registro de Ventas (Detalle)](https://user-images.githubusercontent.com/50345256/77363782-b7070a00-6d29-11ea-861d-f139618f652b.PNG)

### Pagos
El registro de Pagos representa la redención de aquellas compras que hayamos hecho previamente, cuando se efectúa un pago, el sistema automáticamente afecta el campo Balance de Compras. 
![Captura - Registro de Pagos (Detalle)](https://user-images.githubusercontent.com/50345256/77363692-8c1cb600-6d29-11ea-8a90-202ae720e849.PNG)

## Consultas:
En este apartado el sistema ofrece la facilidad de consultar (dependiendo del nivel de usuario) los registros creados de cada una de las entidades existentes. Asimismo, para la comodidad del usuario todas las consultas paginan, así como tambien se puede filtrar por el campo especificado que el usuario desee. Además de lo anterior, por cada registro hecho, se ofrece la operatividad de ir al formulario de cada registro hecho, esto con el botón "Ver".
### Usuarios
En la consulta de Usuarios se verán todos los registros creados de la entidad de Usuarios. 
![Captura - Consulta de Usuarios](https://user-images.githubusercontent.com/50345256/77363801-bec6ae80-6d29-11ea-8800-3fc7d4a4df27.PNG)

### Productos
En la consulta de Productos se verán todos los registros creados de la entidad de Productos. 
![Captura - Consulta de Productos](https://user-images.githubusercontent.com/50345256/77363796-be2e1800-6d29-11ea-928b-e1e61caa0295.PNG)
### Proveedores
En la consulta de Proveedores se verán todos los registros creados de la entidad de Proveedores. 
![Captura - Consulta de Proveedores](https://user-images.githubusercontent.com/50345256/77363800-bec6ae80-6d29-11ea-8ef9-b6da040e198e.PNG)

### Compras
En la consulta de Compras se verán todos los registros creados de la entidad de Compras. 
![Captura - Consulta de Compras](https://user-images.githubusercontent.com/50345256/77363793-bd958180-6d29-11ea-813c-324cc6fbe359.PNG)

### Ventas
En la consulta de Ventas se verán todos los registros creados de la entidad de Ventas. 
![Captura - Consulta de Ventas](https://user-images.githubusercontent.com/50345256/77363802-bf5f4500-6d29-11ea-9b57-3cbf663cb35e.PNG)

### Pagos
En la consulta de Pagos se verán todos los registros creados de la entidad de Pagos. 
![Captura - Consulta de Pagos](https://user-images.githubusercontent.com/50345256/77363794-be2e1800-6d29-11ea-8af3-9c1291223681.PNG)

## Construido con 🛠️
	Visual Studio - Utilando la herramienta (Blazor App)

	SQLite

	Google Chrome

## Autores ✒️
 Ezequiel Huma Brito 

 Lindon Emil Castillo Burgos


## Licencia 📄
Este proyecto está bajo la Licencia de Ezequiel Huma Brito y Lindon Emil Castillo Burgos.

En caso de plagio o el uso del mismo para fines lucrativos de su persona, le avisamos de antemano que se tomaran acciones
legales en su contra.  

## Expresiones de Gratitud 🎁
Agradecemos a todos las personas que nos brindaron su apoyo durante la realización de este proyecto.
