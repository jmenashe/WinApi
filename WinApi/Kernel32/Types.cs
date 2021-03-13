using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinApi.Kernel32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SystemInfo
    {
        public ushort ProcessorArchitecture;
        ushort Reserved;
        public uint PageSize;
        public IntPtr MinimumApplicationAddress;
        public IntPtr MaximumApplicationAddress;
        public IntPtr ActiveProcessorMask;
        public uint NumberOfProcessors;
        public uint ProcessorType;
        public uint AllocationGranularity;
        public ushort ProcessorLevel;
        public ushort ProcessorRevision;
        public uint OemId => ((uint) this.ProcessorArchitecture << 8) | this.Reserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SecurityAttributes
    {
        public uint Length;
        public IntPtr SecurityDescriptor;
        public uint IsHandleInheritedValue;

        public bool IsHandleInherited => this.IsHandleInheritedValue > 0;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FileTime
    {
        public uint Low;
        public uint High;

        public ulong Value => ((ulong) this.High << 32) | this.Low;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SystemTime
    {
        public ushort Year;
        public ushort Month;
        public ushort DayOfWeek;
        public ushort Day;
        public ushort Hour;
        public ushort Minute;
        public ushort Second;
        public ushort Milliseconds;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FileAttributeData
    {
        public FileAttributes Attributes;
        public FileTime CreationTime;
        public FileTime LastAccessTime;
        public FileTime LastWriteTime;

        public uint FileSizeHigh;
        public uint FileSizeLow;

        public ulong FileSize => ((ulong) this.FileSizeHigh << 32) | this.FileSizeLow;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MemoryInformation
    {
        public IntPtr BaseAddress;
        public IntPtr AllocationBase;
        public MemoryProtectionFlag AllocationProtect;
        public IntPtr RegionSize;
        public MemoryState State;
        public MemoryProtectionFlag Protect;
        public MemoryType Type;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MemoryInformation_64
    {
        public ulong BaseAddress;
        public ulong AllocationBase;
        public MemoryProtectionFlag AllocationProtect;
        public int __alignment1;
        public ulong RegionSize;
        public MemoryState State;
        public MemoryProtectionFlag Protect;
        public MemoryType Type;
        public int __alignment2;
    }
}