# AppCrud - Sistema CRUD en ASP.NET MVC con .NET 8 y Entity Framework

### 🚀 Descripción
Aplicación básica de **CRUD** desarrollada en:
- **ASP.NET MVC** .
- **.NET 8**.
- **Entity Framework Core** (ORM para la base de datos).

---

### ⚙️ Configuración Inicial

1. **Base de Datos**:
   - Revisa el archivo `appsettings.json` y configura la cadena de conexión (`ConnectionString`) según tu entorno (local, SQL Server, etc.).
   - Ejemplo:
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=.;Database=AppCrudDB;Trusted_Connection=True;TrustServerCertificate=True;"
     }
     ```

2. **Migraciones**:
   - Abre la **Consola del Administrador de Paquetes** (Package Manager Console) en Visual Studio.
   - Ejecuta el siguiente comando para crear la base de datos:
     ```bash
     Update-Database
     ```
     Esto aplicará las migraciones y generará la estructura de tablas definida en el proyecto.

---

### ▶️ Ejecutar el Proyecto
1. Presiona `F5` en Visual Studio o ejecuta:
   ```bash
   dotnet run