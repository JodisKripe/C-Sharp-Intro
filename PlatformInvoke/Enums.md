Enums can be used in conjunction with APIs that have pre-determined values for their parameters. For instance, OpenProcess requires a set of ProcessAccessRights which are defined here. Instead of remembering values, we can define then in an enum - as long as the underlying datatype matches (in this case, uint), it will work.

The Flags attribute on the enum tells C# that the values can be treated as a bit field (i.e. you can perform bitwise operations on them). In the particular case of this API, it allows you to build up a desired access value of the exact privileges that you want the final handle to have.

> [DllImport(dllname:"kernel32", SetLastError = true)]
> static extern nint OpenProcess(ProcessAccessRights dwDesiredAccess, bool bInheritedHandle, uint dwProcessID);
>
> var hProcess = OpenProcess(dwDesiredAccess:ProcessAccessRights.PROCESS_VM_READ | ProcessAccessRights.PROCESS_VM_WRITE,
> bInheritedHandle = false, dwProcessID = 26728);
>
> [Flags]
> internal enum ProcessAccessRights : uint
> {
> //Many Missing for Brevity
> PROCESS_VM_READ = 0x0010,
> PROCESS_VM_WRITE = 0x0020,
> PROCESS_VM_OPERATION = 0x0008
> }
