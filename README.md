# Backend-tarjeta_Credito
Pasos para el deploy en azure.

#1. 
- Click derecho sobre la solución y presionamos publish.
- Luego nos logueamos en azure, y presionamos para que publique en Azure.
- Seleccionar Azure App Services (Windows), si tiene linux, escoja su SO.
- Le damos en crear una nueva instancia o servicio de App Service
- Ponemos el nombre que queramos y le damos create.
- skipeamos el siguiente paso de la API y presionamos finish.

#2. 
- Luego nos muestra una ventana con la url del sitio, la configuración general.
- Bajamos a los servicios de dependencias, en Sql server databases presionamos los 3 punticos y le damos connect.
- Seleccionamos Azure SQL Database.
- Le damos en create new.
- Ponemos el nombre que queramos y en Database server presionamos en new.
- Creamos el servidor, le ponemos el nombre que queramos, creamos un usuario y presionamos create.
- Luego nos sale una ventana con la base de datos creada, le damos next.
- En la otra ventana escogemos la base de datos que creamos, ponemos el usuario y la contraseña del servidor que creamos también.
- Presionamos Next y Finish.

#3.
- Se nos abre de nuevo la ventana principal, presionamos more options y le damos click en edit.
- Se abre una nueva ventana, nos vamos a settings y esperamos que cargue la DB.
- presionamos database y seleccionamos el checkbox.
- luego seleccionamos EF Migrations y seleccionamos el checkbox.
- y por último en file publish Options seleccionamos el checkbox.
- Le damos save, nos vuelve a la ventana principal y presionamos publish.
- Abrimos el link, y en la url le agregamos "/api/[controllerName]" y nos devuelve una DB vacía, [].

