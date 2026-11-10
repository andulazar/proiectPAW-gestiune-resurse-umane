# Gestiune resurse umane (Human Resources Management) – C# WinForms

A Windows Forms desktop application (.NET Framework 4.7.2) for managing a company's employees,
their jobs and the training courses they have completed. Built as a project for the
*Programarea Aplicațiilor Windows* (PAW) course.

## Features

- **Employee list** (`ListView`) with name, CNP, date of birth, job, salary and number of courses.
- **Add / edit / delete employees**
  - edit with the *Edit employee* button, a double-click or <kbd>Enter</kbd>;
  - delete with the *Delete employee* button or <kbd>Delete</kbd> (with confirmation).
- **Courses**: add and remove the courses an employee has graduated (name + number of hours).
- **Sort by salary** (ascending / descending), implemented with `IComparable<employee>`.
- **Validation**: required name, CNP of exactly 13 digits and unique among employees,
  positive salary, positive whole number of course hours, birth date not in the future.
- Editing works on a **clone** of the employee (`ICloneable`), so pressing *Cancel* discards all changes.

## Class model

| Class      | Description |
|------------|-------------|
| `person`   | base class – `fullName`, `birthDate`, `cNP` |
| `employee` | derives from `person`; has a `job` and a `List<course>`; implements `ICloneable` (deep copy) and `IComparable<employee>` (by salary) |
| `job`      | `jobName`, `salary`, read-only `jobId` |
| `course`   | `courseName`, `numberOfhours`, read-only `courseId` |
| `Form1`    | main window – employee list and actions |
| `Formemployee` | add / edit dialog for one employee |

## Running

1. Open `proiectPAW-gestiune-resurse-umane.sln` in **Visual Studio 2019/2022** (workload *.NET desktop development*).
2. Press <kbd>F5</kbd>.

Requires Windows with .NET Framework 4.7.2 or later.
