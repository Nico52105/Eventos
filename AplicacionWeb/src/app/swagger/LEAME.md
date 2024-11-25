Cconfiguracion de swagger

1. Instalar el comlemento npm install -g ng-openapi-gen
4. Generar u obtener el archivo de configuracion swagger.json de los servicios e incluirlo en la ruta src/app/swagger/{nombrearchivo}.json
3. En consola vamos a ejecutar el siguiente comando para realizar la generacion correspondiente de archivos para el consumo segun el archivo swagger.json generado e incluido anteriormente: ng-openapi-gen --input src/app/swagger/{nombrearchivo}.json --output src/app/swagger/{nombrecarpeta}
4. Consumir los servicios como cualquiera directamente del archivo generado de servicios para {nombrearchivo} teniendo en cuenta que cada metodo es un observable y no se ejecuta hasta realizar la suscripcion
5. En el archivo app.module.ts debe estar en la seccion imports el modulo 'HttpClientModule'
