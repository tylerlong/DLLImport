# DLLImport

Import unmanaged DLLs: User32.dll


## DLLs list

1. User32


## Usage Example

```C#
using DLLImport;

User32.ShowWindow(handle, User32.SW_RESTORE);
```


## ToDo list

1. Publish to NuGet
2. Replace constants with enums, reference: http://stackoverflow.com/questions/11811106/c-sharp-setwineventhook-fails-returns-0
