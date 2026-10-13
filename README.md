# 🌐 Proyecto de Introducción al Mundo Web con .NET 10 MVC y Bootstrap

Este proyecto es una **aplicación web desarrollada en .NET 10 MVC** que tiene como objetivo introducir los conceptos fundamentales del desarrollo web moderno. Se utiliza **Bootstrap** como framework de diseño para implementar sus componentes más importantes y aplicar sus clases directamente en las etiquetas HTML.

---

## 🚀 Características principales

- **Framework:** .NET 10 MVC  
- **Frontend:** Bootstrap 5  
- **Diseño responsivo:** Adaptación automática a distintos dispositivos  
- **Componentes utilizados:**
  - Navbar
  - Cards
  - Botones
  - Formularios
  - Grid System
- **Buenas prácticas:** Uso correcto de clases de Bootstrap en etiquetas HTML

---

## 📂 Estructura del proyecto

- `Controllers/` → Controladores MVC para manejar la lógica de negocio  
- `Views/` → Vistas Razor con integración de Bootstrap  
- `Models/` → Modelos para representar datos  
- `wwwroot/` → Archivos estáticos (CSS, JS, imágenes)  

---

## 🛠️ Requisitos previos

- Visual Studio 2022 o superior  
- SDK de .NET 10 instalado  
- Conexión a internet para cargar dependencias de Bootstrap  

---

## ▶️ Ejecución del proyecto

1. Clonar el repositorio:
```bash
git clone https://github.com/usuario/proyecto-dotnet-mvc-bootstrap.git
```
2. Abrir la solución en Visual Studio.

3. Restaurar paquetes NuGet.

4. Ejecutar con Ctrl + F5 para iniciar el servidor local.

5. Acceder en el navegador a:
```
http://localhost:5281
```

# 📄 README del archivo .gitignore

Este archivo `.gitignore` está diseñado para proyectos **.NET 10 MVC** con integración de **Bootstrap**.  
Su propósito es evitar que se suban a GitHub archivos innecesarios, temporales o específicos del entorno local.

---

## 🚫 Archivos y carpetas ignoradas

- **Compilación:** `bin/`, `obj/`, `Debug/`, `Release/`  
  > Se generan automáticamente al compilar el proyecto.

- **Configuración local:** `.vs/`, `*.user`, `*.suo`  
  > Archivos propios de Visual Studio, no relevantes para otros desarrolladores.

- **Paquetes NuGet:** `packages/`, `*.nupkg`  
  > Se restauran automáticamente con `dotnet restore`.

- **Logs y temporales:** `*.log`, `*.tmp`, `*.bak`  
  > Archivos de depuración y temporales que no deben versionarse.

- **Configuraciones sensibles:** `appsettings.Development.json`, `appsettings.Local.json`  
  > Contienen datos específicos del entorno local (ej. cadenas de conexión).

- **Dependencias de Node:** `node_modules/`  
  > Solo necesarias en el entorno local si se usa npm/yarn para Bootstrap.

---

## 🔄 Mantenimiento del .gitignore

1. **Revisar dependencias nuevas:**  
   Si agregas librerías o frameworks que generan archivos temporales, añade sus carpetas aquí.

2. **Evitar datos sensibles:**  
   Nunca subas configuraciones con contraseñas o claves API.  
   Usa variables de entorno o archivos locales ignorados.

3. **Actualizar según el IDE:**  
   Si cambias de editor (ej. JetBrains Rider), incluye sus carpetas de configuración (`.idea/`).

---

## ✅ Beneficios

- Repositorio más limpio y profesional.  
- Evita conflictos entre entornos de desarrollo.  
- Facilita la colaboración en equipo.