# wLoadFiles – Carga de Archivos Planos y CSV en C# Windows Forms

## Descripción del proyecto

Este proyecto es una aplicación de escritorio desarrollada en **C# con Windows Forms** que permite cargar y visualizar información desde archivos externos en formato `.txt` y `.csv`.

La aplicación permite realizar dos operaciones principales:

1. **Leer archivos planos `.txt`** línea por línea y mostrar su contenido en un `TextBox`.
2. **Leer archivos `.csv`** separados por punto y coma `;` y cargar sus datos en un `DataGridView`.

Este ejercicio tiene un propósito académico y está orientado al aprendizaje del manejo de archivos, eventos, controles gráficos y validación básica de datos en aplicaciones Windows Forms.

---

## Objetivo del ejercicio

Implementar una aplicación Windows Forms que permita seleccionar, leer y visualizar archivos planos y archivos CSV, aplicando conceptos básicos de programación orientada a eventos, manejo de archivos, uso de controles visuales y análisis crítico de la calidad del código.

---

## Tecnologías utilizadas

- Lenguaje: **C#**
- Framework: **.NET Framework 4.7.2**
- Tipo de aplicación: **Windows Forms**
- IDE recomendado: **Visual Studio 2019 o superior**
- Controles principales:
  - `Button`
  - `TextBox`
  - `DataGridView`
  - `OpenFileDialog`

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
