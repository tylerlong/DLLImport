# DllImport

Import unmanaged DLLs: User32.dll


## DLLs list

1. User32


## Usage Example

```C#
using DllImport;

User32.ShowWindow(handle, User32.SW_RESTORE);
```


## ToDo list

1. Publish to NuGet
1. rename to DLLImport
1. Use Enum to arrange const integers. (reference to source code of TaskbarSorter.2)
1. Why cannot Func instead of delegate?
