# DllImport

Import unmanaged DLLs


## DLLs list

- User32


## How to

1. Referece this project in your project
2. Call native methods like `DllImport.[DLL name].[method name]([method parameters])`, example: `DllImport.User32.ShowWindow(handle, DllImport.User32.SW_RESTORE);`


## ToDo list

- Publish to NuGet
