# Aplicación de Control de Migración

## Descripción

Esta aplicación web desarrollada en C# con ASP.NET Core MVC proporciona un sistema de control de migración. Permite gestionar usuarios, viajeros, viajes y registros de entrada/salida.

## Requisitos Previos

- Visual Studio 2022
- .NET 6.0 SDK o superior
- SQL Server (LocalDB viene incluido con Visual Studio)

## Instalación y Configuración en Visual Studio

1. Clonar o descargar el repositorio en tu máquina local. (https://github.com/XAnderXZ/ControlMigracion.git)

2. Abrir Visual Studio 2022.

3. Seleccionar "Abrir un proyecto o una solución" y navegar hasta la carpeta del proyecto.

4. Seleccionar el archivo de solución (.sln) y hacer clic en "Abrir".

5. Una vez abierto el proyecto, abrir la Consola del Administrador de Paquetes:
   - Ir a "Herramientas" > "Administrador de paquetes NuGet" > "Consola del Administrador de Paquetes"

6. En la Consola del Administrador de Paquetes, ejecutar los siguientes comandos para instalar las dependencias necesarias:

Install-Package Microsoft.EntityFrameworkCore -Version 7.0.5
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 7.0.5
Install-Package Microsoft.EntityFrameworkCore.Tools -Version 7.0.5


## Configuración de la Base de Datos

1. Abrir el archivo `appsettings.json` en el Explorador de soluciones y verificar la cadena de conexión:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ControlMigracion;Trusted_Connection=True;MultipleActiveResultSets=true"
}

2. En la Consola del Administrador de Paquetes, ejecutar los siguientes comandos para crear y aplicar las migraciones:

Add-Migration InitialCreate
Update-Database
