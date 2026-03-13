# 🛒 Sistema de Gestión de Ventas (Desktop)

### 📝 Descripción
Aplicación de escritorio desarrollada para la gestión integral de ventas, clientes y productos. El sistema permite administrar la información de manera estructurada, facilitando el registro de operaciones comerciales y la emisión de comprobantes.

### 🏗️ Arquitectura del Proyecto
El sistema sigue un diseño de **Arquitectura en 3 Capas**, lo que garantiza la separación de responsabilidades y facilita el mantenimiento:
* **Capa de Entidades:** Definición de los objetos de negocio.
* **Capa de Datos:** Gestión de la persistencia y comunicación con SQL Server.
* **Capa de Presentación:** Interfaz de usuario intuitiva desarrollada con Windows Forms.

### 🚀 Conceptos Técnicos Aplicados
* **Programación Orientada a Objetos (POO):** * **Herencia y Abstracción:** Se implementó una clase abstracta `Cliente` de la cual heredan `ClienteIndividuo` y `ClienteEmpresa`, compartiendo atributos comunes como CUIT y dirección.
* **Gestión de Datos (CRUD):** * Implementación completa de operaciones para Crear, Leer, Actualizar y Eliminar (físico) registros en la base de datos.
* **Validaciones:** Uso de `MaskedTextBox` para formatos de CUIT y validaciones de tipos de datos en la entrada del usuario.

### 🛠️ Tecnologías Utilizadas
* **IDE:** Visual Studio 2022
* **Lenguaje:** C# (.NET Framework)
* **Base de Datos:** SQL Server
* **Interfaz:** Windows Forms (WinForms)

### ⚙️ Requisitos para Ejecutar el Proyecto
1. Clonar el repositorio.
2. Abrir el archivo `.sln` en **Visual Studio 2022**.
3. Configurar la cadena de conexión en la capa de datos para que apunte a tu instancia local de SQL Server.
4. Ejecutar el script de creación de tablas (incluido en la carpeta de base de datos).
