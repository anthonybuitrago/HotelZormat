# HotelZormat: Sistema de Gestión Hotelera (MVP)

Proyecto Final de la asignatura **ISW-123 Programación Media** · 6to Semestre · Universidad Central del Este (UCE).

## Datos del Estudiante
- **Nombre:** Anthony Buitrago
- **Matrícula:** 2024-2047
- **Pasaporte / Identificación:** 143540342
- **Repositorio:** `HotelZormat-2024-2047`

---

## Stack Tecnológico y Arquitectura
- **Lenguaje:** C# 7.3 / .NET Framework 4.7.2
- **Presentación:** Windows Forms
- **Base de Datos:** SQL Server Express (`localhost\SQLEXPRESS`)
- **Patrón:** Repository Pattern sobre ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataReader`)
- **Arquitectura en 3 Capas + Modelo:**
  - `HotelZormat.UI`: Capa de presentación gráfica.
  - `HotelZormat.Negocio`: Lógica del sistema, modelos de dominio y servicios.
  - `HotelZormat.Datos`: Conexión y repositorios de datos ADO.NET.

---

## Instrucciones de Configuración y Ejecución

### 1. Restaurar la Base de Datos
1. Abrir **SQL Server Management Studio (SSMS)** o **Azure Data Studio**.
2. Conectarse a la instancia local `localhost\SQLEXPRESS`.
3. Abrir y ejecutar el archivo `script_bd.sql` ubicado en la raíz del repositorio.
4. El script creará la base de datos `HotelZormatDB`, sus 6 tablas (`Usuarios`, `Habitaciones`, `Huespedes`, `Reservas`, `Facturas`, `Bitacora`) e insertará los datos iniciales de prueba.

### 2. Cadena de Conexión (`App.config`)
La cadena de conexión está centralizada en `HotelZormat/App.config`:
```xml
<connectionStrings>
    <add name="HotelZormatDB" 
         connectionString="Data Source=localhost\SQLEXPRESS;Initial Catalog=HotelZormatDB;Integrated Security=True;" 
         providerName="System.Data.SqlClient" />
</connectionStrings>
```
*Si su instancia local de SQL Server tiene otro nombre (por ejemplo `.` o `SQLEXPRESS01`), modifique el campo `Data Source` en dicho archivo.*

---

## Credenciales de Acceso Iniciales

| Usuario | Contraseña | Rol | Permisos Especiales |
| :--- | :--- | :--- | :--- |
| **admin** | `admin123` | **Administrador** | Acceso total, Eliminar Habitaciones, Consulta de Bitácora |
| **recep** | `recep123` | **Recepcionista** | Gestión Operativa, Reservas, Check-In/Check-Out y Facturación |

---

## Funcionalidades Implementadas
- [x] **Login y Roles:** Autenticación con contraseña encriptada en SHA256 y diferenciación de permisos por rol.
- [x] **Dashboard de Habitaciones:** Tablero visual interactivo con colores por estado (`Verde`=Disponible, `Rojo`=Ocupada, `Naranja`=Reservada, `Azul`=Limpieza) mediante `switch`.
- [x] **CRUD Habitaciones:** Listar con filtros en SQL por piso y estado, Crear, Actualizar y Eliminar (con confirmación previa de confirmación `YesNo`).
- [x] **CRUD Huéspedes:** Registro con validación de **11 dígitos** para Cédula dominicana y soporte de Pasaporte. Búsqueda por cédula o nombre.
- [x] **Gestión de Reservas:** Cálculo automático de noches, validación `Check-Out > Check-In`, y factores de descuento por temporada (`Alta`: 0%, `Media`: 10%, `Baja`: 20%).
- [x] **Check-In / Check-Out y Facturación NCF:** Conversión de reservas a estadías activas, cálculo de Subtotal + ITBIS (18%) + Propina Legal (10%) y secuencia NCF Consumo Final (`B020000000X`).
- [x] **Reportes de Gestión:** (1) Ocupación del Día; (2) Ingresos Acumulados por Rango de Fecha.
- [x] **Bitácora de Auditoría:** Registro automático de acciones críticas del sistema (exclusivo para Administrador).
- [x] **Marcadores Anti-IA:** Encabezados en todos los archivos `.cs` con Pasaporte `143540342` y variable de Matrícula `20242047`.
