# Proyecto
# 📦 Instalación de MiProyecto

Este proyecto es una aplicación de escritorio desarrollada en *C# (.NET Framework/.NET Core)* que utiliza *MySQL* como base de datos.

---

## 🚀 Requisitos previos

Antes de instalar la aplicación asegúrate de tener:

- ✅ *Windows 10/11* (64 bits recomendado)  
- ✅ *.NET Framework / .NET Runtime* (según la versión usada en el proyecto)  
- ✅ *MySQL Server* instalado o acceso a una base de datos en la nube  
- ✅ *Conexión a Internet* (si la base de datos está en Hostinger u otro hosting)

---

## 🔧 Instalación paso a paso

1. Descarga el instalador (Setup.exe) desde la carpeta de distribución o desde [Releases](#)  
2. Haz doble clic en Setup.exe y sigue las instrucciones del asistente.  
3. Selecciona la carpeta de instalación (por defecto:  
   C:\Program Files\MiProyecto).  
4. Espera a que finalice la instalación y pulsa *Finalizar*.  
5. La aplicación quedará disponible en:  
   - Menú *Inicio → MiProyecto*  
   - O un acceso directo en el Escritorio (si lo seleccionaste durante la instalación).

---

## ⚙ Configuración inicial

1. Abre el archivo app.config o config.json (según tu proyecto).  
2. Configura la cadena de conexión a MySQL con tus datos:  

   ```xml
   <connectionStrings>
       <add name="ConexionMySQL" 
            connectionString="Server=TU_IP;Database=TU_DB;Uid=TU_USUARIO;Pwd=TU_PASSWORD;" 
            providerName="MySql.Data.MySqlClient" />
   </connectionStrings>
