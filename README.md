# 🌐 FAFS — *Fast Access to Favorite Sites*

**FAFS** es una aplicación web moderna que permite buscar destinos turísticos, acceder rápidamente a información relevante y mantener una lista personalizada de lugares favoritos.  
El proyecto está construido sobre **ABP.IO**, utiliza **DDD**, integra APIs externas y ofrece un ecosistema completo con autenticación, notificaciones, métricas y un panel administrativo.

> 🚀 *Una plataforma rápida, modular y extensible para explorar destinos y gestionar sitios favoritos.*

---

## ✨ Características Principales

### 🔍 Búsqueda de ciudades y destinos turísticos
- Integración con API externa (GeoDB Cities)
- Búsqueda por nombre, país o prefijo
- Resultados con país, población, coordenadas e imagen

### 📌 Lista personal de destinos favoritos
- Guardar destinos en una lista personalizada
- Información persistida en la base interna
- Actualizaciones automáticas cuando cambian datos del destino

### 🔔 Notificaciones inteligentes
- Notificaciones en pantalla y por correo
- Cambios relevantes: nuevos eventos, actualizaciones de datos, etc.
- Configuración por usuario (inmediatas o resumen semanal)

### ⭐ Calificaciones y comentarios
- Los usuarios pueden puntuar destinos (1 a 5 estrellas)
- Comentarios privados por destino
- Edición y eliminación de calificaciones

### 🛠️ Panel de Administración
- Gestión de usuarios y roles
- Métricas del sistema:
  - Destinos más buscados  
  - Cantidad de búsquedas  
  - Tiempos de respuesta de la API  
- Logs y auditoría integrados

### 🔐 Seguridad
- Autenticación y autorización mediante Identity ABP
- Roles: **Administrador** y **Usuario**
- Protección contra CSRF, XSS, validaciones y hashing de contraseñas

---

## 👤 Autores
Alumno: **Ramos, Alexander Javier**
Proyecto desarrollado para **UTN – Facultad Regional Concepción del Uruguay**  
Materia: *Desarrollo de Software — Año 2025*
