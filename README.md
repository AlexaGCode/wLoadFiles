# wLoadFiles – Carga de archivos planos y CSV en C# Windows Forms

## Descripción

Este proyecto es una aplicación de escritorio desarrollada en **C# con Windows Forms** que permite cargar y visualizar información desde archivos externos en formato `.txt` y `.csv`.

La aplicación permite leer archivos planos línea por línea y mostrar su contenido en un `TextBox`, así como cargar archivos CSV separados por punto y coma `;` en un `DataGridView`.

El proyecto tiene un propósito académico y está orientado al aprendizaje del manejo de archivos, programación orientada a eventos y uso de controles gráficos en Windows Forms.

---

## Objetivo

Implementar una aplicación Windows Forms que permita seleccionar, leer y visualizar archivos planos y archivos CSV, aplicando conceptos básicos de manejo de archivos, eventos y controles visuales en C#.

---

## Tecnologías utilizadas

- C#
- Windows Forms
- .NET Framework 4.7.2
- Visual Studio
- Controles principales:
  - `Button`
  - `TextBox`
  - `DataGridView`
  - `OpenFileDialog`

---

## Funcionalidades

- Carga de archivos planos `.txt`.
- Lectura de contenido línea por línea.
- Visualización del texto cargado en un `TextBox`.
- Carga de archivos `.csv`.
- Separación de datos usando punto y coma `;`.
- Visualización de registros en un `DataGridView`.

---

## Estructura general del proyecto

```text
wLoadFiles/
│
├── wLoadFiles.sln
│
└── wLoadFiles/
    ├── Program.cs
    ├── Form1.cs
    ├── Form1.Designer.cs
    ├── Form1.resx
    └── wLoadFiles.csproj
```

---

## Cómo ejecutar el proyecto

1. Clonar el repositorio:

```bash
git clone https://github.com/AlexaGCode/wLoadFiles.git
```

2. Abrir la solución en Visual Studio:

```text
wLoadFiles.sln
```

3. Ejecutar el proyecto desde Visual Studio.

4. Usar los botones de la interfaz para cargar:

   - Archivo plano `.txt`.
   - Archivo `.csv`.

---

## Archivos de prueba sugeridos

### Archivo plano `.txt`

Crear un archivo llamado:

```text
archivo_prueba.txt
```

Contenido sugerido:

```txt
Producto: Mouse inalámbrico
Cantidad: 15
Precio: 45000
Proveedor: TecnoStore
```

---

### Archivo CSV `.csv`

Crear un archivo llamado:

```text
productos.csv
```

Contenido sugerido:

```csv
Mouse inalámbrico;15;45000
Teclado mecánico;8;120000
Monitor 24 pulgadas;5;680000
Memoria USB 64GB;20;32000
```

---

## Observaciones técnicas

El desarrollo cumple con el objetivo básico de cargar archivos, pero puede mejorarse en varios aspectos:

- Separar la lógica de lectura de archivos de la interfaz gráfica.
- Validar que el archivo CSV tenga la cantidad correcta de columnas.
- Validar datos numéricos como cantidad y precio.
- Limpiar el `TextBox` y el `DataGridView` antes de cargar nuevos archivos.
- Agregar manejo de errores en todas las operaciones.
- Crear una clase de dominio, por ejemplo `Producto`.
- Mejorar los mensajes mostrados al usuario.

---

## Uso académico

Este proyecto puede ser utilizado como ejercicio práctico para estudiantes que están aprendiendo:

- Manejo de archivos en C#.
- Programación orientada a eventos.
- Uso de Windows Forms.
- Controles gráficos básicos.
- Validación de datos.
- Análisis crítico de código fuente.

---

## Mejoras sugeridas para futuras versiones

Algunas mejoras recomendadas para fortalecer el proyecto son:

1. Crear una clase `Producto` para representar los datos cargados desde el archivo CSV.
2. Separar la lógica de lectura de archivos en una clase independiente.
3. Implementar validaciones para archivos vacíos o mal estructurados.
4. Agregar mensajes de confirmación al usuario.
5. Mostrar la cantidad de registros cargados.
6. Evitar la duplicación de datos al cargar varios archivos.
7. Implementar pruebas con diferentes archivos de entrada.

---

## Ejemplo de estructura esperada para el CSV

El archivo CSV debe manejar la siguiente estructura:

```csv
NombreProducto;Cantidad;Precio
Mouse inalámbrico;15;45000
Teclado mecánico;8;120000
Monitor 24 pulgadas;5;680000
```

> Nota: si el código actual no contempla encabezados, se recomienda cargar archivos sin encabezado o ajustar la lógica para ignorar la primera línea.

---

## Autor

Proyecto desarrollado con fines académicos.

Repositorio:

```text
https://github.com/AlexaGCode/wLoadFiles
```
