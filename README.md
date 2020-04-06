# COOASAR PROJECT - Compra y venta

## Comenzando 🚀
Este sistema está basado en las operaciones de Corporación de Servicios Múltiples de la Provincia Sánchez Ramírez (COOASAR). Esta es una empresa dedicada a la venta y compra de productos agropecuarios y ganaderos con sede en Cotuí, Provincia Sánchez Ramírez, República Dominicana.  

Cuenta con Menú con todos los registros:
![Captura2 - Menu de Registros](https://user-images.githubusercontent.com/50345256/78177768-a131cd00-742c-11ea-8717-378dd3b53d2e.PNG)


y un menú con todas las consultas:
![Captura2 - Menu de Consultas](https://user-images.githubusercontent.com/50345256/78177764-a000a000-742c-11ea-8f93-9fef354da4d9.PNG)


En caso de intentar entrar a un registro sin estar loguedo o sin los permiso previos saltará este mensaje:
![Captura - Aleta de Control de Usuarios](https://user-images.githubusercontent.com/50345256/77560520-f8b3c400-6e93-11ea-8571-42bb59b50721.PNG)


## Registros:
En este sistema se implementarion los registros de Usuarios, Productos, Proveedores, Compras, Ventas y Pagos, descristos a contuniación.

### Categorías
![Captura - Registro de Categorias](https://user-images.githubusercontent.com/50345256/78521107-cb6dec80-7796-11ea-9cc4-3473505f0ed2.PNG)

### Usuarios
El registro de Usuarios conHsiste en crear, modificar, eliminar y leer Usuarios. En este sistema se maneja tres tipos de Usuarios, que son Administrador, Cajero y Contador. El Administrador es el tipo de usuario que posee los mayores privilegios, este tiene acceso a todos los registros y consultas que ofrece el sistema. El Contador tiene acceso a todos los registros y consultas, excepto a al Registro de Usuarios. Por último, el cajero tendrá acceso al registro y consulta de Productos, Proveedores y Ventas.

![Captura - Registro de Usuario 2](https://user-images.githubusercontent.com/50345256/78520908-218e6000-7796-11ea-9a7e-a6b75f40a9ff.PNG)

### Productos
El registro de Productos representa la entrada de mercancía a la empresa, aquí se tendrá la libertad de elegir el porciento de ganancia para cada producto.

![Captura - Registro de Productos](https://user-images.githubusercontent.com/50345256/78520902-205d3300-7796-11ea-9721-1fb38617e367.PNG)

### Proveedores
El registro de Proveedores se encarga de Introducir todos aquellos suplidores con los que negocia la empresa.
![Captura - Registro de Proveedores](https://user-images.githubusercontent.com/50345256/78520905-20f5c980-7796-11ea-8a52-d2c5aebb70f2.PNG)
 
### Compras
El registro de Compras representa la adquisición de bienes a la empresa.

![Captura - Registro de Compras (Detalle)](https://user-images.githubusercontent.com/50345256/78520899-1fc49c80-7796-11ea-8a27-16efd26b07c4.PNG)

### Clientes
![Captura - Registro de Clientes 2](https://user-images.githubusercontent.com/50345256/78521346-87c7b280-7797-11ea-9342-b75575b2db88.PNG)

### Ventas
El registro de Ventas representa el despacho de productos por parte de la empresa, este registro, al igual que el Compras, afecta el campo Cantidad de Productos. 

![Captura - Registro de Ventas (Detalle)](https://user-images.githubusercontent.com/50345256/78520910-2226f680-7796-11ea-8953-fb81be812303.PNG)


### Pagos
El registro de Pagos representa la redención de aquellas compras que hayamos hecho previamente, cuando se efectúa un pago, el sistema automáticamente afecta el campo Balance de Compras. 
![Captura - Registro de Pagos (Detalle)](https://user-images.githubusercontent.com/50345256/78520901-205d3300-7796-11ea-9114-a2e0a2f66655.PNG)

## Consultas:
En este apartado el sistema ofrece la facilidad de consultar (dependiendo del nivel de usuario) los registros creados de cada una de las entidades existentes. Asimismo, para la comodidad del usuario todas las consultas paginan, así como tambien se puede filtrar por el campo especificado que el usuario desee. Además de lo anterior, por cada registro hecho, se ofrece la operatividad de ir al formulario de cada registro hecho, esto con el botón "Ver".

### Categorías
![Captura - Consulta de Categorias](https://user-images.githubusercontent.com/50345256/78520911-22bf8d00-7796-11ea-829a-9ec9f7bc5363.PNG)

### Usuarios
En la consulta de Usuarios se verán todos los registros creados de la entidad de Usuarios. 
![Captura - Consulta de Usuarios](https://user-images.githubusercontent.com/50345256/78521259-4d5e1580-7797-11ea-9060-cfaa3e6a24ec.PNG)

### Productos
En la consulta de Productos se verán todos los registros creados de la entidad de Productos. 
![Captura - Consulta de Productos](https://user-images.githubusercontent.com/50345256/78521255-4b945200-7797-11ea-847b-97a54e2e675c.PNG)

### Proveedores
En la consulta de Proveedores se verán todos los registros creados de la entidad de Proveedores. 
![Captura - Consulta de Proveedores](https://user-images.githubusercontent.com/50345256/78521256-4c2ce880-7797-11ea-87c4-f81e843dae5e.PNG)

### Compras
En la consulta de Compras se verán todos los registros creados de la entidad de Compras. 
![Captura - Consulta de Compras](https://user-images.githubusercontent.com/50345256/78574161-9ba30100-77f7-11ea-9f35-01fb91684b79.PNG)

### Clientes
![Captura - Consulta de Clientes](https://user-images.githubusercontent.com/50345256/78574449-048a7900-77f8-11ea-841c-bc1f071dddb6.PNG)

### Ventas
En la consulta de Ventas se verán todos los registros creados de la entidad de Ventas. 
![Captura - Consulta de Ventas](https://user-images.githubusercontent.com/50345256/77363802-bf5f4500-6d29-11ea-9b57-3cbf663cb35e.PNG)

### Pagos
En la consulta de Pagos se verán todos los registros creados de la entidad de Pagos. 
![Captura - Consulta de Pagos](https://user-images.githubusercontent.com/50345256/77363794-be2e1800-6d29-11ea-8af3-9c1291223681.PNG)

## Construido con 🛠️
	Visual Studio - Utilando la herramienta (Blazor App)

	SQLite y SQL Server

 Azure - App Service

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
