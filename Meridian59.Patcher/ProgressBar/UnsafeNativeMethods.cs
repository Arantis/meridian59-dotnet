﻿
// ************************************************************************************************************
// Filename:    UnsafeNativeMethods.cs
// Description: Potentially dangerous P/Invoke method declarations; be careful not to expose these publicly.
// Author:      Hiske Bekkering
// License:     Code Project Open License (CPOL)
// History:     March 1, 2016 - Initial Release
// ************************************************************************************************************

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CustomProgress
{

    [SuppressUnmanagedCodeSecurity]
    internal static class UnsafeNativeMethods
    {

        /* Prepares the specified window for painting and fills 
        a PAINTSTRUCT structure with information about the painting */
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = false)]
        internal static extern IntPtr BeginPaint(HandleRef hWnd, [In][Out] ref NativeMethods.PAINTSTRUCT lpPaint);

        /* Marks the end of painting in the specified window. 
        This function is required for each call to the BeginPaint 
        function, but only after painting is complete. */
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = false)]
        internal static extern bool EndPaint(HandleRef hWnd, ref NativeMethods.PAINTSTRUCT lpPaint);

    }

}
