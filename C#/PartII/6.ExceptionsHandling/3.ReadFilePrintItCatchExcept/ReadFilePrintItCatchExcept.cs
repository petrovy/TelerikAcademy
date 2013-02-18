﻿/* Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
 reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
 Be sure to catch all possible exceptions and print user-friendly error messages. */

using System;
using System.IO;
using System.Security;

class ReadFilePrintItCatchExcept
{
    static void Main()
    {
        try
        {
            Console.WriteLine(System.IO.File.ReadAllText(@"C:\S\Google Диск\TelerikAcademy\Web\02. CSS\2.CSS-Presentation\Homework\OnlyHTML&CSSFiles\1.ParagraphFirstLetter+CSS.html"));
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("path is null");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Path specified a file that is read-only -or- This operation is not supported on the current platform. -or- Path specified a directory. -or- The caller does not have the required permission.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file specified in path was not found");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("path is in an invalid format");
        }
        catch (SecurityException)
        {
            Console.WriteLine("The caller does not have the required permission.");
        }
    }
}

/* System.IO.File.ReadAllText Exceptions:
1. ArgumentException	
    path is a zero-length string, contains only white space, or contains one or more invalid characters as defined by InvalidPathChars.
2. ArgumentNullException - path is null.
3. PathTooLongException	-  The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.
4. DirectoryNotFoundException - The specified path is invalid (for example, it is on an unmapped drive).
5. IOException  -  An I/O error occurred while opening the file.
6. UnauthorizedAccessException	-  path specified a file that is read-only.
        -or-
    This operation is not supported on the current platform.
        -or-
    path specified a directory.
        -or-
    The caller does not have the required permission.
7. FileNotFoundException - The file specified in path was not found.
8. NotSupportedException - path is in an invalid format.
9. SecurityException - The caller does not have the required permission. */