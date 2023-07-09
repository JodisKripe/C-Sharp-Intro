# Marshalling

Some Windows APIs such as LoadLibraryW require an LPCWSTR, which is a pointer to a null-terminated 16-bit unicode string. P/Invoke can automatically marshal between managed and unmanaged datatypes using the MarshalAs attribute, so we don't have to do it manually.

> [DllImport(dllname:"kernel32",SetLastError = true)]
> static extern nint LoadLibraryW(
> [MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName
> );
>
> var hProcess:nint = LoadLibraryW(lpLibFileName:"amsi.dll");
